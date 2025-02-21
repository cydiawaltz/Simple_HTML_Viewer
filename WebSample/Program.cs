using System;
using System.Linq;
using System.Security.Policy;
using System.Windows.Forms;
using WebView2Example;

namespace WebView2Example
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            /*if (!System.Diagnostics.Debugger.IsAttached)
            {
                System.Diagnostics.Debugger.Launch();
            }*/
            Application.EnableVisualStyles();
            Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);
            Application.SetCompatibleTextRenderingDefault(false);
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.FileName = "HMCC2025.html";
            dialog.Filter = "HTML(html/htm)|*.html;*.htm|すべてのファイル(*.*)|*.*";
            dialog.FilterIndex = 1;
            dialog.RestoreDirectory = true;
            string url;
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                url = dialog.FileName;
            }
            else
            {
                url = "http://abehiroshi.la.coocan.jp";
            }
            //string url = args.FirstOrDefault() ?? "https://www.example.com"; // デフォルトURLを指定
            Application.Run(new Form1(url));
        }
    }
}
