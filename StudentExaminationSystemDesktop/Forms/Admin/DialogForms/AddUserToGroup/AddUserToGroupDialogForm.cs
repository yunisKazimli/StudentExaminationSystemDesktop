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

namespace StudentExaminationSystemDesktop.Forms.Admin.DialogForms.AddUserToGroup
{
    public partial class AddUserToGroupDialogForm : DevExpress.XtraEditors.XtraForm
    {
        private string _token;

        public AddUserToGroupDialogForm(string token)
        {
            _token = token;

            InitializeComponent();

            GetNecessaryData();
        }

        private void okSimpleButton_Click(object sender, EventArgs e)
        {
            try
            {
                CheckEnteredValues();

                SendUrl();

                DialogResult = DialogResult.OK;
            }
            catch(BaseException ex)
            {
                XtraMessageBox.Show(ex.Message, ex.Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelSimpleButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}