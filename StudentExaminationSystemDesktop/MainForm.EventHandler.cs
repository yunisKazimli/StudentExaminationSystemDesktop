using StudentExaminationSystemDesktop.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentExaminationSystemDesktop
{
    partial class MainForm
    {
        private Form currentChildForm;

        private void OpenEntrance()
        {
            OpenForm(new EntranceForm(this));
        }

        public void OpenForm(Form newForm)
        {
            if (currentChildForm != null) currentChildForm.Close();

            currentChildForm = newForm;

            currentChildForm.MdiParent = this;

            currentChildForm.Dock = DockStyle.Fill;

            currentChildForm.TopLevel = false;

            currentChildForm.TopMost = true;

            currentChildForm.FormBorderStyle = FormBorderStyle.None;

            currentChildForm.Show();

            childrenFormContainerPanelControl.Controls.Add(currentChildForm);
        }
    }
}
