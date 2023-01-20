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
            string jsonData = await SendGetAllUsersUrl();

            List<UserGetDTO> users = JsonConvert.DeserializeObject<List<UserGetDTO>>(jsonData);

            DataTable usersDt = CreateDataTable(users);

            FillGrid(usersDt);
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
