using System.Runtime.InteropServices;
using System;
using System.Windows.Forms;
using DayZ_MAAT._Core._Language._Stringtables;
using FontAwesome.Sharp;
using System.Threading.Tasks;
using DayZ_MAAT.Properties;
using System.Drawing;

namespace DayZ_MAAT._Core._Forms
{
    public partial class EULADialog : Form
    {
        public string userLanguageKey = Settings.Default.LanguageKey;
        public EULADialog()
        {
            InitializeComponent();
        }

        private void EULADialog_Load(object sender, EventArgs e)
        {
            ApplyLanguage();
        }

        // --- Apply Language Variables --- //
        private void ApplyLanguage()
        {
            LabelTitle.Text = EULAForm.ResourceManager.GetString(userLanguageKey + "_Title");
            TextBoxContent.Text = EULAForm.ResourceManager.GetString(userLanguageKey + "_EULAText");
        }

        private async void Button_CopyToClipboard_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxContent.Text))
            {
                Clipboard.SetText(TextBoxContent.Text);

                Button_CopyToClipboard.IconChar = IconChar.Check;
                Button_CopyToClipboard.IconColor = Color.Green;
                Label_Copied.Visible = true;
                Label_Copied.Text = EULAForm.ResourceManager.GetString(userLanguageKey + "_CopiedSuccess");

                // Warte 5 Sekunden
                await Task.Delay(5000);

                // Setze das Icon und die Farbe zurück
                Button_CopyToClipboard.IconChar = IconChar.Clipboard;
                Button_CopyToClipboard.IconColor = Color.White;
                Label_Copied.Visible = false;
                Label_Copied.Text = string.Empty;
            }
            else
            {
                Button_CopyToClipboard.IconChar = IconChar.Xmark;
                Button_CopyToClipboard.IconColor = Color.Red;
                Label_Copied.Visible = true;
                Label_Copied.Text = EULAForm.ResourceManager.GetString(userLanguageKey + "_CopiedFail");
            }
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
