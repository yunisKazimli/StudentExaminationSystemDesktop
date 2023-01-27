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

namespace StudentExaminationSystemDesktop.Forms.Admin.DialogForms.DeleteGroup
{
    public partial class DeleteGroupDialogForm : DevExpress.XtraEditors.XtraForm
    {
        private string _token;

        public DeleteGroupDialogForm(string token)
        {
            _token = token;

            InitializeComponent();

            FillLookUp();
        }

        private void cancelSimpleButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void okSimpleButton_Click(object sender, EventArgs e)
        {
            try
            {
                CheckEnteredValues();

                SendUrl();

                DialogResult = DialogResult.OK;
            }
            catch(BaseException bex)
            {
                XtraMessageBox.Show(bex.Message, bex.Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}