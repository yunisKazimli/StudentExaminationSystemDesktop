using DevExpress.XtraBars;
using StudentExaminationSystemDesktop.Forms.Admin.SubForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentExaminationSystemDesktop.Forms.Controllers
{
    public class SubFormController
    {
        private Form _parentForm;
        private Form _subForm;

        private Control _controlPanel;

        public SubFormController(Form parentForm, Control controlPanel)
        {
            _parentForm = parentForm;
            _controlPanel = controlPanel;
        }

        public void OpenForm(Form newSubForm)
        {
            if (_subForm != null) _subForm.Close();

            _subForm = newSubForm;

            _subForm.MdiParent = _parentForm;

            _subForm.Dock = DockStyle.Fill;

            _subForm.TopLevel = false;

            _subForm.TopMost = true;

            _subForm.FormBorderStyle = FormBorderStyle.None;

            _subForm.Show();

            _controlPanel.Controls.Add(_subForm);
        }
    }
}
