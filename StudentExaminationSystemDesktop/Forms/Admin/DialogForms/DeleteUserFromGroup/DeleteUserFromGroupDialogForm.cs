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

namespace StudentExaminationSystemDesktop.Forms.Admin.DialogForms.DeleteUserFromGroup
{
    public partial class DeleteUserFromGroupDialogForm : XtraForm
    {
        private string _token;

        public DeleteUserFromGroupDialogForm(string token)
        {
            _token = token;

            InitializeComponent();

            GetNecessaryData();
        }

        private void okSimpleButton_Click(object sender, EventArgs e)
        {
            try
            {
                CheckEnteredData();

                SendUrl();

                DialogResult = DialogResult.OK;
            }
            catch(BaseException be)
            {
                XtraMessageBox.Show(be.Message, be.Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelSimpleButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void userLookUpEdit_Click(object sender, EventArgs e)
        {
            if (groupLookUpEdit.EditValue == null)
            {
                XtraMessageBox.Show("Choose group", "Empty value", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
        }

        private void groupLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            FillUserLookUp();
        }
    }
}