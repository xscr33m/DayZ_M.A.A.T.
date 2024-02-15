using DayZ_MAAT._Core._Engine;
using DayZ_MAAT._Core._Engine._Converter;
using DayZ_MAAT._Core._Engine._Extractor;
using DayZ_MAAT._Core._Engine._Validator;
using DayZ_MAAT._Core._Language._Stringtables;
using DayZ_MAAT.Properties;
using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayZ_MAAT._Core._Forms
{
    public partial class FormMain : Form
    {
        // --- Main Fields --- //
        readonly string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
        readonly static string LogFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs");
        readonly static string LogFilePath = Path.Combine(LogFolderPath, "ErrorLog.txt");
        public string userLanguageKey = Settings.Default.LanguageKey;
        public static FormMain Instance;
        private readonly Timer notificationTimer = new Timer();

        public FormMain()
        {
            InitializeComponent();
            Instance = this;
        }

        private async void FormMain_Load(object sender, EventArgs e)
        {
            ApplyLanguage();
            ApplySettings();

            await ShowNotification(Notifications.ResourceManager.GetString(userLanguageKey + "_Startup"), IconChar.Check, Color.LightGreen);
        }

        // --- Apply Settings --- //
        private void ApplySettings()
        {
            //PanelPreview.Visible = Settings.Default.ShowPreview
        }

        // --- Apply Language Variables --- //
        private void ApplyLanguage()
        {
            Label_Version.Text = "Version " + version;
            GroupBox_Validator.Text = MainForm.ResourceManager.GetString(userLanguageKey + "_GroupBox_Validator");
            GroupBox_Extractor.Text = MainForm.ResourceManager.GetString(userLanguageKey + "_GroupBox_Extractor");
            GroupBox_Converter.Text = MainForm.ResourceManager.GetString(userLanguageKey + "_GroupBox_Converter");
            Button_Validate.Text = MainForm.ResourceManager.GetString(userLanguageKey + "_Button_Validate");
            Button_VerifyTPPriceCfg.Text = MainForm.ResourceManager.GetString(userLanguageKey + "_Button_VerifyTPPriceCfg");
            Button_ExtractCpp.Text = MainForm.ResourceManager.GetString(userLanguageKey + "_Button_ExtractCpp");
            Button_ExtractFromTypes.Text = MainForm.ResourceManager.GetString(userLanguageKey + "_Button_ExtractFromTypes");
            Button_TraderConverter.Text = MainForm.ResourceManager.GetString(userLanguageKey + "_Button_TraderConverter");
            Button_ConvertClassToType.Text = MainForm.ResourceManager.GetString(userLanguageKey + "_Button_ConvertClassToType");
            Button_ConvertClassNameToTPPC.Text = MainForm.ResourceManager.GetString(userLanguageKey + "_Button_ConvertClassNameToTraderPlusPriceConfig");
            Button_ConvertTPVCToSpawnabletypes.Text = MainForm.ResourceManager.GetString(userLanguageKey + "_Button_ConvertTPVCToSpawnabletypes");
        }

        // --- Notifications --- //
        public async Task ShowNotification(string text, IconChar icon, Color iconColor) // Warnung ignorieren. Wenn nicht async, werden die Meldungen nicht nacheinander angezeigt! 
        {
            Icon_Notification.IconChar = icon;
            Icon_Notification.IconColor = iconColor;

            Panel_Notifications.Visible = true;
            Label_Notification.Visible = true;

            Label_Notification.Text = text;

            if (notificationTimer.Enabled != false)
            {
                await Task.Delay(notificationTimer.Interval);
                notificationTimer.Stop();
            }

            notificationTimer.Interval = 3000;
            notificationTimer.Tick += NotificationTimer_Tick;
            notificationTimer.Start();
        }

        private void NotificationTimer_Tick(object sender, EventArgs e)
        {
            Panel_Notifications.Visible = false;
            Label_Notification.Visible = false;

            notificationTimer.Stop();
        }

        // --- Working-Status --- //
        public void StartWorkingStatus()
        {
            Panel_Working.Visible = true;
            Label_Working.Text = MainForm.ResourceManager.GetString(userLanguageKey + "_Label_Working");
        }

        public void StopWorkingStatus()
        {
            Panel_Working.Visible = false;
        }

        private void PictureBox_Logo_DoubleClick(object sender, EventArgs e)
        {
            string url = "https://www.youtube.com/watch?v=dQw4w9WgXcQ&t=43s";
            WebsiteLauncher.OpenWebsite(url);
        }

        // --- Button Info --- //
        private void Button_Info_Click(object sender, EventArgs e)
        {
            FormInfo form = new FormInfo();
            form.ShowDialog();
        }

        // --- Button Settings --- //
        private async void Button_Settings_Click(object sender, EventArgs e)
        {
            FormSettings form = new FormSettings();
            if (form.ShowDialog() == DialogResult.OK)
            {
                Settings.Default.Reload();

                userLanguageKey = Settings.Default.LanguageKey;

                ApplyLanguage();
                await ShowNotification(Notifications.ResourceManager.GetString(userLanguageKey + "_SettingsSaved"), IconChar.Check, Color.LightGreen);
            }
        }

        // --- Button Validate --- //
        private void Button_Validate_Click(object sender, EventArgs e)
        {
            Instance.StartWorkingStatus();

            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "JSON (*.json)|*.json|XML (*.xml)|*.xml"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;

                try
                {
                    // Erstelle eine Instanz von ValiBeau mit dem Pfad der geladenen Datei
                    ValiBeau beautifier = new ValiBeau(selectedFilePath);
                    beautifier.BeautifyFile();
                }
                catch (Exception ex)
                {
                    CustomMessage PopupMessage = new CustomMessage();
                    SystemSounds.Exclamation.Play();
                    PopupMessage.ButtonOkay.Visible = true;
                    PopupMessage.IconPictureBox.IconChar = IconChar.Xmark;
                    PopupMessage.IconPictureBox.IconColor = Color.Red;
                    PopupMessage.LabelMessageContent.Text = MainForm.ResourceManager.GetString(userLanguageKey + "_ValidateError") + $"{ex.Message}";
                    PopupMessage.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_TitleError");
                    PopupMessage.ButtonNo.Visible = false;
                    PopupMessage.ButtonYes.Visible = false;
                    if (PopupMessage.ShowDialog() == DialogResult.OK)
                    {
                        if (!Directory.Exists(LogFolderPath))
                        {
                            Directory.CreateDirectory(LogFolderPath);
                        }

                        File.AppendAllText(LogFilePath, $"{DateTime.Now}: " + MainForm.ResourceManager.GetString(userLanguageKey + "_ValidateError") + $"{ex.Message}\n");
                    }
                }
            }

            Instance.StopWorkingStatus();
        }

        // --- Button Verify TPPriceCfg --- //
        private void Button_VerifyTPPriceCfg_Click(object sender, EventArgs e)
        {
            Instance.StartWorkingStatus();

            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "TraderPlusPriceConfig (*TraderPlusPriceConfig*.json)|*TraderPlusPriceConfig*.json"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;

                try
                {
                    // Erstelle eine Instanz von TPVerif mit dem Pfad der Konfigurationsdatei
                    TPVerif verifier = new TPVerif(selectedFilePath);
                    verifier.VerifyTPPC();
                }
                catch (Exception ex)
                {
                    CustomMessage PopupMessage = new CustomMessage();
                    SystemSounds.Exclamation.Play();
                    PopupMessage.ButtonOkay.Visible = true;
                    PopupMessage.IconPictureBox.IconChar = IconChar.Xmark;
                    PopupMessage.IconPictureBox.IconColor = Color.Red;
                    PopupMessage.LabelMessageContent.Text = MainForm.ResourceManager.GetString(userLanguageKey + "_TPValidError") + $"{ex.Message}";
                    PopupMessage.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_TitleError");
                    PopupMessage.ButtonNo.Visible = false;
                    PopupMessage.ButtonYes.Visible = false;
                    if (PopupMessage.ShowDialog() == DialogResult.OK)
                    {
                        if (!Directory.Exists(LogFolderPath))
                        {
                            Directory.CreateDirectory(LogFolderPath);
                        }

                        File.AppendAllText(LogFilePath, $"{DateTime.Now}: " + MainForm.ResourceManager.GetString(userLanguageKey + "_TPValidError") + $"{ex.Message}\n");
                    }
                }
            }

            Instance.StopWorkingStatus();
        }

        // --- Button Extract from Types --- //
        private async void Button_ExtractFromTypes_Click(object sender, EventArgs e)
        {
            Instance.StartWorkingStatus();

            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "types.xml (*types*.xml)|*types*.xml"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;

                try
                {
                    // Erstelle eine Instanz von ExtractFromTypes mit dem Pfad der types.xml
                    ExtractFromTypes typesExtractor = new ExtractFromTypes();
                    await typesExtractor.ExtractTypeNames(selectedFilePath);
                }
                catch (Exception ex)
                {
                    CustomMessage PopupMessage = new CustomMessage();
                    SystemSounds.Exclamation.Play();
                    PopupMessage.ButtonOkay.Visible = true;
                    PopupMessage.IconPictureBox.IconChar = IconChar.Xmark;
                    PopupMessage.IconPictureBox.IconColor = Color.Red;
                    PopupMessage.LabelMessageContent.Text = MainForm.ResourceManager.GetString(userLanguageKey + "_ExtractClassTypesError") + $"{ex.Message}";
                    PopupMessage.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_TitleError");
                    PopupMessage.ButtonNo.Visible = false;
                    PopupMessage.ButtonYes.Visible = false;
                    if (PopupMessage.ShowDialog() == DialogResult.OK)
                    {
                        if (!Directory.Exists(LogFolderPath))
                        {
                            Directory.CreateDirectory(LogFolderPath);
                        }

                        File.AppendAllText(LogFilePath, $"{DateTime.Now}: " + MainForm.ResourceManager.GetString(userLanguageKey + "_ExtractClassTypesError") + $"{ex.Message}\n");
                    }
                }
            }

            Instance.StopWorkingStatus();
        }

        // --- Button TraderConverter --- //
        private void Button_TraderConverter_Click(object sender, EventArgs e)
        {
            Instance.StartWorkingStatus();

            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "TraderConfig.txt (*TraderConfig*.txt)|*TraderConfig*.txt"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;

                try
                {
                    // Erstelle eine Instanz von TraderConverter mit dem Pfad der trader.txt
                    TraderConverter traderConverter = new TraderConverter();
                    traderConverter.ConvertTraderToTPPC(selectedFilePath);
                }
                catch (Exception ex)
                {
                    CustomMessage PopupMessage = new CustomMessage();
                    SystemSounds.Exclamation.Play();
                    PopupMessage.ButtonOkay.Visible = true;
                    PopupMessage.IconPictureBox.IconChar = IconChar.Xmark;
                    PopupMessage.IconPictureBox.IconColor = Color.Red;
                    PopupMessage.LabelMessageContent.Text = MainForm.ResourceManager.GetString(userLanguageKey + "_TraderConvertError") + $"{ex.Message}";
                    PopupMessage.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_TitleError");
                    PopupMessage.ButtonNo.Visible = false;
                    PopupMessage.ButtonYes.Visible = false;
                    if (PopupMessage.ShowDialog() == DialogResult.OK)
                    {
                        if (!Directory.Exists(LogFolderPath))
                        {
                            Directory.CreateDirectory(LogFolderPath);
                        }

                        File.AppendAllText(LogFilePath, $"{DateTime.Now}: " + MainForm.ResourceManager.GetString(userLanguageKey + "_TraderConvertError") + $"{ex.Message}\n");
                    }
                }
            }

            Instance.StopWorkingStatus();
        }

        // --- Button ClassNames to TraderPlusPriceConfig --- //
        private void Button_ConvertClassNameToTPPC_Click(object sender, EventArgs e)
        {
            Instance.StartWorkingStatus();

            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "ClassNames.txt (*ClassNames*.txt)|*ClassNames*.txt"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;

                try
                {
                    // Erstelle eine Instanz von ClassNamesToTPPC mit dem Pfad der ClassNames.txt
                    ClassNamesToTPPC classNameConverter = new ClassNamesToTPPC();
                    classNameConverter.ConvertClassNameToTPPC(selectedFilePath);
                }
                catch (Exception ex)
                {
                    CustomMessage PopupMessage = new CustomMessage();
                    SystemSounds.Exclamation.Play();
                    PopupMessage.ButtonOkay.Visible = true;
                    PopupMessage.IconPictureBox.IconChar = IconChar.Xmark;
                    PopupMessage.IconPictureBox.IconColor = Color.Red;
                    PopupMessage.LabelMessageContent.Text = MainForm.ResourceManager.GetString(userLanguageKey + "_TraderConvertError") + $"{ex.Message}";
                    PopupMessage.Text = MessageForm.ResourceManager.GetString(userLanguageKey + "_TitleError");
                    PopupMessage.ButtonNo.Visible = false;
                    PopupMessage.ButtonYes.Visible = false;
                    if (PopupMessage.ShowDialog() == DialogResult.OK)
                    {
                        if (!Directory.Exists(LogFolderPath))
                        {
                            Directory.CreateDirectory(LogFolderPath);
                        }

                        File.AppendAllText(LogFilePath, $"{DateTime.Now}: " + MainForm.ResourceManager.GetString(userLanguageKey + "_TraderConvertError") + $"{ex.Message}\n");
                    }
                }
            }

            Instance.StopWorkingStatus();
        }

        // --- Black TitleBar --- //
        [DllImport("DwmApi")] //System.Runtime.InteropServices
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);

        protected override void OnHandleCreated(EventArgs e)
        {
            if (DwmSetWindowAttribute(Handle, 19, new[] { 1 }, 4) != 0)
                DwmSetWindowAttribute(Handle, 20, new[] { 1 }, 4);
        }
    }
}
