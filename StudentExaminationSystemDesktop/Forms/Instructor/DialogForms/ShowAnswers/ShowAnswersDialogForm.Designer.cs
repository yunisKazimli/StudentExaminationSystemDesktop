namespace StudentExaminationSystemDesktop.Forms.Instructor.DialogForms.ShowAnswers
{
    partial class ShowAnswersDialogForm
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
            this.answersGridControl = new DevExpress.XtraGrid.GridControl();
            this.answersGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optionsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.answersGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.answersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.optionsGridControl);
            this.layoutControl1.Controls.Add(this.answersGridControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(915, 441);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // optionsGridControl
            // 
            this.optionsGridControl.Location = new System.Drawing.Point(459, 12);
            this.optionsGridControl.MainView = this.optionsGridView;
            this.optionsGridControl.Name = "optionsGridControl";
            this.optionsGridControl.Size = new System.Drawing.Size(444, 417);
            this.optionsGridControl.TabIndex = 5;
            this.optionsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.optionsGridView});
            // 
            // optionsGridView
            // 
            this.optionsGridView.GridControl = this.optionsGridControl;
            this.optionsGridView.Name = "optionsGridView";
            // 
            // answersGridControl
            // 
            this.answersGridControl.Location = new System.Drawing.Point(12, 12);
            this.answersGridControl.MainView = this.answersGridView;
            this.answersGridControl.Name = "answersGridControl";
            this.answersGridControl.Size = new System.Drawing.Size(443, 417);
            this.answersGridControl.TabIndex = 4;
            this.answersGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.answersGridView});
            // 
            // answersGridView
            // 
            this.answersGridView.GridControl = this.answersGridControl;
            this.answersGridView.Name = "answersGridView";
            this.answersGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.answersGridView_FocusedRowChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(915, 441);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.answersGridControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(447, 421);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.optionsGridControl;
            this.layoutControlItem2.Location = new System.Drawing.Point(447, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(448, 421);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // ShowAnswersDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 441);
            this.Controls.Add(this.layoutControl1);
            this.Name = "ShowAnswersDialogForm";
            this.Text = "ShowAnswersDialogForm";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.optionsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.answersGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.answersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl answersGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView answersGridView;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.GridControl optionsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView optionsGridView;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}