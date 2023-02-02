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

namespace StudentExaminationSystemDesktop.Forms.Instructor.DialogForms.AddQuestion.AddOneQuestion
{
    public partial class AddOneQuestionDialogForm : XtraForm
    {
        private List<string> _alreadyAddedQuestion;
        public List<KeyValuePair<string, bool>> allOptions;

        public string questionBody;

        public AddOneQuestionDialogForm(List<string> alreadyAddedQuestion)
        {
            _alreadyAddedQuestion = alreadyAddedQuestion;

            InitializeComponent();

            allOptions = new List<KeyValuePair<string, bool>>();
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

                questionBody = questionBodyTextEdit.Text;

                DialogResult = DialogResult.OK;

            }
            catch(BaseException bex)
            {
                XtraMessageBox.Show(bex.Message, bex.Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addSimpleButton_Click(object sender, EventArgs e)
        {
            try
            {
                AddOption();
            }
            catch (BaseException bex)
            {
                XtraMessageBox.Show(bex.Message, bex.Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteSimpleButton_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteOpotion();
            }
            catch (BaseException bex)
            {
                XtraMessageBox.Show(bex.Message, bex.Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}