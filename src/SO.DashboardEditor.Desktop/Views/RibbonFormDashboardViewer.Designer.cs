namespace SO.DashboardEditor.Desktop.Views
{
    partial class RibbonFormDashboardViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RibbonFormDashboardViewer));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItemOpen1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemOpen2 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageIni = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.dashboardViewer = new DevExpress.DashboardWin.DashboardViewer(this.components);
            this.xtraOpenFileDialog = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barButtonItemOpen1,
            this.barButtonItemOpen2});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 3;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageIni});
            this.ribbon.QuickToolbarItemLinks.Add(this.barButtonItemOpen1);
            this.ribbon.Size = new System.Drawing.Size(1152, 180);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barButtonItemOpen1
            // 
            this.barButtonItemOpen1.Caption = "Abrir";
            this.barButtonItemOpen1.Hint = "Abrir Dashboard";
            this.barButtonItemOpen1.Id = 1;
            this.barButtonItemOpen1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemOpen1.ImageOptions.Image")));
            this.barButtonItemOpen1.Name = "barButtonItemOpen1";
            this.barButtonItemOpen1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemOpen1_ItemClick);
            // 
            // barButtonItemOpen2
            // 
            this.barButtonItemOpen2.Caption = "Abrir";
            this.barButtonItemOpen2.Hint = "Abrir dashboard desde archivo";
            this.barButtonItemOpen2.Id = 2;
            this.barButtonItemOpen2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemOpen2.ImageOptions.Image")));
            this.barButtonItemOpen2.Name = "barButtonItemOpen2";
            this.barButtonItemOpen2.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barButtonItemOpen2.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.True;
            this.barButtonItemOpen2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemOpen2_ItemClick);
            // 
            // ribbonPageIni
            // 
            this.ribbonPageIni.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPageIni.Name = "ribbonPageIni";
            this.ribbonPageIni.Text = "Inicio";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemOpen2);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Estandar";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 681);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1152, 41);
            // 
            // dashboardViewer
            // 
            this.dashboardViewer.AllowPrintDashboardItems = true;
            this.dashboardViewer.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.dashboardViewer.Appearance.Options.UseBackColor = true;
            this.dashboardViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardViewer.Location = new System.Drawing.Point(0, 180);
            this.dashboardViewer.Name = "dashboardViewer";
            this.dashboardViewer.Size = new System.Drawing.Size(1152, 501);
            this.dashboardViewer.TabIndex = 2;
            // 
            // xtraOpenFileDialog
            // 
            this.xtraOpenFileDialog.Title = "Abrir archivo Dashboard";
            // 
            // RibbonFormDashboardViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 722);
            this.Controls.Add(this.dashboardViewer);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RibbonFormDashboardViewer";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "SO Dashboard Viewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.DashboardWin.DashboardViewer dashboardViewer;
        private DevExpress.XtraBars.BarButtonItem barButtonItemOpen1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemOpen2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageIni;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraEditors.XtraOpenFileDialog xtraOpenFileDialog;
    }
}