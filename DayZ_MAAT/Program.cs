using DayZ_MAAT._Core._Forms;
using System;
using System.Windows.Forms;

namespace DayZ_MAAT
{
    internal static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormSplash());
            Application.Run(new FormMain());
        }
    }
}
