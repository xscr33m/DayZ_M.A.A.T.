using DayZ_MAAT._Core._Forms;
using DayZ_MAAT._Core._Language._Stringtables;
using DayZ_MAAT.Properties;
using FontAwesome.Sharp;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayZ_MAAT._Core._Engine._Converter
{
    internal class TraderConverter
    {
        readonly static string LogFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs");
        readonly static string OutputFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Output");
        readonly static string ErrorLogFilePath = Path.Combine(LogFolderPath, "ErrorLog.txt");
        readonly static string conversionLogFilePath = Path.Combine(LogFolderPath, "TraderConverterLog.txt");
        public string userLanguageKey = Settings.Default.LanguageKey;

        public async void ConvertTraderToTPPC(string filePath)
        {
            if (filePath.Length == 0)
            {
                CustomMessage popUpMessage = new CustomMessage();
                SystemSounds.Exclamation.Play();
                popUpMessage.ButtonOkay.Visible = true;
                popUpMessage.ButtonOkay.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_ButtonOk");
                popUpMessage.IconPictureBox.IconChar = IconChar.Xmark;
                popUpMessage.IconPictureBox.IconColor = Color.Red;
                popUpMessage.LabelMessageContent.Text = TraderConverterRes.ResourceManager.GetString(userLanguageKey + "_LogNoInput");
                popUpMessage.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_TitleError");
                popUpMessage.ButtonNo.Visible = false;
                popUpMessage.ButtonYes.Visible = false;
                if (popUpMessage.ShowDialog() == DialogResult.OK)
                {
                    if (!Directory.Exists(LogFolderPath))
                    {
                        Directory.CreateDirectory(LogFolderPath);
                    }

                    File.AppendAllText(conversionLogFilePath, TraderConverterRes.ResourceManager.GetString(userLanguageKey + "_LogNoInput") + "\n"); 
                    await FormMain.Instance.ShowNotification(TraderConverterRes.ResourceManager.GetString(userLanguageKey + "_LabelNoInput"), IconChar.Xmark, Color.Red);
                }
            }
            else
            {
                if (File.Exists(conversionLogFilePath))
                {
                    CustomMessage messageBox = new CustomMessage();
                    SystemSounds.Exclamation.Play();
                    messageBox.ButtonOkay.Visible = false;
                    messageBox.IconPictureBox.IconChar = IconChar.Warning;
                    messageBox.IconPictureBox.ForeColor = Color.Yellow;
                    messageBox.LabelMessageContent.Text = TraderConverterRes.ResourceManager.GetString(userLanguageKey + "_ExistingFile");
                    messageBox.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_TitleQuestion");
                    messageBox.ButtonNo.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_ButtonNo");
                    messageBox.ButtonYes.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_ButtonYes");
                    messageBox.ButtonNo.Visible = true;
                    messageBox.ButtonYes.Visible = true;

                    if (messageBox.ShowDialog() == DialogResult.No)
                    {
                        await FormMain.Instance.ShowNotification(TraderConverterRes.ResourceManager.GetString(userLanguageKey + "_Canceled"), IconChar.Warning, Color.Yellow);
                        return;
                    }
                }

                if (!Directory.Exists(LogFolderPath))
                {
                    Directory.CreateDirectory(LogFolderPath);
                }

                try
                {
                    File.AppendAllText(conversionLogFilePath, $"{DateTime.Now}: " + TraderConverterRes.ResourceManager.GetString(userLanguageKey + "_LogStartConvert") + $"Input: {filePath}\n");

                    // Pfade zur Eingabe-Textdatei und Ausgabe-JSON-Datei
                    string inputFilePath = filePath;
                    string outputFilePath = Path.Combine(OutputFolderPath, "TraderPlusPriceConfig.json");

                    // Lese die gesamte Textdatei ein
                    string[] lines = File.ReadAllLines(inputFilePath);

                    // Initialisiere die Trader-Kategorien-Liste
                    List<TraderCategory> traderCategories = new List<TraderCategory>();

                    // Initialisiere die aktuelle Trader-Kategorie
                    TraderCategory currentCategory = null;

                    // Initialisiere Zähler für Produkte und Kategorien
                    int productCount = 0;
                    int categoryCount = 0;

                    bool invalidProductFound = false;

                    // Initialisiere eine Liste für fehlerhafte Zeilen
                    List<string> errorLines = new List<string>();

                    // Durchlaufe alle Zeilen der Textdatei
                    for (int i = 0; i < lines.Length; i++)
                    {
                        string line = lines[i];
                        // Entferne führende und abschließende Leerzeichen und Tabs
                        string trimmedLine = line.Trim();

                        // Ignoriere Kommentarzeilen und Zeilen mit CurrencyName und Trader
                        if (trimmedLine.StartsWith("//") || trimmedLine.StartsWith("<CurrencyName>") || trimmedLine.StartsWith("<Trader>"))
                        {
                            File.AppendAllText(conversionLogFilePath, TraderConverterRes.ResourceManager.GetString(userLanguageKey + "_LogIgnoredLine") + $"{i + 1}: {trimmedLine}>" + "\n");
                            continue;
                        }

                        // Ignoriere Leerzeilen
                        if (string.IsNullOrWhiteSpace(trimmedLine))
                        {
                            File.AppendAllText(conversionLogFilePath, TraderConverterRes.ResourceManager.GetString(userLanguageKey + "_LogIgnoredEmptyLine") + $"{i + 1}>" + "\n");
                            continue;
                        }

                        // Entferne Kommentare am Ende der Zeile
                        int commentIndex = trimmedLine.IndexOf("//");
                        if (commentIndex >= 0)
                            trimmedLine = trimmedLine.Substring(0, commentIndex).Trim();

                        File.AppendAllText(conversionLogFilePath, TraderConverterRes.ResourceManager.GetString(userLanguageKey + "_LogConvertLine") + $"{i + 1}: {trimmedLine}>" + "\n");

                        if (trimmedLine.StartsWith("<Category>"))
                        {
                            // Neue Kategorie gefunden
                            string categoryName = trimmedLine.Replace("<Category>", "").Trim();
                            currentCategory = new TraderCategory { CategoryName = categoryName };
                            traderCategories.Add(currentCategory);
                            categoryCount++;
                        }
                        else if (currentCategory != null && !trimmedLine.StartsWith("<FileEnd>"))
                        {
                            // Produkt gefunden
                            string[] productInfo = trimmedLine.Split(',').Select(info => info.Trim()).ToArray();
                            if (productInfo.Length >= 4)
                            {
                                string productName = productInfo[0];
                                string ek = productInfo[2];
                                string vk = productInfo[3];

                                string productData = string.Join(",", productName, "1", "-1", "1", ek, vk);
                                currentCategory.Products.Add(productData);
                                productCount++;
                            }
                            else
                            {
                                invalidProductFound = true;
                                errorLines.Add(TraderConverterRes.ResourceManager.GetString(userLanguageKey + "_LogConvertError1") + $" {i + 1}: " + TraderConverterRes.ResourceManager.GetString(userLanguageKey + "_LogConvertError2"));
                            }
                        }
                    }

                    // Erstelle das JSON-Objekt
                    var jsonObject = new
                    {
                        Version = "2.5",
                        EnableAutoCalculation = 0,
                        EnableAutoDestockAtRestart = 0,
                        EnableDefaultTraderStock = 0,
                        TraderCategories = traderCategories
                    };

                    // Serialisiere das JSON-Objekt in eine formatierte JSON-Zeichenkette
                    string json = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);

                    if (!Directory.Exists(OutputFolderPath))
                    {
                        Directory.CreateDirectory(OutputFolderPath);
                    }

                    // Schreibe das JSON in die Ausgabe-Datei
                    File.WriteAllText(outputFilePath, json);

                    if (errorLines.Count > 0)
                    {
                        File.AppendAllText(conversionLogFilePath, "\nRESULTS:\n" + TraderConverterRes.ResourceManager.GetString(userLanguageKey + "_LogTotalError") + "\n");
                        foreach (var errorLine in errorLines)
                        {
                            File.AppendAllText(conversionLogFilePath, errorLine);
                        }
                        File.AppendAllText(conversionLogFilePath, TraderConverterRes.ResourceManager.GetString(userLanguageKey + "_LogTotalErrorHint") + "\n");
                    }

                    File.AppendAllText(conversionLogFilePath, TraderConverterRes.ResourceManager.GetString(userLanguageKey + "_LogTotalCategories") + $" {categoryCount}>" + "\n");
                    File.AppendAllText(conversionLogFilePath, TraderConverterRes.ResourceManager.GetString(userLanguageKey + "_LogTotalProducts") + $" {productCount}>" + "\n");
                    File.AppendAllText(conversionLogFilePath, $"Output: \"{outputFilePath}\"\n");
                    File.AppendAllText(conversionLogFilePath, $"{DateTime.Now}: " + TraderConverterRes.ResourceManager.GetString(userLanguageKey + "_LogConvertFinish") + "\n\n\n");

                    if (!invalidProductFound)
                    {
                        await FormMain.Instance.ShowNotification(TraderConverterRes.ResourceManager.GetString(userLanguageKey + "_LabelStatusFinished"), IconChar.Check, Color.Green);
                        await Task.Delay(1000);
                    }
                    else
                    {
                        await FormMain.Instance.ShowNotification(TraderConverterRes.ResourceManager.GetString(userLanguageKey + "_LabelStatusErrored"), IconChar.Warning, Color.Yellow);
                        await Task.Delay(1000);
                    }

                    FormMain.Instance.StopWorkingStatus();
                }
                catch (Exception ex)
                {
                    CustomMessage popUpMessage = new CustomMessage();
                    SystemSounds.Exclamation.Play();
                    popUpMessage.ButtonOkay.Visible = true;
                    popUpMessage.ButtonOkay.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_ButtonOk");
                    popUpMessage.IconPictureBox.IconChar = IconChar.Xmark;
                    popUpMessage.IconPictureBox.IconColor = Color.Red;
                    popUpMessage.LabelMessageContent.Text = TraderConverterRes.ResourceManager.GetString(userLanguageKey + "_LogConvertFatalError") + $" {ex.Message}>\n";
                    popUpMessage.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_TitleError");
                    popUpMessage.ButtonNo.Visible = false;
                    popUpMessage.ButtonYes.Visible = false;
                    if (popUpMessage.ShowDialog() == DialogResult.OK)
                    {
                        File.AppendAllText(ErrorLogFilePath, TraderConverterRes.ResourceManager.GetString(userLanguageKey + "_LogConvertFatalError") + $" {ex.Message}>" + "\n");
                        FormMain.Instance.StopWorkingStatus();
                    }
                }
            }
        }
    }

    internal class TraderCategory
    {
        public string CategoryName { get; set; }
        public List<string> Products { get; set; }

        public TraderCategory()
        {
            Products = new List<string>();
        }
    }
}
