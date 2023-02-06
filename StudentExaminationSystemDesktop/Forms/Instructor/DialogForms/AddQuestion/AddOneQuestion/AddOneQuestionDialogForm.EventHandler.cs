using StudentExaminationSystemDesktop.Exceptions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentExaminationSystemDesktop.Forms.Instructor.DialogForms.AddQuestion.AddOneQuestion
{
    public partial class AddOneQuestionDialogForm
    {
        private void CheckEnteredValues()
        {
            if (questionBodyTextEdit.Text == null || questionBodyTextEdit.Text == "")
                throw new BaseException("Enter question body", "Empty value");
            if (_alreadyAddedQuestion.Contains(questionBodyTextEdit.Text))
                throw new BaseException("This question body already added", "Ununique value");
            if (optionsGridView.DataRowCount < 2)
                throw new BaseException("Add at least 2 options", "Not Enought values");
        }

        private void AddOption()
        {
            if (optionBodyTextEdit.Text == null || optionBodyTextEdit.Text == "")
                throw new BaseException("Enter option body", "Empty value");
            if (allOptions.Where(el => el.Key == optionBodyTextEdit.Text).Count() > 0)
                throw new BaseException("This option body already added", "Ununique value");

            allOptions.Add(new KeyValuePair<string, bool>(optionBodyTextEdit.Text, isRightCheckEdit.Checked));

            RefreshGrid();
        }

        private void RefreshGrid()
        {
            optionsGridControl.DataSource = ConvertOptionsDictionaryToDt();
        }

        private DataTable ConvertOptionsDictionaryToDt()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Option body", typeof(string));
            dt.Columns.Add("IsAccessible right", typeof(bool));

            dt.Columns[0].ReadOnly = true;

            foreach (KeyValuePair<string, bool> el in allOptions) dt.Rows.Add(el.Key, el.Value);

            return dt;
        }

        private void DeleteOpotion()
        {
            DataRow focused = optionsGridView.GetFocusedDataRow();

            if (focused == null) throw new BaseException("Choose option in grid", "Not chose");

            allOptions.Remove(new KeyValuePair<string, bool>((string)focused["Option body"], (bool)focused["IsAccessible right"]));

            RefreshGrid();
        }
    }
}
