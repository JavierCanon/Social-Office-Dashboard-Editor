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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using SO.DashboardEditor.Desktop.Views.Forms.Browsers;
using SO.DashboardEditor.Desktop.Models;

namespace SO.DashboardEditor.Desktop.Views
{
    public partial class RibbonFormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public RibbonFormMain()
        {
            InitializeComponent();

            var form = new FormBrowser();
            form.MdiParent = this;
            form.LoadUrl(AppConfiguration.GetWebserverMainURL());
            form.Show();
        }

        private void barButtonItemDashboardViewer_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new RibbonFormDashboardViewer();
            form.Show(this);
        }

        private void barButtonItemDashboardEditor_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new RibbonFormDashboardDesigner();
            form.Show(this);
        }

        private void RibbonFormMain_Shown(object sender, EventArgs e)
        {

        }
    }
}