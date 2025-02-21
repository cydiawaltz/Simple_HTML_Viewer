using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace WebView2Example
{
    public partial class Form1 : Form
    {
        bool isNeedQuit;
        public Form1(string url)
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.WindowState = FormWindowState.Maximized; // ウィンドウを最大化
            InitializeWebView(url);
        }

        private async void InitializeWebView(string url)
        {
            await webView.EnsureCoreWebView2Async(null);
            webView.CoreWebView2.Navigate(url);
        }
    }
}
