using DevExpress.XtraEditors;
using Entities.DTOs.Examination;
using Entities.DTOs.Examination.GetDTOs;
using StudentExaminationSystemDesktop.Forms.Login;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentExaminationSystemDesktop.Forms.Student
{
    public partial class StudentForm
    {
        private List<StudentAnswerGetDTO> alreadyAddedAnswers = new List<StudentAnswerGetDTO>();
        private Dictionary<Guid, List<QuestionGetDTO>> questions = new Dictionary<Guid, List<QuestionGetDTO>>();
        private List<GroupGetDTO> groups = new List<GroupGetDTO>();

        private async void GetNecessaryData()
        {
            await FillGroupLook();

            FillQuestionList();

            questionsPanelControl.HorizontalScroll.Visible = true;
            questionsPanelControl.VerticalScroll.Visible = true;
        }

        private async Task FillGroupLook()
        {
            groups = await DataManager.DataGetter.GetGroups(_token);
            groupLookUpEdit.Properties.DataSource = ConvertGroupToDt(groups);

            groupLookUpEdit.Properties.ValueMember = "Group Id";
            groupLookUpEdit.Properties.DisplayMember = "Group Name";
        }

        private async void FillQuestionList()
        {
            foreach(GroupGetDTO el in groups)
            {
                questions.Add(el.GroupId, await DataManager.DataGetter.GetQuestions(_token, el.GroupId));
            }
        }

        private DataTable ConvertGroupToDt(List<GroupGetDTO> groups)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Group Id", typeof(Guid));
            dt.Columns.Add("Group Name", typeof(string));
            dt.Columns.Add("Instructor Name", typeof(string));

            foreach(GroupGetDTO el in groups)
            {
                string instructorName;

                if (el.Instructor != null) instructorName = el.Instructor.UserName;
                else instructorName = "N/A";

                dt.Rows.Add(el.GroupId, el.GroupName, instructorName);
            }

            return dt;
        }
        
        private void Logout()
        {
            _mainForm.OpenForm(new EntranceForm(_mainForm));
        }

        private async void RefreshQuestions()
        {
            int index = 0;

            alreadyAddedAnswers = await DataManager.DataGetter.GetStudentAnswers(_token, (Guid)groupLookUpEdit.EditValue, _studentId);

            foreach (QuestionGetDTO el in questions[(Guid)groupLookUpEdit.EditValue])
            {
                List<string> answers = new List<string>();

                if (alreadyAddedAnswers.FirstOrDefault(el2 => el2.QuestionId == el.QuestionId) != null)
                {
                    answers =
                    (
                        alreadyAddedAnswers.Count > 0 ?
                        (
                            from el1
                            in alreadyAddedAnswers.FirstOrDefault(el2 => el2.QuestionId == el.QuestionId).Options
                            select el1?.OptionBody
                        ).ToList() :
                        new List<string>()
                    );
                }

                questionsPanelControl.Controls.Add
                    (
                        SetAnswerPanel
                        (
                            el.QuestionBody,
                            (
                                from el1
                                in el.Options
                                select el1.OptionBody
                            ).ToList(),
                            answers,
                            index
                        )
                    );

                index++;
            }
        }

        private void SaveAnswers()
        {
            List<QuestionGetDTO> groupQuestions = questions[(Guid)groupLookUpEdit.EditValue];

            List<StudentAnswerDTO> answers = new List<StudentAnswerDTO>();

            foreach (Control el in questionsPanelControl.Controls)
            {
                QuestionGetDTO question = groupQuestions.FirstOrDefault(el1 => el1.QuestionBody == (el.Controls["questionLabelControl"] as LabelControl).Text);

                object checkedItems = (el.Controls["answerCheckedComboBoxEdit"] as CheckedComboBoxEdit).EditValue;

                List<string> checkedList = (checkedItems as string).Replace(", ", ",").Split(',').ToList();

                checkedList.RemoveAll(el1 => el1 == "");

                if (checkedList.Count == 0) continue;

                answers.Add
                    (
                        new StudentAnswerDTO()
                        {
                            AnswerBody = "",
                            QuestionId = question.QuestionId.ToString(),
                            OptionsId =
                                (
                                    from el2
                                    in checkedList
                                    select question.Options.FirstOrDefault(el3 => el3.OptionBody == el2).OptionId.ToString()
                                ).ToList()
                        }
                    );
            }

            foreach(StudentAnswerDTO el in answers) UrlManager.UrlSender.SendAddStudentAnswersUrl(_token, el);
        }
    }
}
