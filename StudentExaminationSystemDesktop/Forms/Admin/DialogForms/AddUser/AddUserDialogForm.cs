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

namespace StudentExaminationSystemDesktop.Forms.Admin.DialogForms.AddUser
{
    public partial class AddUserDialogForm : DevExpress.XtraEditors.XtraForm
    {
        private string _token;

        public AddUserDialogForm(string token)
        {
            _token = token;

            InitializeComponent();

            GetNeccessaryData();
        }

        private void cancelSimpleButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void applySimpleButton_Click(object sender, EventArgs e)
        {
            try
            {
                CheckEnteredData();

                SendUrl();

                DialogResult = DialogResult.OK;
            }
            catch (BaseException be)
            {
                XtraMessageBox.Show(be.Message, be.Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}