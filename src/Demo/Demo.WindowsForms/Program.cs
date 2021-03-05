using System;
using System.Windows.Forms;

namespace GMap.NET.MapProviders.Tianditu.Demo.WindowsForms
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            TiandituMapProviders.SetApiKey("API_KEY_GOES_HERE");

            Application.Run(new MainForm());
        }
    }
}
