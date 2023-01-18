namespace StudentExaminationSystemDesktop
{
    partial class MainForm
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
            this.childrenFormContainerPanelControl = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.childrenFormContainerPanelControl)).BeginInit();
            this.SuspendLayout();
            // 
            // childrenFormContainerPanelControl
            // 
            this.childrenFormContainerPanelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childrenFormContainerPanelControl.Location = new System.Drawing.Point(0, 0);
            this.childrenFormContainerPanelControl.Name = "childrenFormContainerPanelControl";
            this.childrenFormContainerPanelControl.Size = new System.Drawing.Size(1039, 613);
            this.childrenFormContainerPanelControl.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 613);
            this.Controls.Add(this.childrenFormContainerPanelControl);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.childrenFormContainerPanelControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl childrenFormContainerPanelControl;
    }
}