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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SO.DashboardEditor.Desktop.Views.Forms;
using SO.DashboardEditor.Desktop.Views.Forms.Browsers;

namespace SO.DashboardEditor.Desktop.Presenters
{
    internal static class BrowserPresenter
    {
        internal static void Ini(FormBrowser form)
        {

#if DEBUG
            form.webBrowser.AllowNavigation = true;
            form.webBrowser.AllowWebBrowserDrop = true;
            form.webBrowser.IsWebBrowserContextMenuEnabled = true;
            form.webBrowser.ScriptErrorsSuppressed = false;
            form.webBrowser.ScrollBarsEnabled = true;
            form.webBrowser.WebBrowserShortcutsEnabled = true;
            //form.LoadUrl(Program.Configuration.Webserver.Webserver_Development);
#else
            form.webBrowser.AllowNavigation = true;
            form.webBrowser.AllowWebBrowserDrop = true;
            form.webBrowser.IsWebBrowserContextMenuEnabled = false;
            form.webBrowser.ScriptErrorsSuppressed = true;
            form.webBrowser.ScrollBarsEnabled = true;
            form.webBrowser.WebBrowserShortcutsEnabled = true;
            //form.LoadUrl(Program.Configuration.Webserver.Webserver_Production);
#endif
        }




    }
}
