namespace StudentExaminationSystemDesktop.Forms.Instructor.SubForms.Questions
{
    partial class QuestionShowForm
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
            this.optionsGridControl = new DevExpress.XtraGrid.GridControl();
            this.optionsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.questionsGridControl = new DevExpress.XtraGrid.GridControl();
            this.questionsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupsGridControl = new DevExpress.XtraGrid.GridControl();
            this.groupsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optionsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.optionsGridControl);
            this.layoutControl1.Controls.Add(this.questionsGridControl);
            this.layoutControl1.Controls.Add(this.groupsGridControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(939, 494);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // optionsGridControl
            // 
            this.optionsGridControl.Location = new System.Drawing.Point(626, 12);
            this.optionsGridControl.MainView = this.optionsGridView;
            this.optionsGridControl.Name = "optionsGridControl";
            this.optionsGridControl.Size = new System.Drawing.Size(301, 470);
            this.optionsGridControl.TabIndex = 6;
            this.optionsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.optionsGridView});
            // 
            // optionsGridView
            // 
            this.optionsGridView.GridControl = this.optionsGridControl;
            this.optionsGridView.Name = "optionsGridView";
            // 
            // questionsGridControl
            // 
            this.questionsGridControl.Location = new System.Drawing.Point(315, 12);
            this.questionsGridControl.MainView = this.questionsGridView;
            this.questionsGridControl.Name = "questionsGridControl";
            this.questionsGridControl.Size = new System.Drawing.Size(307, 470);
            this.questionsGridControl.TabIndex = 5;
            this.questionsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.questionsGridView});
            // 
            // questionsGridView
            // 
            this.questionsGridView.GridControl = this.questionsGridControl;
            this.questionsGridView.Name = "questionsGridView";
            this.questionsGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.questionsGridView_FocusedRowChanged);
            // 
            // groupsGridControl
            // 
            this.groupsGridControl.Location = new System.Drawing.Point(12, 12);
            this.groupsGridControl.MainView = this.groupsGridView;
            this.groupsGridControl.Name = "groupsGridControl";
            this.groupsGridControl.Size = new System.Drawing.Size(299, 470);
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
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(939, 494);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.groupsGridControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(303, 474);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.questionsGridControl;
            this.layoutControlItem2.Location = new System.Drawing.Point(303, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(311, 474);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.optionsGridControl;
            this.layoutControlItem3.Location = new System.Drawing.Point(614, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(305, 474);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // QuestionShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 494);
            this.Controls.Add(this.layoutControl1);
            this.Name = "QuestionShowForm";
            this.Text = "QuestionShowForm";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.optionsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl optionsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView optionsGridView;
        private DevExpress.XtraGrid.GridControl questionsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView questionsGridView;
        private DevExpress.XtraGrid.GridControl groupsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView groupsGridView;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}