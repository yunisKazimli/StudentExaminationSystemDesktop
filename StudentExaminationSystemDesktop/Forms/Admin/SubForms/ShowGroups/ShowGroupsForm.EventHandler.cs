using AspConnectionManagement;
using DevExpress.XtraEditors;
using Entities.DTOs.Examination.GetDTOs;
using Entities.DTOs.Identity.GetDTOs;
using Newtonsoft.Json;
using StudentExaminationSystemDesktop.DataManager;
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
            groupsList = await DataGetter.GetGroups(_token);

            FillGroupsGrid();

            if (groupsList.Count > 0) RefreshUsersGrid();
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
