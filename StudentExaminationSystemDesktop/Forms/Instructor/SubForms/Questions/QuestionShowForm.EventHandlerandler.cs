using Entities.DTOs.Examination.GetDTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentExaminationSystemDesktop.Forms.Instructor.SubForms.Questions
{
    public partial class QuestionShowForm
    {
        private List<QuestionGetDTO> _questions;

        private async void FillGroupsGrid()
        {
            List<GroupGetDTO> groups = await DataManager.DataGetter.GetGroups(_token);

            groupsGridControl.DataSource = ConvertGroupListToDt(groups);

            if (groups.Count > 0) FillQuestionGrid();
        }

        private DataTable ConvertGroupListToDt(List<GroupGetDTO> groups)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Group Id", typeof(Guid));
            dt.Columns.Add("Group Name", typeof(string));
            dt.Columns.Add("Instructor Name", typeof(string));
            dt.Columns.Add("Students Count", typeof(int));

            dt.Columns[0].ReadOnly = true;
            dt.Columns[1].ReadOnly = true;
            dt.Columns[2].ReadOnly = true;
            dt.Columns[3].ReadOnly = true;

            foreach(GroupGetDTO group in groups) 
            {
                string instructorName;

                if (group.Instructor == null) instructorName = "N/A";
                else instructorName = group.Instructor.UserName;

                dt.Rows.Add(group.GroupId, group.GroupName, instructorName, group.Students.Count);
            }

            return dt;
        }

        private async void FillQuestionGrid()
        {
            _questions = await DataManager.DataGetter.GetQuestions(_token, new Guid(groupsGridView.GetFocusedRowCellDisplayText("Group Id")));

            questionsGridControl.DataSource = ConvertQuestionListToDt(_questions);

            if (_questions.Count > 0) FillOptionGrid();
        }

        private DataTable ConvertQuestionListToDt(List<QuestionGetDTO> questions)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Question Id", typeof(Guid));
            dt.Columns.Add("Question Body", typeof(string));
            dt.Columns.Add("Options Count", typeof(int));

            dt.Columns[0].ReadOnly = true;
            dt.Columns[1].ReadOnly = true;
            dt.Columns[2].ReadOnly = true;

            foreach (QuestionGetDTO question in questions) dt.Rows.Add(question.QuestionId, question.QuestionBody, question.Options.Count);

            return dt;
        }

        private void FillOptionGrid()
        {
            optionsGridControl.DataSource = ConvertOptionsListToDt(_questions.FirstOrDefault(el => el.QuestionId == new Guid(questionsGridView.GetFocusedRowCellDisplayText("Question Id"))).Options);
        }

        private DataTable ConvertOptionsListToDt(List<OptionGetDTO> options)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Option Id", typeof(Guid));
            dt.Columns.Add("Option Body", typeof(string));
            dt.Columns.Add("Is Right", typeof(bool));

            dt.Columns[0].ReadOnly = true;
            dt.Columns[1].ReadOnly = true;
            dt.Columns[2].ReadOnly = true;

            foreach (OptionGetDTO option in options) dt.Rows.Add(option.OptionId, option.OptionBody, option.IsRight);

            return dt;
        }
    }
}
