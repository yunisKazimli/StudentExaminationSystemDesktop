using AspConnectionManagement;
using DevExpress.XtraEditors;
using Entities.DTOs.Examination.GetDTOs;
using Entities.DTOs.Identity.GetDTOs;
using Newtonsoft.Json;
using StudentExaminationSystemDesktop.Exceptions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentExaminationSystemDesktop.Forms.Admin.DialogForms.DeleteUserFromGroup
{
    public partial class DeleteUserFromGroupDialogForm
    {
        private List<GroupGetDTO> groupList;
        private List<UserGetDTO> userList;

        private async void GetNecessaryData()
        {
            await FillGroupList();
            await FillUserList();

            FillGroupLookUp();
        }

        private void CheckEnteredData()
        {
            if (groupLookUpEdit.EditValue == null) throw new BaseException("Choose group", "Empty value");

            if (userLookUpEdit.EditValue == null) throw new BaseException("Choose user", "Empty value");
        }

        private async void SendUrl()
        {
            UrlManager.UrlSender.SendDeleteUserFromGroupUrl(_token, (Guid)groupLookUpEdit.EditValue, (Guid)userLookUpEdit.EditValue);
        }

        private async Task FillGroupList()
        {
            groupList = await DataManager.DataGetter.GetGroups(_token);
        }

        private async Task FillUserList()
        {
            userList = await DataManager.DataGetter.GetUsers(_token);
        }

        private void FillGroupLookUp()
        {
            DataTable dt = ConvertGroupListToDt();

            groupLookUpEdit.Properties.DataSource = dt;

            groupLookUpEdit.Properties.DisplayMember = "Group Name";

            groupLookUpEdit.Properties.ValueMember = "Group Id";
        }

        private void FillUserLookUp()
        {
            DataTable dt = ConvertUserListToDt();

            userLookUpEdit.Properties.DataSource = dt;

            userLookUpEdit.Properties.DisplayMember = "User Name";

            userLookUpEdit.Properties.ValueMember = "User Id";
        }

        private DataTable ConvertGroupListToDt()
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

            foreach (GroupGetDTO el in groupList)
            {
                string instructorName;

                if (el.Instructor != null) instructorName = el.Instructor.UserName;
                else instructorName = "N/A";

                dt.Rows.Add(el.GroupId, el.GroupName, instructorName, el.Students.Count);
            }

            return dt;
        }

        private DataTable ConvertUserListToDt()
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

            foreach (UserGetDTO el in userList) 
                if (el.Groups.FirstOrDefault(el1 => el1.GroupId == (Guid)groupLookUpEdit.EditValue) != null) 
                    dt.Rows.Add(el.UserId, el.UserName, el.Role, el.Groups.Count);

            return dt;
        }
    }
}
