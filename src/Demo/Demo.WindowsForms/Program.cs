using System;
using System.Configuration;
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

            TiandituMapProviders.SetApiKey(ConfigurationManager.AppSettings["tianditu:apiKey"]);
            
            Application.Run(new MainForm());
        }
    }
}
