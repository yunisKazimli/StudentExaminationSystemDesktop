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

namespace StudentExaminationSystemDesktop.Forms.Admin.DialogForms.AddGroup
{
    public partial class AddGroupDialogForm : DevExpress.XtraEditors.XtraForm
    {
        private string _token;

        public AddGroupDialogForm(string token)
        {
            _token = token;

            InitializeComponent();

            GetNecessaryData();
        }

        private void cancelSimpleButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void okSimpleButton_Click(object sender, EventArgs e)
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