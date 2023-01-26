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
            FillGroupsLookUp(await SendGetAllGroupsUrl());
            FillUsersLookUp(await SendGetAllUsersUrl());
        }

        private void CheckEnteredValues()
        {
            if (groupLookUpEdit.EditValue == null)
                throw new BaseException("Choose group", "Empty value");

            if (userLookUpEdit.EditValue == null)
                throw new BaseException("Choose user", "Empty value");
        }

        private async void SendAddUserToGroupUrl()
        {
            try
            {
                using (UrlBuilder urlBuilder = new UrlBuilder())
                {
                    UrlParameterContainer parameters = new UrlParameterContainer();

                    parameters.AddParameter("data", new UserToGroupDTO() { GroupId = ((Guid)groupLookUpEdit.EditValue).ToString(), UserId = ((Guid)userLookUpEdit.EditValue).ToString() }, false);

                    urlBuilder.UrlStartPart = "https://localhost:7199/";

                    urlBuilder.UrlAction = "addusertogroup";

                    urlBuilder.Token = _token;

                    urlBuilder.Method = HttpRequestTypeEnum.Post;

                    urlBuilder.Parameters = parameters;

                    urlBuilder.GenerateUrl();

                    await urlBuilder.SubmitRequestAsync();
                }
            }
            catch (BaseException be)
            {
                XtraMessageBox.Show(be.Message, be.Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            catch (Exception be)
            {
                XtraMessageBox.Show(be.Message, "Unexpected exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
        }

        private async Task<string> SendGetAllGroupsUrl()
        {
            try
            {
                using (UrlBuilder urlBuilder = new UrlBuilder())
                {
                    urlBuilder.UrlStartPart = "https://localhost:7199/";

                    urlBuilder.UrlAction = "getallgroups";

                    urlBuilder.Token = _token;

                    urlBuilder.Method = HttpRequestTypeEnum.Get;

                    urlBuilder.GenerateUrl();

                    return await urlBuilder.SubmitRequestAsync();
                }
            }
            catch (BaseException be)
            {
                XtraMessageBox.Show(be.Message, be.Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }
            catch (Exception be)
            {
                XtraMessageBox.Show(be.Message, "Unexpected exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }
        }

        private async Task<string> SendGetAllUsersUrl()
        {
            try
            {
                using (UrlBuilder urlBuilder = new UrlBuilder())
                {
                    urlBuilder.UrlStartPart = "https://localhost:7199/";

                    urlBuilder.UrlAction = "getallusers";

                    urlBuilder.Token = _token;

                    urlBuilder.Method = HttpRequestTypeEnum.Get;

                    urlBuilder.GenerateUrl();

                    return await urlBuilder.SubmitRequestAsync();
                }
            }
            catch (BaseException be)
            {
                XtraMessageBox.Show(be.Message, be.Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }
            catch (Exception be)
            {
                XtraMessageBox.Show(be.Message, "Unexpected exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }
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

        private void FillGroupsLookUp(string json)
        {
            List<GroupGetDTO> groups = new List<GroupGetDTO>();

            groups = JsonConvert.DeserializeObject<List<GroupGetDTO>>(json);

            groupLookUpEdit.Properties.DataSource = ConvertGroupListToDt(groups);

            groupLookUpEdit.Properties.DisplayMember = "Group Name";
            groupLookUpEdit.Properties.ValueMember = "Group Id";
        }

        private void FillUsersLookUp(string json)
        {
            List<UserGetDTO> users = new List<UserGetDTO>();

            users = JsonConvert.DeserializeObject<List<UserGetDTO>>(json);

            userLookUpEdit.Properties.DataSource = ConvertUserListToDt(users);

            userLookUpEdit.Properties.DisplayMember = "User Name";
            userLookUpEdit.Properties.ValueMember = "User Id";
        }
    }
}
