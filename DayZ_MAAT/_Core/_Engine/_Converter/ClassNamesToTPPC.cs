using DayZ_MAAT._Core._Forms;
using DayZ_MAAT._Core._Language._Stringtables;
using DayZ_MAAT.Properties;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace DayZ_MAAT._Core._Engine._Converter
{
    internal class ClassNamesToTPPC
    {
        readonly static string LogFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs");
        readonly static string OutputFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Output");
        readonly static string ErrorLogFilePath = Path.Combine(LogFolderPath, "ErrorLog.txt");
        readonly static string conversionLogFilePath = Path.Combine(LogFolderPath, "ClassNameConverterLog.txt");
        public string userLanguageKey = Settings.Default.LanguageKey;

        public async void ConvertClassNameToTPPC(string filePath)
        {
            if (filePath.Length == 0)
            {
                CustomMessage popUpMessage = new CustomMessage();
                SystemSounds.Exclamation.Play();
                popUpMessage.ButtonOkay.Visible = true;
                popUpMessage.ButtonOkay.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_ButtonOk");
                popUpMessage.IconPictureBox.IconChar = IconChar.Xmark;
                popUpMessage.IconPictureBox.IconColor = Color.Red;
                popUpMessage.LabelMessageContent.Text = ClassNamesToTPPCRes.ResourceManager.GetString(userLanguageKey + "_LogNoInput");
                popUpMessage.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_TitleError");
                popUpMessage.ButtonNo.Visible = false;
                popUpMessage.ButtonYes.Visible = false;
                if (popUpMessage.ShowDialog() == DialogResult.OK)
                {
                    if (!Directory.Exists(LogFolderPath))
                    {
                        Directory.CreateDirectory(LogFolderPath);
                    }

                    File.AppendAllText(conversionLogFilePath, ClassNamesToTPPCRes.ResourceManager.GetString(userLanguageKey + "_LogNoInput") + "\n");
                    await FormMain.Instance.ShowNotification(ClassNamesToTPPCRes.ResourceManager.GetString(userLanguageKey + "_LabelNoInput"), IconChar.Xmark, Color.Red);
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
                    messageBox.LabelMessageContent.Text = ClassNamesToTPPCRes.ResourceManager.GetString(userLanguageKey + "_ExistingFile");
                    messageBox.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_TitleQuestion");
                    messageBox.ButtonNo.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_ButtonNo");
                    messageBox.ButtonYes.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_ButtonYes");
                    messageBox.ButtonNo.Visible = true;
                    messageBox.ButtonYes.Visible = true;

                    if (messageBox.ShowDialog() == DialogResult.No)
                    {
                        await FormMain.Instance.ShowNotification(ClassNamesToTPPCRes.ResourceManager.GetString(userLanguageKey + "_Canceled"), IconChar.Warning, Color.Yellow);
                        return;
                    }
                }

                if (!Directory.Exists(LogFolderPath))
                {
                    Directory.CreateDirectory(LogFolderPath);
                }

                if (!Directory.Exists(OutputFolderPath))
                {
                    Directory.CreateDirectory(OutputFolderPath);
                }

                try
                {
                    File.AppendAllText(conversionLogFilePath, $"{DateTime.Now}: " + ClassNamesToTPPCRes.ResourceManager.GetString(userLanguageKey + "_LogStartConvert") + $"Input: \"{filePath}\"\n");

                    // Pfade zur Eingabe-Textdatei und Ausgabe-JSON-Datei
                    string inputFilePath = filePath;
                    string outputFilePath = Path.Combine(OutputFolderPath, "TraderPlusPriceConfig.json");

                    // List für die formatierten Einträge und Kategorien
                    List<string> formattedEntries = new List<string>();
                    List<Dictionary<string, object>> categories = new List<Dictionary<string, object>>();

                    // Lesen der gesamten Eingabedatei
                    string[] lines = File.ReadAllLines(inputFilePath);

                    bool categoryFound = false;
                    int convertedClassNamesCount = 0; // Zähler für konvertierte ClassNames

                    foreach (string line in lines)
                    {
                        // Ignorieren leerer Zeilen
                        if (string.IsNullOrWhiteSpace(line))
                        {
                            File.AppendAllText(conversionLogFilePath, ClassNamesToTPPCRes.ResourceManager.GetString(userLanguageKey + "_LogIgnoredEmptyLine") + "\n");
                            continue;
                        }

                        // Log für die konvertierte Zeile schreiben
                        File.AppendAllText(conversionLogFilePath, $"{ClassNamesToTPPCRes.ResourceManager.GetString(userLanguageKey + "_LogConvertLine")}: {line}\n");

                        // Überprüfen, ob die Zeile mit "##" oder "//" beginnt, und als Kategorie behandeln
                        if (line.StartsWith("##") || line.StartsWith("//"))
                        {
                            File.AppendAllText(conversionLogFilePath, $"{ClassNamesToTPPCRes.ResourceManager.GetString(userLanguageKey + "_LogConvertCategory")}: {line}\n");

                            string category_name = line.TrimStart('#', '/').Trim();
                            categories.Add(new Dictionary<string, object> {
                                { "CategoryName", category_name },
                                { "Products", new List<string>() }
                            });

                            categoryFound = true;
                        }
                        else
                        {
                            // Produkt zur formatierten Liste der aktuellen Kategorie hinzufügen
                            string formatted_entry = $"{line},1,-1,1,150,5";
                            if (categories.Count > 0)
                            {
                                ((List<string>)categories[categories.Count - 1]["Products"]).Add(formatted_entry);
                                convertedClassNamesCount++; // Inkrementiere den Zähler für jede konvertierte ClassName
                            }
                        }
                    }

                    // Dummy-Kategorie erstellen, falls keine Kategorien gefunden wurden
                    if (!categoryFound)
                    {
                        File.AppendAllText(conversionLogFilePath, ClassNamesToTPPCRes.ResourceManager.GetString(userLanguageKey + "_LogNoCategory") + "\n");

                        categories.Add(new Dictionary<string, object> {
                            { "CategoryName", "DummyCategory" },
                            { "Products", new List<string>() }
                        });

                        foreach (string line in lines)
                        {
                            if (!string.IsNullOrWhiteSpace(line))
                            {
                                string formatted_entry = $"{line},1,-1,1,150,5";
                                ((List<string>)categories[categories.Count - 1]["Products"]).Add(formatted_entry);
                                convertedClassNamesCount++; // Inkrementiere den Zähler für jede konvertierte ClassName
                            }
                        }
                    }

                    // Schreiben der formatierten Einträge in die Ausgabedatei im JSON-Format
                    using (StreamWriter output_file = new StreamWriter(outputFilePath))
                    {
                        output_file.Write("{\n");
                        output_file.Write("  \"Version\": \"2.5\",\n");
                        output_file.Write("  \"EnableAutoCalculation\": 0,\n");
                        output_file.Write("  \"EnableAutoDestockAtRestart\": 0,\n");
                        output_file.Write("  \"EnableDefaultTraderStock\": 0,\n");
                        output_file.Write("  \"TraderCategories\": [\n");
                        for (int i = 0; i < categories.Count; i++)
                        {
                            output_file.Write("    {\n");
                            output_file.Write($"      \"CategoryName\": \"{categories[i]["CategoryName"]}\",\n");
                            output_file.Write("      \"Products\": [\n");
                            output_file.Write(string.Join(",\n", ((List<string>)categories[i]["Products"]).Select(product => $"\"{product}\"").Select(product => $"        {product}")));
                            output_file.Write("\n      ]\n    }");
                            if (i < categories.Count - 1)
                                output_file.Write(",");
                            output_file.Write("\n");
                        }
                        output_file.Write("  ]\n}\n");
                    }

                    File.AppendAllText(conversionLogFilePath, $"{ClassNamesToTPPCRes.ResourceManager.GetString(userLanguageKey + "_LogTotal")} {convertedClassNamesCount}\n");
                    File.AppendAllText(conversionLogFilePath, $"Output: \"{outputFilePath}\"\n");
                    File.AppendAllText(conversionLogFilePath, $"{DateTime.Now}: " + ClassNamesToTPPCRes.ResourceManager.GetString(userLanguageKey + "_LogConvertFinish") + "\n\n\n");

                    await FormMain.Instance.ShowNotification(TraderConverterRes.ResourceManager.GetString(userLanguageKey + "_LabelStatusFinished"), IconChar.Check, Color.Green);

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
                    popUpMessage.LabelMessageContent.Text = ClassNamesToTPPCRes.ResourceManager.GetString(userLanguageKey + "_LogConvertFatalError") + $" {ex.Message}>\n";
                    popUpMessage.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_TitleError");
                    popUpMessage.ButtonNo.Visible = false;
                    popUpMessage.ButtonYes.Visible = false;
                    if (popUpMessage.ShowDialog() == DialogResult.OK)
                    {
                        File.AppendAllText(ErrorLogFilePath, ClassNamesToTPPCRes.ResourceManager.GetString(userLanguageKey + "_LogConvertFatalError") + $" {ex.Message}>" + "\n");
                        FormMain.Instance.StopWorkingStatus();
                    }
                }
            }
        }
    }
}