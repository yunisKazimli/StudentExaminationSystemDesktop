﻿namespace StudentExaminationSystemDesktop.Admin
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.showUsersBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.addUsersBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.deleteUsersBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.showGroupsBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.addGroupsBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.deleteGroupsBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.logoutBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.showUsersBarButtonItem,
            this.addUsersBarButtonItem,
            this.deleteUsersBarButtonItem,
            this.showGroupsBarButtonItem,
            this.addGroupsBarButtonItem,
            this.deleteGroupsBarButtonItem,
            this.logoutBarButtonItem});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 8;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1045, 158);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // showUsersBarButtonItem
            // 
            this.showUsersBarButtonItem.Caption = "Show";
            this.showUsersBarButtonItem.Id = 1;
            this.showUsersBarButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.showUsersBarButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.showUsersBarButtonItem.Name = "showUsersBarButtonItem";
            // 
            // addUsersBarButtonItem
            // 
            this.addUsersBarButtonItem.Caption = "Add";
            this.addUsersBarButtonItem.Id = 2;
            this.addUsersBarButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.addUsersBarButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.addUsersBarButtonItem.Name = "addUsersBarButtonItem";
            // 
            // deleteUsersBarButtonItem
            // 
            this.deleteUsersBarButtonItem.Caption = "Delete";
            this.deleteUsersBarButtonItem.Id = 3;
            this.deleteUsersBarButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.deleteUsersBarButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.deleteUsersBarButtonItem.Name = "deleteUsersBarButtonItem";
            // 
            // showGroupsBarButtonItem
            // 
            this.showGroupsBarButtonItem.Caption = "Show";
            this.showGroupsBarButtonItem.Id = 4;
            this.showGroupsBarButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.showGroupsBarButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.showGroupsBarButtonItem.Name = "showGroupsBarButtonItem";
            // 
            // addGroupsBarButtonItem
            // 
            this.addGroupsBarButtonItem.Caption = "Add";
            this.addGroupsBarButtonItem.Id = 5;
            this.addGroupsBarButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.Image")));
            this.addGroupsBarButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.LargeImage")));
            this.addGroupsBarButtonItem.Name = "addGroupsBarButtonItem";
            // 
            // deleteGroupsBarButtonItem
            // 
            this.deleteGroupsBarButtonItem.Caption = "Delete";
            this.deleteGroupsBarButtonItem.Id = 6;
            this.deleteGroupsBarButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.Image")));
            this.deleteGroupsBarButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.LargeImage")));
            this.deleteGroupsBarButtonItem.Name = "deleteGroupsBarButtonItem";
            // 
            // logoutBarButtonItem
            // 
            this.logoutBarButtonItem.Caption = "Logout";
            this.logoutBarButtonItem.Id = 7;
            this.logoutBarButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.ImageOptions.Image")));
            this.logoutBarButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.ImageOptions.LargeImage")));
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
            this.ribbonPageGroup1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageGroup1.ImageOptions.Image")));
            this.ribbonPageGroup1.ItemLinks.Add(this.showUsersBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.addUsersBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.deleteUsersBarButtonItem);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Users";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.showGroupsBarButtonItem);
            this.ribbonPageGroup2.ItemLinks.Add(this.addGroupsBarButtonItem);
            this.ribbonPageGroup2.ItemLinks.Add(this.deleteGroupsBarButtonItem);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Groups";
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
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 572);
            this.ControlBox = false;
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "AdminForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem showUsersBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem addUsersBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem deleteUsersBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem showGroupsBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem deleteGroupsBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem logoutBarButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem addGroupsBarButtonItem;
    }
}