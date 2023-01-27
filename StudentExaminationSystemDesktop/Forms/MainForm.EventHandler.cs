using StudentExaminationSystemDesktop.Forms.Controllers;
using StudentExaminationSystemDesktop.Forms.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentExaminationSystemDesktop.Forms
{
    partial class MainForm
    {
        private SubFormController subFormCtrl;

        private void OpenEntrance()
        {
            OpenForm(new EntranceForm(this));
        }

        public void OpenForm(Form subForm)
        {
            subFormCtrl.OpenForm(subForm);
        }
    }
}
