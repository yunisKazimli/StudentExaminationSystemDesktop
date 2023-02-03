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

namespace StudentExaminationSystemDesktop.Forms.Instructor.DialogForms.DeleteQuestion
{
    public partial class DeleteQuestionDialogForm : DevExpress.XtraEditors.XtraForm
    {
        private string _token;

        public DeleteQuestionDialogForm(string token)
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

        private void questionLookUpEdit_Click(object sender, EventArgs e)
        {
            if (groupLookUpEdit.EditValue == null) 
                XtraMessageBox.Show("Choose group", "Emtpy group", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void groupLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            FillQuestionLookUp();
        }
    }
}