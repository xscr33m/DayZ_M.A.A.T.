using DayZ_MAAT._Core._Engine;
using DayZ_MAAT._Core._Language._Stringtables;
using DayZ_MAAT.Properties;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DayZ_MAAT._Core._Forms
{
    public partial class FormSettings : Form
    {
        private readonly string[] languages = { "Deutsch", "English", "Francais" };
        private readonly string[] languageCodes = { "de", "en", "fr" };
        public string userLanguageKey = Settings.Default.LanguageKey;

        public FormSettings()
        {
            InitializeComponent();
        }

        private void FormSettings_Load(object sender, System.EventArgs e)
        {
            ApplyLanguage();
            ApplySettings();
            Button_Apply.Enabled = false;
        }

        // --- Apply Language Variables --- //
        private void ApplyLanguage()
        {
            Text = SettingsForm.ResourceManager.GetString(userLanguageKey + "_SettingsTitle");
            GroupBoxLanguage.Text = SettingsForm.ResourceManager.GetString(userLanguageKey + "_GroupBoxLanguage");
            GroupBoxEULA.Text = SettingsForm.ResourceManager.GetString(userLanguageKey + "_GroupBoxEULA");
            GroupBox_Update.Text = SettingsForm.ResourceManager.GetString(userLanguageKey + "_GroupBoxUpdate");
        }

        // --- Apply Settings --- //
        private void ApplySettings()
        {
            // Fülle die ComboBox mit den verfügbaren Sprachen
            ComboBox_Language.Items.AddRange(languages);
            // Finde den Index des aktuell in den Properties gespeicherten Sprachkürzels
            int selectedLanguageIndex = Array.IndexOf(languageCodes, Settings.Default.LanguageKey);
            // Setze die ComboBox auf die gespeicherte Sprache
            ComboBox_Language.SelectedIndex = selectedLanguageIndex;
        }

        // --- Sprache einstellen --- //
        private void ComboBox_Language_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Speichere die ausgewählte Sprache in den Einstellungen
            int selectedLanguageIndex = ComboBox_Language.SelectedIndex;
            if (selectedLanguageIndex >= 0 && selectedLanguageIndex < languageCodes.Length)
            {
                string selectedLanguage = languageCodes[selectedLanguageIndex];
                Settings.Default.LanguageKey = selectedLanguage;
            }

            Button_Apply.Enabled = true;
        }

        private void Button_Apply_Click(object sender, EventArgs e)
        {
            Settings.Default.Save();
            Close();
        }

        private void Button_EULA_Click(object sender, EventArgs e)
        {
            EULADialog messageBoxForm = new EULADialog();
            messageBoxForm.LabelTitle.Text = EULAForm.ResourceManager.GetString(userLanguageKey + "_ReviewTitle");
            messageBoxForm.TextBoxContent.Text = EULAForm.ResourceManager.GetString(userLanguageKey + "_EULAText");
            messageBoxForm.ButtonDeny.Visible = false;
            messageBoxForm.ButtonAccept.Visible = true;
            DialogResult result = messageBoxForm.ShowDialog();
            if (result == DialogResult.Yes)
            {
                messageBoxForm.Close();
            }
        }

        private async void Button_Update_Click(object sender, EventArgs e)
        {
            await UpdateCheck.ForceCheckForUpdates();
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
