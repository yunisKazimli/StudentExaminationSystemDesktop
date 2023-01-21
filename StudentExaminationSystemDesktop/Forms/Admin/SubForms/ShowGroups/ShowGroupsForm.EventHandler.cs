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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace StudentExaminationSystemDesktop.Forms.Admin.SubForms
{
    public partial class ShowGroupsForm
    {
        private List<GroupGetDTO> groupsList;

        private async void RefreshGroupsGrid()
        {
            string jsonData = await SendGetlAllGroupsUrl();

            groupsList = JsonConvert.DeserializeObject<List<GroupGetDTO>>(jsonData);

            FillGroupsGrid();
        }

        private void RefreshUsersGrid()
        {
            DataTable users = new DataTable();

            GroupGetDTO currentGroup = groupsList.FirstOrDefault(el => el.GroupId == (Guid)groupsGridView.GetFocusedDataRow()["Group Id"]);

            users.Columns.Add("User Id", typeof(Guid));
            users.Columns.Add("User Name", typeof(string));

            users.Columns[0].ReadOnly = true;
            users.Columns[1].ReadOnly = true;

            foreach(UserGetDTO el in currentGroup.Students) users.Rows.Add(el.UserId, el.UserName);

            userInGroupGridControl.DataSource = users;
        }

        private async Task<string> SendGetlAllGroupsUrl()
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

        private void FillGroupsGrid()
        {
            DataTable groups = new DataTable();

            groups.Columns.Add("Group Id", typeof(Guid));
            groups.Columns.Add("Group Name", typeof(string));
            groups.Columns.Add("Instructor Name", typeof(string));
            groups.Columns.Add("Student Count", typeof(int));

            groups.Columns[0].ReadOnly = true;
            groups.Columns[1].ReadOnly = true;
            groups.Columns[2].ReadOnly = true;
            groups.Columns[3].ReadOnly = true;

            foreach (GroupGetDTO el in groupsList)
            {
                string instructorName;

                if (el.Instructor == null) instructorName = "N/A";
                else instructorName = el.Instructor.UserName;

                groups.Rows.Add(el.GroupId, el.GroupName, instructorName, el.Students.Count);
            }

            groupsGridControl.DataSource = groups;
        }
    }
}
