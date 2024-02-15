using DayZ_MAAT._Core._Forms;
using FontAwesome.Sharp;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;
using System;
using System.Linq;
using System.IO;
using System.Drawing;
using DayZ_MAAT._Core._Language._Stringtables;
using DayZ_MAAT.Properties;

namespace DayZ_MAAT._Core._Engine._Extractor
{
    internal class ExtractFromTypes
    {
        public string userLanguageKey = Settings.Default.LanguageKey;
        readonly static string LogFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs");
        readonly static string OutputFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Output");
        readonly static string ErrorLogFilePath = Path.Combine(LogFolderPath, "ErrorLog.txt");

        public async Task ExtractTypeNames(string filePath)
        {
            try
            {
                XDocument doc = XDocument.Load(filePath);

                // Extrahiere die Type-Namen
                var typeNames = doc.Descendants("type")
                                   .Select(type => type.Attribute("name").Value)
                                   .ToList();

                // Speichere die Type-Namen in eine Datei
                string outputFilePath = Path.Combine(OutputFolderPath, "ClassNames.txt");

                if (File.Exists(outputFilePath))
                {
                    CustomMessage messageBox = new CustomMessage();
                    SystemSounds.Exclamation.Play();
                    messageBox.ButtonOkay.Visible = false;
                    messageBox.IconPictureBox.IconChar = IconChar.Warning;
                    messageBox.IconPictureBox.ForeColor = Color.Yellow;
                    messageBox.LabelMessageContent.Text = ExtractFromTypesRes.ResourceManager.GetString(userLanguageKey + "_ExistingFile");
                    messageBox.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_TitleQuestion");
                    messageBox.ButtonNo.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_ButtonNo");
                    messageBox.ButtonYes.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_ButtonYes");
                    messageBox.ButtonNo.Visible = true;
                    messageBox.ButtonYes.Visible = true;

                    if (messageBox.ShowDialog() == DialogResult.No)
                    {
                        await FormMain.Instance.ShowNotification(ExtractFromTypesRes.ResourceManager.GetString(userLanguageKey + "_Canceled"), IconChar.Warning, Color.Yellow);
                        return;
                    }
                }

                if (!Directory.Exists(OutputFolderPath))
                {
                    Directory.CreateDirectory(OutputFolderPath);
                }

                File.WriteAllText(outputFilePath, ExtractFromTypesRes.ResourceManager.GetString(userLanguageKey + "_CategoryHint") + "\n");

                File.AppendAllLines(outputFilePath, typeNames);

                await Task.Delay(1000);
                FormMain.Instance.StopWorkingStatus();

                // Zeige die Summe der exportierten Type-Namen an
                await FormMain.Instance.ShowNotification($"{typeNames.Count}" + ExtractFromTypesRes.ResourceManager.GetString(userLanguageKey + "_ClassNamePath") + $"\n{outputFilePath}", IconChar.Check, Color.Green);
            }
            catch (XmlException ex)
            {
                CustomMessage messageBox = new CustomMessage();
                SystemSounds.Exclamation.Play();
                messageBox.ButtonOkay.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_ButtonOk");
                messageBox.ButtonOkay.Visible = true;
                messageBox.IconPictureBox.IconChar = IconChar.Xmark;
                messageBox.IconPictureBox.ForeColor = Color.Red;
                messageBox.LabelMessageContent.Text = ExtractFromTypesRes.ResourceManager.GetString(userLanguageKey + "_ParserError") + $"\n\n{ex.Message}";
                messageBox.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_TitleError");
                messageBox.ButtonNo.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_ButtonNo");
                messageBox.ButtonYes.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_ButtonYes");
                messageBox.ButtonNo.Visible = false;
                messageBox.ButtonYes.Visible = false;

                if (messageBox.ShowDialog() == DialogResult.OK)
                {
                    if (!Directory.Exists(LogFolderPath))
                    {
                        Directory.CreateDirectory(LogFolderPath);
                    }

                    File.AppendAllText(ErrorLogFilePath, $"{DateTime.Now}: " + ExtractFromTypesRes.ResourceManager.GetString(userLanguageKey + "_ParserError") + $"{ex.Message}\n");
                    await FormMain.Instance.ShowNotification(ExtractFromTypesRes.ResourceManager.GetString(userLanguageKey + "_ParserError1"), IconChar.Xmark, Color.Red);
                    FormMain.Instance.StopWorkingStatus();
                }
            }
        }
    }
}
