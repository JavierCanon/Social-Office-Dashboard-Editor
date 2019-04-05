namespace SO.DashboardEditor.Desktop.Views
{
    partial class RibbonFormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RibbonFormMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItemDashboardViewer = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDashboardEditor = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageDashboards = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupDashboards = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barButtonItemDashboardViewer,
            this.barButtonItemDashboardEditor});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 3;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageDashboards});
            this.ribbon.Size = new System.Drawing.Size(896, 180);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barButtonItemDashboardViewer
            // 
            this.barButtonItemDashboardViewer.Caption = "Visualizador";
            this.barButtonItemDashboardViewer.Hint = "Carga un archivo de dashboard";
            this.barButtonItemDashboardViewer.Id = 1;
            this.barButtonItemDashboardViewer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemDashboardViewer.ImageOptions.Image")));
            this.barButtonItemDashboardViewer.Name = "barButtonItemDashboardViewer";
            this.barButtonItemDashboardViewer.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barButtonItemDashboardViewer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemDashboardViewer_ItemClick);
            // 
            // barButtonItemDashboardEditor
            // 
            this.barButtonItemDashboardEditor.Caption = "Editor";
            this.barButtonItemDashboardEditor.Hint = "Edita y crea dashboards";
            this.barButtonItemDashboardEditor.Id = 2;
            this.barButtonItemDashboardEditor.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemDashboardEditor.ImageOptions.Image")));
            this.barButtonItemDashboardEditor.Name = "barButtonItemDashboardEditor";
            this.barButtonItemDashboardEditor.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barButtonItemDashboardEditor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemDashboardEditor_ItemClick);
            // 
            // ribbonPageDashboards
            // 
            this.ribbonPageDashboards.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupDashboards});
            this.ribbonPageDashboards.Name = "ribbonPageDashboards";
            this.ribbonPageDashboards.Text = "Dashboards";
            // 
            // ribbonPageGroupDashboards
            // 
            this.ribbonPageGroupDashboards.ItemLinks.Add(this.barButtonItemDashboardViewer);
            this.ribbonPageGroupDashboards.ItemLinks.Add(this.barButtonItemDashboardEditor);
            this.ribbonPageGroupDashboards.Name = "ribbonPageGroupDashboards";
            this.ribbonPageGroupDashboards.Text = "Común";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 523);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(896, 41);
            // 
            // RibbonFormMain
            // 
            this.AllowMdiBar = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 564);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "RibbonFormMain";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Social Office Dashboard Editor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.RibbonFormMain_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageDashboards;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupDashboards;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDashboardViewer;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDashboardEditor;
    }
}