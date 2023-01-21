namespace StudentExaminationSystemDesktop.Forms.Admin.DialogForms.DeleteGroup
{
    partial class DeleteGroupDialogForm
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
            this.groupsLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.cancelSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.okSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.okSimpleButton);
            this.layoutControl1.Controls.Add(this.cancelSimpleButton);
            this.layoutControl1.Controls.Add(this.groupsLookUpEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(298, 268);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem3,
            this.layoutControlItem2,
            this.emptySpaceItem2,
            this.emptySpaceItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(298, 268);
            this.Root.TextVisible = false;
            // 
            // groupsLookUpEdit
            // 
            this.groupsLookUpEdit.Location = new System.Drawing.Point(91, 119);
            this.groupsLookUpEdit.Name = "groupsLookUpEdit";
            this.groupsLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.groupsLookUpEdit.Size = new System.Drawing.Size(195, 20);
            this.groupsLookUpEdit.StyleController = this.layoutControl1;
            this.groupsLookUpEdit.TabIndex = 4;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.groupsLookUpEdit;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 107);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(278, 24);
            this.layoutControlItem1.Text = "Choose group";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(67, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 131);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(278, 91);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // cancelSimpleButton
            // 
            this.cancelSimpleButton.Location = new System.Drawing.Point(12, 234);
            this.cancelSimpleButton.Name = "cancelSimpleButton";
            this.cancelSimpleButton.Size = new System.Drawing.Size(74, 22);
            this.cancelSimpleButton.StyleController = this.layoutControl1;
            this.cancelSimpleButton.TabIndex = 5;
            this.cancelSimpleButton.Text = "Cancel";
            this.cancelSimpleButton.Click += new System.EventHandler(this.cancelSimpleButton_Click);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cancelSimpleButton;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 222);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(78, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // okSimpleButton
            // 
            this.okSimpleButton.Location = new System.Drawing.Point(205, 234);
            this.okSimpleButton.Name = "okSimpleButton";
            this.okSimpleButton.Size = new System.Drawing.Size(81, 22);
            this.okSimpleButton.StyleController = this.layoutControl1;
            this.okSimpleButton.TabIndex = 6;
            this.okSimpleButton.Text = "Ok";
            this.okSimpleButton.Click += new System.EventHandler(this.okSimpleButton_Click);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.okSimpleButton;
            this.layoutControlItem3.Location = new System.Drawing.Point(193, 222);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(85, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(78, 222);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(115, 26);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(278, 107);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // DeleteGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 268);
            this.Controls.Add(this.layoutControl1);
            this.Name = "DeleteGroup";
            this.Text = "DeleteGroup";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton okSimpleButton;
        private DevExpress.XtraEditors.SimpleButton cancelSimpleButton;
        private DevExpress.XtraEditors.LookUpEdit groupsLookUpEdit;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
    }
}