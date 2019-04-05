// Copyright (c) 2019 Javier Cañon 
// https://www.javiercanon.com 
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to
// deal in the Software without restriction, including without limitation the
// rights to use, copy, modify, merge, publish, distribute, sublicense, and/or
// sell copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS
// IN THE SOFTWARE.
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using SO.DashboardEditor.Desktop.Presenters;


/*
long stasks:
https://tech.labs.oliverwyman.com/blog/2015/02/24/asynchronous-interaction-between-a-webbrowser-control-and-the-hosted-web-page/

*/
namespace SO.DashboardEditor.Desktop.Views.Forms.Browsers
{
    [ComVisible(true)]
    public partial class FormBrowser : DevExpress.XtraEditors.XtraForm
    {
        // 
        internal FormBrowser()
        {
            //this.DoubleBuffered = true;
            InitializeComponent();

            // can callback from js <a href="whatever" onclick="window.external.JSTest('called from script code')">CLICK ME</a>
            // class need to be public
            webBrowser.ObjectForScripting = this; 

            BrowserPresenter.Ini(this);
        }

        public void JSTest(string msg) {

            MessageBox.Show(msg);

        }

        #region TabBrowsing

        public void OpenNewBrowserTab(string url)
        {
            if (this.IsMdiChild) {
                var form = this.MdiParent as DevExpress.XtraBars.Ribbon.RibbonForm;

            }
        }

        #endregion TabBrowsing




        #region browser events
        protected void WebBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            SetIsLoading(false);


        }

        protected void WebBrowser_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {

            SetIsLoading(true);

        }


        protected virtual void WebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //urlTextBox.Text = webBrowser.Url.ToString();
            //toolStripStatusLabel1.Text = webBrowser.Document.Title;


        }
        
        private void WebBrowser_FileDownload(object sender, EventArgs e)
        {

        }

        private void WebBrowser_LocationChanged(object sender, EventArgs e)
        {

        }

        private void WebBrowser_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {

        }

        private void WebBrowser_NewWindow(object sender, CancelEventArgs e)
        {

            // https://stackoverflow.com/questions/15239946/popup-window-webbrowser-control

        }



        #endregion browser events


        protected void SetCanGoBack(bool canGoBack)
        {
            //backButton.Enabled = canGoBack;
        }

        protected void SetCanGoForward(bool canGoForward)
        {
            //forwardButton.Enabled = canGoForward;
        }

        protected void SetIsLoading(bool isLoading)
        {
            /*
            if (isLoading)
            {
                toolStripProgressBar1.Style = ProgressBarStyle.Marquee;
                toolStripProgressBar1.MarqueeAnimationSpeed = 30;
            }
            else
            {
                toolStripProgressBar1.Style = ProgressBarStyle.Continuous;
                toolStripProgressBar1.MarqueeAnimationSpeed = 0;

            }

            goButton.Text = isLoading ?
                "Stop" :
                "IR";
            goButton.Image = isLoading ?
                Properties.Resources.nav_plain_red :
                Properties.Resources.nav_plain_green;

            HandleToolStripLayout();
            */
        }


        protected void HandleToolStripLayout(object sender, LayoutEventArgs e)
        {
            //HandleToolStripLayout();
        }

        protected void HandleToolStripLayout()
        {
            /*
            var width = toolStrip1.Width;
            foreach (ToolStripItem item in toolStrip1.Items)
            {
                if (item != urlTextBox)
                {
                    width -= item.Width - item.Margin.Horizontal;
                }
            }
            urlTextBox.Width = Math.Max(0, width - urlTextBox.Margin.Horizontal - 18);
            */
        }


        protected void GoButtonClick(object sender, EventArgs e)
        {
            //LoadUrl(urlTextBox.Text);
        }

        protected void BackButtonClick(object sender, EventArgs e)
        {

            if (webBrowser.CanGoBack)
                webBrowser.GoBack();

        }

        protected void ForwardButtonClick(object sender, EventArgs e)
        {
            if (webBrowser.CanGoForward)
                webBrowser.GoForward();

        }

        protected void UrlTextBoxKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }

            //LoadUrl(urlTextBox.Text);
        }

        public void LoadUrl(string url)
        {
            if (Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute))
            {
                webBrowser.Navigate(url);

            }
        }

    }
}
