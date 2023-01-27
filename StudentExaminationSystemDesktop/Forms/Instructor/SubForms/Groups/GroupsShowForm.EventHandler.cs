using Entities.DTOs.Examination.GetDTOs;
using Entities.DTOs.Identity.GetDTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentExaminationSystemDesktop.Forms.Instructor.SubForms.Groups
{
    public partial class GroupsShowForm
    {
        private List<GroupGetDTO> groups;

        private async void RefreshGroupGrid()
        {
            groups = await DataManager.DataGetter.GetGroups(_token);

            FillGroupGrid(GroupListToDt());
        }

        private void RefreshUsersGrid()
        {
            FillUsersGrid(UsersListToDt());
        }

        private void FillGroupGrid(DataTable dt)
        {
            groupsGridControl.DataSource = dt;

            if (groups.Count > 0) RefreshUsersGrid();
        }

        private void FillUsersGrid(DataTable dt)
        {
            usersGridControl.DataSource = dt;
        }

        private DataTable GroupListToDt()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Group Id", typeof(Guid));
            dt.Columns.Add("Group Name", typeof(string));
            dt.Columns.Add("Student Count", typeof(int));

            dt.Columns[0].ReadOnly = true;
            dt.Columns[1].ReadOnly = true;
            dt.Columns[2].ReadOnly = true;

            foreach (GroupGetDTO el in groups) dt.Rows.Add(el.GroupId, el.GroupName, el.Students.Count);

            return dt;
        }

        private DataTable UsersListToDt()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("User Id", typeof(Guid));
            dt.Columns.Add("User Name", typeof(string));

            dt.Columns[0].ReadOnly = true;
            dt.Columns[1].ReadOnly = true;

            foreach (UserGetDTO el in groups.FirstOrDefault(el1 => el1.GroupId == (Guid)groupsGridView.GetFocusedDataRow()["Group Id"]).Students) dt.Rows.Add(el.UserId, el.UserName);

            return dt;
        }
    }
}
