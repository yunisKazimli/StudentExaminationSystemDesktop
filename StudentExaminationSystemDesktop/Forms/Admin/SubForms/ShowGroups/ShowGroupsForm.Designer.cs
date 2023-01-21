namespace StudentExaminationSystemDesktop.Forms.Admin.SubForms
{
    partial class ShowGroupsForm
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.groupsGridControl = new DevExpress.XtraGrid.GridControl();
            this.groupsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.userInGroupGridControl = new DevExpress.XtraGrid.GridControl();
            this.userInGroupGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInGroupGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInGroupGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.userInGroupGridControl);
            this.layoutControl1.Controls.Add(this.groupsGridControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(841, 387);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(841, 387);
            this.Root.TextVisible = false;
            // 
            // groupsGridControl
            // 
            this.groupsGridControl.Location = new System.Drawing.Point(12, 12);
            this.groupsGridControl.MainView = this.groupsGridView;
            this.groupsGridControl.Name = "groupsGridControl";
            this.groupsGridControl.Size = new System.Drawing.Size(411, 363);
            this.groupsGridControl.TabIndex = 4;
            this.groupsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.groupsGridView});
            // 
            // groupsGridView
            // 
            this.groupsGridView.GridControl = this.groupsGridControl;
            this.groupsGridView.Name = "groupsGridView";
            this.groupsGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.groupsGridView_FocusedRowChanged);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.groupsGridControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(415, 367);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // userInGroupGridControl
            // 
            this.userInGroupGridControl.Location = new System.Drawing.Point(427, 12);
            this.userInGroupGridControl.MainView = this.userInGroupGridView;
            this.userInGroupGridControl.Name = "userInGroupGridControl";
            this.userInGroupGridControl.Size = new System.Drawing.Size(402, 363);
            this.userInGroupGridControl.TabIndex = 5;
            this.userInGroupGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.userInGroupGridView});
            // 
            // userInGroupGridView
            // 
            this.userInGroupGridView.GridControl = this.userInGroupGridControl;
            this.userInGroupGridView.Name = "userInGroupGridView";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.userInGroupGridControl;
            this.layoutControlItem2.Location = new System.Drawing.Point(415, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(406, 367);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // ShowGroupsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 387);
            this.ControlBox = false;
            this.Controls.Add(this.layoutControl1);
            this.Name = "ShowGroupsForm";
            this.Text = "ShowGroupsForm";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInGroupGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInGroupGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl userInGroupGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView userInGroupGridView;
        private DevExpress.XtraGrid.GridControl groupsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView groupsGridView;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}