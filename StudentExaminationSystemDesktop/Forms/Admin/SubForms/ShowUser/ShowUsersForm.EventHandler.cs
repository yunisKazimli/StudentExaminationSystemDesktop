using AspConnectionManagement;
using DevExpress.XtraEditors;
using StudentExaminationSystemDesktop.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities.DTOs.Identity.GetDTOs;
using Newtonsoft.Json;
using System.Data;
using StudentExaminationSystemDesktop.Forms.Admin.Enums;
using Entities.DTOs.Examination.GetDTOs;

namespace StudentExaminationSystemDesktop.Forms.Admin.SubForms
{
    public partial class ShowUsersForm
    {
        private async void GridRefresh()
        {
            DataTable usersDt = CreateDataTable(await DataManager.DataGetter.GetUsers(_token));

            FillGrid(usersDt);
        }

        private DataTable CreateDataTable(List<UserGetDTO> users)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Id", typeof(string));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Role", typeof(string));
            dt.Columns.Add("GroupCount", typeof(int));

            dt.Columns[0].ReadOnly = true;
            dt.Columns[1].ReadOnly = true;
            dt.Columns[2].ReadOnly = true;
            dt.Columns[3].ReadOnly = true;

            foreach (UserGetDTO u in users)
            {
                dt.Rows.Add
                    (
                        u.UserId,
                        u.UserName,
                        u.Role,
                        u.Groups.Count
                    );
            }

            return dt;
        }

        private void FillGrid(DataTable usersDt)
        {
            dataGridControl.DataSource = usersDt;
        }
    }
}
