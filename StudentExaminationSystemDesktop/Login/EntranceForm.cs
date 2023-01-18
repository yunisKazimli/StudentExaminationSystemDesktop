using DevExpress.XtraEditors;
using StudentExaminationSystemDesktop.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentExaminationSystemDesktop.Login
{
    public partial class EntranceForm : XtraForm
    {
        public EntranceForm(MainForm mainForm)
        {
            InitializeComponent();

            _mainForm = mainForm;
        }

        private void loginSimpleButton_Click(object sender, EventArgs e)
        {
            try
            {
                CheckInputParameter();
            }
            catch(BaseException be)
            {
                XtraMessageBox.Show(be.Message, be.Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            SendUrl();
        }
    }
}