using AspConnectionManagement;
using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.XtraEditors;
using Entities.DTOs.Examination;
using Entities.DTOs.Examination.GetDTOs;
using StudentExaminationSystemDesktop.Exceptions;
using StudentExaminationSystemDesktop.Forms.Instructor.DialogForms.AddQuestion.AddOneQuestion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentExaminationSystemDesktop.Forms.Instructor.DialogForms.AddQuestion
{
    public partial class AddQuestionDialogForm
    {
        private List<GroupGetDTO> groups;
        private Dictionary<Guid, List<QuestionGetDTO>> alreadyAddedQuestions;
        private List<QuestionDTO> newQuestions;

        private async void GetNecasseryData()
        {
            groups = await DataManager.DataGetter.GetGroups(_token);

            FillGroupLookUp();

            alreadyAddedQuestions = new Dictionary<Guid, List<QuestionGetDTO>>();

            newQuestions = new List<QuestionDTO>();

            foreach (GroupGetDTO group in groups) 
                alreadyAddedQuestions.Add(group.GroupId, await DataManager.DataGetter.GetQuestions(_token, group.GroupId));
        }

        private void CheckEnteredData()
        {
            if (groupslookUpEdit.EditValue == null) throw new BaseException("Choose group", "Empty data");

            if (questionsGridView.RowCount == 0) throw new BaseException("Add at least one question", "Empty data");
        }

        private void SendUrl()
        {
            UrlManager.UrlSender.SendAddQuestionUrl(_token, newQuestions);
        }

        private void AddQuestion()
        {
            if (groupslookUpEdit.EditValue == null) throw new BaseException("Choose group", "Empty data");

            Guid groupId = (Guid)groupslookUpEdit.EditValue;

            List<string> questions = new List<string>();

            foreach (QuestionGetDTO el in alreadyAddedQuestions[(Guid)groupslookUpEdit.EditValue])
                questions.Add(el.QuestionBody);
            foreach (QuestionDTO el in newQuestions)
                questions.Add(el.QuestionBody);

            AddOneQuestionDialogForm addOneQuestionDialogForm = new AddOneQuestionDialogForm(questions);

            if (addOneQuestionDialogForm.ShowDialog() == DialogResult.OK)
            {
                newQuestions.Add
                    (
                        new QuestionDTO()
                        {
                            QuestionBody = addOneQuestionDialogForm.questionBody,
                            GroupId = groupId.ToString(),
                            Options =
                                (
                                    from el
                                    in addOneQuestionDialogForm.allOptions
                                    select new OptionDTO()
                                    {
                                        Body = el.Key,
                                        IsRight = el.Value
                                    }
                                ).ToList()
                        }
                    );
            }

            RefreshQuestionsGrid();
            RefreshOptionsGrid();
        }

        private void DeleteQuestion()
        {
            DataRow focused = questionsGridView.GetFocusedDataRow();

            if (focused == null) throw new BaseException("Choose question in grid", "Not chose");

            newQuestions.Remove(newQuestions.FirstOrDefault(el => el.QuestionBody == (string)focused["Question body"]));

            RefreshQuestionsGrid();
            RefreshOptionsGrid();
        }

        private void FillGroupLookUp()
        {
            groupslookUpEdit.Properties.DataSource = ConvertGroupListToDt();

            groupslookUpEdit.Properties.DisplayMember = "Group Name";
            groupslookUpEdit.Properties.ValueMember = "Group Id";
        }

        private DataTable ConvertGroupListToDt()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Group Id", typeof(Guid));
            dt.Columns.Add("Group Name", typeof(string));
            dt.Columns.Add("Student Count", typeof(int));

            dt.Columns[0].ReadOnly = true;
            dt.Columns[1].ReadOnly = true;
            dt.Columns[2].ReadOnly = true;

            foreach (GroupGetDTO group in groups) dt.Rows.Add(group.GroupId, group.GroupName, group.Students.Count);

            return dt;
        }

        private void RefreshQuestionsGrid()
        {
            questionsGridControl.DataSource = ConvertQuestionsListToDt();
        }

        private DataTable ConvertQuestionsListToDt()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Question Body", typeof(string));
            dt.Columns.Add("Option Count", typeof(int));

            dt.Columns[0].ReadOnly = true;
            dt.Columns[1].ReadOnly = true;

            foreach (QuestionDTO newQuestion in newQuestions) dt.Rows.Add(newQuestion.QuestionBody, newQuestion.Options.Count);

            return dt;
        }

        private DataTable ConvertOptionsListToDt()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Option Body", typeof(string));
            dt.Columns.Add("Is right", typeof(bool));

            dt.Columns[0].ReadOnly = true;
            dt.Columns[1].ReadOnly = true;

            foreach (OptionDTO opt in newQuestions.FirstOrDefault(el => el.QuestionBody == (string)questionsGridView.GetFocusedDataRow()["Question Body"]).Options) dt.Rows.Add(opt.Body, opt.IsRight);

            return dt;
        }

        private void RefreshOptionsGrid()
        {
            DataRow focused = questionsGridView.GetFocusedDataRow();

            if (focused == null)
            {
                optionsGridControl.DataSource = null;

                return;
            }

            optionsGridControl.DataSource = ConvertOptionsListToDt();
        }
    }
}
