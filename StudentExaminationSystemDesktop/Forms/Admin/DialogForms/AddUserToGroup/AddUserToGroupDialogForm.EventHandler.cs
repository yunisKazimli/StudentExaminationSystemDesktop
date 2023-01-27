using AspConnectionManagement;
using DevExpress.XtraEditors;
using Entities.DTOs.Examination;
using Entities.DTOs.Examination.GetDTOs;
using Entities.DTOs.Identity;
using Entities.DTOs.Identity.GetDTOs;
using Newtonsoft.Json;
using StudentExaminationSystemDesktop.Exceptions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentExaminationSystemDesktop.Forms.Admin.DialogForms.AddUserToGroup
{
    public partial class AddUserToGroupDialogForm
    {
        private async void GetNecessaryData()
        {
            FillGroupsLookUp();
            FillUsersLookUp();
        }

        private void CheckEnteredValues()
        {
            if (groupLookUpEdit.EditValue == null)
                throw new BaseException("Choose group", "Empty value");

            if (userLookUpEdit.EditValue == null)
                throw new BaseException("Choose user", "Empty value");
        }

        private async void SendUrl()
        {
            UrlManager.UrlSender.SendAddUserToGroupUrl(_token, new UserToGroupDTO() { GroupId = ((Guid)groupLookUpEdit.EditValue).ToString(), UserId = ((Guid)userLookUpEdit.EditValue).ToString() });
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

            foreach(GroupGetDTO el in groups)
            {
                string instructorName;

                if (el.Instructor != null) instructorName = el.Instructor.UserName;
                else instructorName = "N/A";

                dt.Rows.Add(el.GroupId, el.GroupName, instructorName, el.Students.Count);
            }

            return dt;
        }

        private DataTable ConvertUserListToDt(List<UserGetDTO> users)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("User Id", typeof(Guid));
            dt.Columns.Add("User Name", typeof(string));
            dt.Columns.Add("User Role", typeof(string));
            dt.Columns.Add("Group Count", typeof(int));

            dt.Columns[0].ReadOnly = true;
            dt.Columns[1].ReadOnly = true;
            dt.Columns[2].ReadOnly = true;
            dt.Columns[3].ReadOnly = true;

            foreach (UserGetDTO el in users) dt.Rows.Add(el.UserId, el.UserName, el.Role, el.Groups.Count);

            return dt;
        }

        private async void FillGroupsLookUp()
        {
            groupLookUpEdit.Properties.DataSource = ConvertGroupListToDt(await DataManager.DataGetter.GetGroups(_token));

            groupLookUpEdit.Properties.DisplayMember = "Group Name";
            groupLookUpEdit.Properties.ValueMember = "Group Id";
        }

        private async void FillUsersLookUp()
        {
            userLookUpEdit.Properties.DataSource = ConvertUserListToDt(await DataManager.DataGetter.GetUsers(_token));

            userLookUpEdit.Properties.DisplayMember = "User Name";
            userLookUpEdit.Properties.ValueMember = "User Id";
        }
    }
}
