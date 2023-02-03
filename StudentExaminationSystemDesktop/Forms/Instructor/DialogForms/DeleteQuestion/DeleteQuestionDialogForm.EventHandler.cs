using Entities.DTOs.Examination.GetDTOs;
using Entities.DTOs.Identity.GetDTOs;
using StudentExaminationSystemDesktop.Exceptions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentExaminationSystemDesktop.Forms.Instructor.DialogForms.DeleteQuestion
{
    public partial class DeleteQuestionDialogForm
    {
        private void GetNecessaryData()
        {
            FillGroupLookUp();
        }

        private void CheckEnteredData()
        {
            if (groupLookUpEdit.EditValue == null)
                throw new BaseException("Choose group", "Empty value");
            if (questionLookUpEdit.EditValue == null)
                throw new BaseException("Choose question", "Empty value");
        }

        private void SendUrl()
        {
            UrlManager.UrlSender.SendDeleteQuestionUrl(_token, (Guid)groupLookUpEdit.EditValue, (Guid)questionLookUpEdit.EditValue);
        }

        private async void FillGroupLookUp()
        {
            groupLookUpEdit.Properties.DataSource = ConvertGroupListToDt(await DataManager.DataGetter.GetGroups(_token));

            groupLookUpEdit.Properties.ValueMember = "Group Id";
            groupLookUpEdit.Properties.DisplayMember = "Group Name";
        }
        
        private DataTable ConvertGroupListToDt(List<GroupGetDTO> groups)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Group Id", typeof(Guid));
            dt.Columns.Add("Group Name", typeof(string));
            dt.Columns.Add("Students Count", typeof(int));

            dt.Columns[0].ReadOnly = true;
            dt.Columns[1].ReadOnly = true;
            dt.Columns[2].ReadOnly = true;

            foreach (GroupGetDTO el in groups) dt.Rows.Add(el.GroupId, el.GroupName, el.Students.Count);

            return dt;
        }

        private async void FillQuestionLookUp()
        {
            questionLookUpEdit.Properties.DataSource = ConvertQuestionLookUp(await DataManager.DataGetter.GetQuestions(_token, (Guid)groupLookUpEdit.EditValue));

            questionLookUpEdit.Properties.ValueMember = "Question Id";
            questionLookUpEdit.Properties.DisplayMember = "Question Body";
        }

        private DataTable ConvertQuestionLookUp(List<QuestionGetDTO> questions)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Question Id", typeof(Guid));
            dt.Columns.Add("Question Body", typeof(string));
            dt.Columns.Add("Options Count", typeof(int));

            dt.Columns[0].ReadOnly = true;
            dt.Columns[1].ReadOnly = true;
            dt.Columns[2].ReadOnly = true;

            foreach (QuestionGetDTO el in questions) dt.Rows.Add(el.QuestionId, el.QuestionBody, el.Options.Count);

            return dt;
        }
    }
}
