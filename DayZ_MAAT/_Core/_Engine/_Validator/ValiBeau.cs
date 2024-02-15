using DayZ_MAAT._Core._Forms;
using DayZ_MAAT._Core._Language._Stringtables;
using DayZ_MAAT.Properties;
using FontAwesome.Sharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Threading.Tasks;
using System.Xml;

namespace DayZ_MAAT._Core._Engine
{
    public class ValiBeau
    {
        public string userLanguageKey = Settings.Default.LanguageKey;
        readonly static string LogFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs");
        readonly static string ErrorLogFilePath = Path.Combine(LogFolderPath, "ErrorLog.txt");
        private bool IsInvalid = false;

        public string FilePath { get; private set; }
        public string FileContent { get; private set; }

        public ValiBeau(string filePath)
        {
            FilePath = filePath;
            FileContent = ReadFile(filePath);
        }

        private string ReadFile(string filePath)
        {
            try
            {
                string fileExtension = Path.GetExtension(filePath);
                string fileContent = "";

                switch (fileExtension)
                {
                    case ".xml":
                        if (ValidateXmlFile(filePath))
                            fileContent = File.ReadAllText(filePath);
                        else
                            throw new Exception(ValiBeauRes.ResourceManager.GetString(userLanguageKey + "_ExeptionXML"));
                            //File.AppendAllText(LogFilePath, $"{DateTime.Now}: " + ValiBeauRes.ResourceManager.GetString(userLanguageKey + "_ExeptionXML") + "\n");
                        break;
                    case ".json":
                        if (ValidateJsonFile(filePath))
                            fileContent = File.ReadAllText(filePath);
                        else
                            throw new Exception(ValiBeauRes.ResourceManager.GetString(userLanguageKey + "_ExeptionJSON"));
                            //File.AppendAllText(LogFilePath, $"{DateTime.Now}: " + ValiBeauRes.ResourceManager.GetString(userLanguageKey + "_ExeptionJSON") + "\n");
                        break;
                    case ".c":
                    case ".cpp":
                        fileContent = File.ReadAllText(filePath);
                        break;
                    default:
                        if (!Directory.Exists(LogFolderPath))
                        {
                            Directory.CreateDirectory(LogFolderPath);
                        }
                        File.AppendAllText(ErrorLogFilePath, $"{DateTime.Now}: " + ValiBeauRes.ResourceManager.GetString(userLanguageKey + "_ExeptionNoSup") + "\n");
                        throw new NotSupportedException(ValiBeauRes.ResourceManager.GetString(userLanguageKey + "_ExeptionNoSup"));
                }

                Task.Delay(1000);
                FormMain.Instance.StopWorkingStatus();

                return fileContent;
            }
            catch (Exception ex)
            {
                if (!Directory.Exists(LogFolderPath))
                {
                    Directory.CreateDirectory(LogFolderPath);
                }

                File.AppendAllText(ErrorLogFilePath, $"{DateTime.Now}: " + ValiBeauRes.ResourceManager.GetString(userLanguageKey + "_ReadError") + $"{ex.Message}\n");
                FormMain.Instance.StopWorkingStatus();
                return null;
            }
        }

