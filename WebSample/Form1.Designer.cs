namespace WebView2Example
{
    partial class Form1
    {
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)webView).BeginInit();
            SuspendLayout();
            // 
            // webView
            // 
            webView.AllowExternalDrop = true;
            webView.BackgroundImageLayout = ImageLayout.Stretch;
            webView.CausesValidation = false;
            webView.CreationProperties = null;
            webView.DefaultBackgroundColor = Color.WhiteSmoke;
            webView.Dock = DockStyle.Fill;
            webView.Location = new Point(0, 0);
            webView.Margin = new Padding(3, 4, 3, 4);
            webView.MinimumSize = new Size(1280, 720);
            webView.Name = "webView";
            webView.Size = new Size(1902, 1033);
            webView.TabIndex = 0;
            webView.ZoomFactor = 1D;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(webView);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Simple_HTML_Viewer ver 1.0";
            TopMost = true;
            TransparencyKey = Color.Red;
            ((System.ComponentModel.ISupportInitialize)webView).EndInit();
            ResumeLayout(false);
        }
    }
}
