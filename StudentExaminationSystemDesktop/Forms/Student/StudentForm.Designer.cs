using DevExpress.XtraEditors;
using System.Collections.Generic;

namespace StudentExaminationSystemDesktop.Forms.Student
{
    partial class StudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.groupLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.questionsPanelControl = new DevExpress.XtraEditors.PanelControl();
            this.saveSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.logoutSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionsPanelControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.groupLookUpEdit);
            this.layoutControl1.Controls.Add(this.questionsPanelControl);
            this.layoutControl1.Controls.Add(this.saveSimpleButton);
            this.layoutControl1.Controls.Add(this.logoutSimpleButton);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(894, 439);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // groupLookUpEdit
            // 
            this.groupLookUpEdit.Location = new System.Drawing.Point(91, 28);
            this.groupLookUpEdit.Name = "groupLookUpEdit";
            this.groupLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.groupLookUpEdit.Properties.EditValueChanged += new System.EventHandler(this.groupLookUpEdit_Properties_EditValueChanged);
            this.groupLookUpEdit.Size = new System.Drawing.Size(222, 20);
            this.groupLookUpEdit.StyleController = this.layoutControl1;
            this.groupLookUpEdit.TabIndex = 8;
            // 
            // questionsPanelControl
            // 
            this.questionsPanelControl.Location = new System.Drawing.Point(12, 52);
            this.questionsPanelControl.Name = "questionsPanelControl";
            this.questionsPanelControl.Size = new System.Drawing.Size(870, 349);
            this.questionsPanelControl.TabIndex = 7;
            // 
            // saveSimpleButton
            // 
            this.saveSimpleButton.Location = new System.Drawing.Point(745, 405);
            this.saveSimpleButton.Name = "saveSimpleButton";
            this.saveSimpleButton.Size = new System.Drawing.Size(137, 22);
            this.saveSimpleButton.StyleController = this.layoutControl1;
            this.saveSimpleButton.TabIndex = 6;
            this.saveSimpleButton.Text = "Save";
            this.saveSimpleButton.Click += new System.EventHandler(this.saveSimpleButton_Click);
            // 
            // logoutSimpleButton
            // 
            this.logoutSimpleButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("logoutSimpleButton.ImageOptions.Image")));
            this.logoutSimpleButton.Location = new System.Drawing.Point(800, 12);
            this.logoutSimpleButton.Name = "logoutSimpleButton";
            this.logoutSimpleButton.Size = new System.Drawing.Size(82, 36);
            this.logoutSimpleButton.StyleController = this.layoutControl1;
            this.logoutSimpleButton.TabIndex = 5;
            this.logoutSimpleButton.Text = "Logout";
            this.logoutSimpleButton.Click += new System.EventHandler(this.logoutSimpleButton_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.emptySpaceItem2,
            this.layoutControlItem3,
            this.emptySpaceItem4,
            this.layoutControlItem4,
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(894, 439);
            this.Root.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(305, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(483, 40);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.logoutSimpleButton;
            this.layoutControlItem2.Location = new System.Drawing.Point(788, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(86, 40);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(305, 16);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.saveSimpleButton;
            this.layoutControlItem3.Location = new System.Drawing.Point(733, 393);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(141, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(0, 393);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(733, 26);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.questionsPanelControl;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 40);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(874, 353);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.groupLookUpEdit;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 16);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(305, 24);
            this.layoutControlItem1.Text = "Choose group";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(67, 13);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 439);
            this.Controls.Add(this.layoutControl1);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionsPanelControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        private PanelControl SetAnswerPanel(string questionBody, List<string> options, List<string> answers, int index)
        {
            PanelControl newAnswerPanelControl = new PanelControl();
            CheckedComboBoxEdit newAnswerCheckedComboBoxEdit = new CheckedComboBoxEdit();
            LabelControl newQuestionLabelControl = new LabelControl();

            newAnswerPanelControl.Controls.Add(newAnswerCheckedComboBoxEdit);
            newAnswerPanelControl.Controls.Add(newQuestionLabelControl);
            newAnswerPanelControl.Location = new System.Drawing.Point(5, 5 + index * 52);
            newAnswerPanelControl.Name = "answerPanelControl";
            newAnswerPanelControl.Size = new System.Drawing.Size(836, 52);
            newAnswerPanelControl.TabIndex = 0;

            newQuestionLabelControl.Location = new System.Drawing.Point(5, 5);
            newQuestionLabelControl.Name = "questionLabelControl";
            newQuestionLabelControl.Size = new System.Drawing.Size(63, 13);
            newQuestionLabelControl.TabIndex = 0;
            newQuestionLabelControl.Text = questionBody;

            newAnswerCheckedComboBoxEdit.Location = new System.Drawing.Point(5, 27);
            newAnswerCheckedComboBoxEdit.Name = "answerCheckedComboBoxEdit";
            newAnswerCheckedComboBoxEdit.Size = new System.Drawing.Size(116, 20);
            newAnswerCheckedComboBoxEdit.TabIndex = 1;

            foreach (string el in options) newAnswerCheckedComboBoxEdit.Properties.Items.Add(el);

            newAnswerPanelControl.Controls.Add(newAnswerCheckedComboBoxEdit);
            newAnswerPanelControl.Controls.Add(newQuestionLabelControl);

            foreach(string el in answers) newAnswerCheckedComboBoxEdit.SetEditValue(el);

            return newAnswerPanelControl;
        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.SimpleButton logoutSimpleButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.SimpleButton saveSimpleButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraEditors.PanelControl questionsPanelControl;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private LookUpEdit groupLookUpEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}