        private bool ValidateXmlFile(string filePath)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(filePath);
                return true;
            }
            catch (XmlException ex)
            {
                IsInvalid = true;

                CustomMessage popUpMessage = new CustomMessage();
                SystemSounds.Exclamation.Play();
                popUpMessage.ButtonOkay.Visible = true;
                popUpMessage.ButtonOkay.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_ButtonOk");
                popUpMessage.IconPictureBox.IconChar = IconChar.Xmark;
                popUpMessage.IconPictureBox.IconColor = Color.Red;
                popUpMessage.LabelMessageContent.Text = ValiBeauRes.ResourceManager.GetString(userLanguageKey + "_ValidXmlError") + $"{ex.Message}";
                popUpMessage.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_TitleError");
                popUpMessage.ButtonNo.Visible = false;
                popUpMessage.ButtonYes.Visible = false;
                if (popUpMessage.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (!Directory.Exists(LogFolderPath))
                    {
                        Directory.CreateDirectory(LogFolderPath);
                    }

                    File.AppendAllText(ErrorLogFilePath, $"{DateTime.Now}: " + ValiBeauRes.ResourceManager.GetString(userLanguageKey + "_ValidXmlError") + $"{ex.Message}\n");
                }

                return false;
            }
        }

        private bool ValidateJsonFile(string filePath)
        {
            try
            {
                string jsonContent = File.ReadAllText(filePath);
                JsonSerializer serializer = new JsonSerializer();
                using (JsonTextReader reader = new JsonTextReader(new StringReader(jsonContent)))
                {
                    while (reader.Read())
                    {
                        // Prüfe auf Fehler beim Lesen
                        //if (reader.TokenType == JsonToken.Comment)
                        //    continue; // Kommentare werden ignoriert
                        //if (reader.TokenType == JsonToken.None)
                        //    continue; // Token 'None' wird ignoriert
                        if (reader.TokenType == JsonToken.Undefined)
                            return false; // 'Undefined' zeigt auf ungültigen JSON-Inhalt
                    }
                }

                return true;
            }
            catch (JsonException ex)
            {
                IsInvalid = true;

                CustomMessage popUpMessage = new CustomMessage();
                SystemSounds.Exclamation.Play();
                popUpMessage.ButtonOkay.Visible = true;
                popUpMessage.ButtonOkay.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_ButtonOk");
                popUpMessage.IconPictureBox.IconChar = IconChar.Xmark;
                popUpMessage.IconPictureBox.IconColor = Color.Red;
                popUpMessage.LabelMessageContent.Text = ValiBeauRes.ResourceManager.GetString(userLanguageKey + "_ValidJsonError") + $"{ex.Message}";
                popUpMessage.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_TitleError");
                popUpMessage.ButtonNo.Visible = false;
                popUpMessage.ButtonYes.Visible = false;
                if (popUpMessage.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (!Directory.Exists(LogFolderPath))
                    {
                        Directory.CreateDirectory(LogFolderPath);
                    }

                    File.AppendAllText(ErrorLogFilePath, $"{DateTime.Now}: " + ValiBeauRes.ResourceManager.GetString(userLanguageKey + "_ValidJsonError") + $"{ex.Message}\n");
                }

                return false;
            }
        }

        public async void BeautifyFile()
        {
            switch (Path.GetExtension(FilePath))
            {
                case ".xml":
                    BeautifyXml(FilePath);
                    break;
                case ".json":
                    BeautifyJson(FilePath);
                    break;
                default:
                    await FormMain.Instance.ShowNotification(ValiBeauRes.ResourceManager.GetString(userLanguageKey + "_ReadError"), IconChar.Xmark, Color.Red);
                    if (!Directory.Exists(LogFolderPath))
                    {
                        Directory.CreateDirectory(LogFolderPath);
                    }
                    File.AppendAllText(ErrorLogFilePath, $"{DateTime.Now}: " + ValiBeauRes.ResourceManager.GetString(userLanguageKey + "_ReadError") + "\n");
                    throw new NotSupportedException(ValiBeauRes.ResourceManager.GetString(userLanguageKey + "_ReadError"));
            }
            if (!IsInvalid)
            {
                await FormMain.Instance.ShowNotification(ValiBeauRes.ResourceManager.GetString(userLanguageKey + "_Success"), IconChar.Check, Color.LightGreen);
            }
            else
            {
                await FormMain.Instance.ShowNotification(ValiBeauRes.ResourceManager.GetString(userLanguageKey + "_Invalid"), IconChar.Xmark, Color.Red);
            }
        }

        private void BeautifyXml(string filePath)
        {
            if (!IsInvalid)
            {
                try
                {
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load(filePath);
                    xmlDoc.Save(filePath);
                }
                catch (XmlException ex)
                {
                    CustomMessage popUpMessage = new CustomMessage();
                    SystemSounds.Exclamation.Play();
                    popUpMessage.ButtonOkay.Visible = true;
                    popUpMessage.ButtonOkay.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_ButtonOk");
                    popUpMessage.IconPictureBox.IconChar = IconChar.Xmark;
                    popUpMessage.IconPictureBox.IconColor = Color.Red;
                    popUpMessage.LabelMessageContent.Text = ValiBeauRes.ResourceManager.GetString(userLanguageKey + "_BeautifyError") + $"{ex.Message}";
                    popUpMessage.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_TitleError");
                    popUpMessage.ButtonNo.Visible = false;
                    popUpMessage.ButtonYes.Visible = false;
                    if (popUpMessage.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        if (!Directory.Exists(LogFolderPath))
                        {
                            Directory.CreateDirectory(LogFolderPath);
                        }

                        File.AppendAllText(ErrorLogFilePath, $"{DateTime.Now}: " + ValiBeauRes.ResourceManager.GetString(userLanguageKey + "_BeautifyError") + $"{ex.Message}\n");
                    }
                }
            }
        }

        private void BeautifyJson(string filePath)
        {
            if (!IsInvalid)
            {
                try
                {
                    string jsonContent = File.ReadAllText(filePath);
                    JObject parsedJson = JObject.Parse(jsonContent);
                    string formattedJson = parsedJson.ToString(Newtonsoft.Json.Formatting.Indented);
                    File.WriteAllText(filePath, formattedJson);
                }
                catch (JsonException ex)
                {
                    CustomMessage popUpMessage = new CustomMessage();
                    SystemSounds.Exclamation.Play();
                    popUpMessage.ButtonOkay.Visible = true;
                    popUpMessage.ButtonOkay.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_ButtonOk");
                    popUpMessage.IconPictureBox.IconChar = IconChar.Xmark;
                    popUpMessage.IconPictureBox.IconColor = Color.Red;
                    popUpMessage.LabelMessageContent.Text = ValiBeauRes.ResourceManager.GetString(userLanguageKey + "_BeautifyError1") + $"{ex.Message}";
                    popUpMessage.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_TitleError");
                    popUpMessage.ButtonNo.Visible = false;
                    popUpMessage.ButtonYes.Visible = false;
                    if (popUpMessage.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        if (!Directory.Exists(LogFolderPath))
                        {
                            Directory.CreateDirectory(LogFolderPath);
                        }

                        File.AppendAllText(ErrorLogFilePath, $"{DateTime.Now}: " + ValiBeauRes.ResourceManager.GetString(userLanguageKey + "_BeautifyError1") + $"{ex.Message}\n");
                    }
                }
            }
        }
    }
}
