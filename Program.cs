using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace ChromeShim
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string url = Environment.GetCommandLineArgs().ElementAtOrDefault(1);

            if (!String.IsNullOrEmpty(url))
            {
                url = @"""" + url + @"""";
                string chromePath = Path.Combine(Environment.GetEnvironmentVariable("LOCALAPPDATA"), @"Google\Chrome\Application\chrome.exe");
                Process.Start(chromePath, url);
            }
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());


        }
    }
}
