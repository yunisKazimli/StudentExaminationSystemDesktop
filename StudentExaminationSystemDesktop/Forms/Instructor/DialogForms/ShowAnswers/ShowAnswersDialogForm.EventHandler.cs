using Entities.DTOs.Examination.GetDTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentExaminationSystemDesktop.Forms.Instructor.DialogForms.ShowAnswers
{
    public partial class ShowAnswersDialogForm
    {
        private void ShowAnswers()
        {
            answersGridControl.DataSource = ConvertAnswersListToDt();

            RefreshOptionsGrid();
        }

        private DataTable ConvertAnswersListToDt()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Answer Id", typeof(Guid));
            dt.Columns.Add("Question Body", typeof(string));

            dt.Columns[0].ReadOnly = true;
            dt.Columns[1].ReadOnly = true;

            foreach (StudentAnswerGetDTO el in _allAnswers) dt.Rows.Add(el.StudentAnswerId, _allQuestions.FirstOrDefault(el1 => el1.QuestionId == el.QuestionId).QuestionBody);

            return dt;
        }

        private void RefreshOptionsGrid()
        {
            if (answersGridView.GetFocusedDataRow() == null) return;

            optionsGridControl.DataSource = ConvertOptionsListToDt();
        }

        private DataTable ConvertOptionsListToDt()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Option Id", typeof(Guid));
            dt.Columns.Add("Option Body", typeof(string));
            dt.Columns.Add("Is Right", typeof(bool));

            dt.Columns[0].ReadOnly = true;
            dt.Columns[1].ReadOnly = true;
            dt.Columns[2].ReadOnly = true;

            foreach (OptionGetDTO opt in _allAnswers.FirstOrDefault(el => _allQuestions.FirstOrDefault(el1 => el1.QuestionId == el.QuestionId).QuestionBody == (string)answersGridView.GetFocusedDataRow()["Question Body"]).Options)
                dt.Rows.Add(opt.OptionId, opt.OptionBody, opt.IsRight);

            return dt;
        }
    }
}
