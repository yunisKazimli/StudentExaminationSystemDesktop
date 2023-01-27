namespace StudentExaminationSystemDesktop.Forms.Instructor
{
    partial class InstructorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstructorForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.groupsBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.logoutBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.subFormPanelControl = new DevExpress.XtraEditors.PanelControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.showQuestionsBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.addQuestionBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.deleteQuestionBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subFormPanelControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.groupsBarButtonItem,
            this.logoutBarButtonItem,
            this.showQuestionsBarButtonItem,
            this.addQuestionBarButtonItem,
            this.deleteQuestionBarButtonItem});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 6;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1045, 158);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // groupsBarButtonItem
            // 
            this.groupsBarButtonItem.Caption = "Show";
            this.groupsBarButtonItem.Id = 1;
            this.groupsBarButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupsBarButtonItem.ImageOptions.Image")));
            this.groupsBarButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("groupsBarButtonItem.ImageOptions.LargeImage")));
            this.groupsBarButtonItem.Name = "groupsBarButtonItem";
            this.groupsBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.groupsBarButtonItem_ItemClick);
            // 
            // logoutBarButtonItem
            // 
            this.logoutBarButtonItem.Caption = "Logout";
            this.logoutBarButtonItem.Id = 2;
            this.logoutBarButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("logoutBarButtonItem.ImageOptions.Image")));
            this.logoutBarButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("logoutBarButtonItem.ImageOptions.LargeImage")));
            this.logoutBarButtonItem.Name = "logoutBarButtonItem";
            this.logoutBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.logoutBarButtonItem_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Menu";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.groupsBarButtonItem);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Groups";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.showQuestionsBarButtonItem);
            this.ribbonPageGroup2.ItemLinks.Add(this.addQuestionBarButtonItem);
            this.ribbonPageGroup2.ItemLinks.Add(this.deleteQuestionBarButtonItem);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Questions";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.logoutBarButtonItem);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Settings";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 548);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1045, 24);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.subFormPanelControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 158);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1045, 390);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // subFormPanelControl
            // 
            this.subFormPanelControl.Location = new System.Drawing.Point(12, 12);
            this.subFormPanelControl.Name = "subFormPanelControl";
            this.subFormPanelControl.Size = new System.Drawing.Size(1021, 366);
            this.subFormPanelControl.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1045, 390);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.subFormPanelControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1025, 370);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // showQuestionsBarButtonItem
            // 
            this.showQuestionsBarButtonItem.Caption = "Show";
            this.showQuestionsBarButtonItem.Id = 3;
            this.showQuestionsBarButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.showQuestionsBarButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.showQuestionsBarButtonItem.Name = "showQuestionsBarButtonItem";
            this.showQuestionsBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.showQuestionsBarButtonItem_ItemClick);
            // 
            // addQuestionBarButtonItem
            // 
            this.addQuestionBarButtonItem.Caption = "Add";
            this.addQuestionBarButtonItem.Id = 4;
            this.addQuestionBarButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.addQuestionBarButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.addQuestionBarButtonItem.Name = "addQuestionBarButtonItem";
            this.addQuestionBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addQuestionBarButtonItem_ItemClick);
            // 
            // deleteQuestionBarButtonItem
            // 
            this.deleteQuestionBarButtonItem.Caption = "Delete";
            this.deleteQuestionBarButtonItem.Id = 5;
            this.deleteQuestionBarButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.deleteQuestionBarButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.deleteQuestionBarButtonItem.Name = "deleteQuestionBarButtonItem";
            this.deleteQuestionBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteQuestionBarButtonItem_ItemClick);
            // 
            // InstructorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 572);
            this.ControlBox = false;
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "InstructorForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "InstructorForm";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.subFormPanelControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem groupsBarButtonItem;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.PanelControl subFormPanelControl;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarButtonItem logoutBarButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem showQuestionsBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem addQuestionBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem deleteQuestionBarButtonItem;
    }
}