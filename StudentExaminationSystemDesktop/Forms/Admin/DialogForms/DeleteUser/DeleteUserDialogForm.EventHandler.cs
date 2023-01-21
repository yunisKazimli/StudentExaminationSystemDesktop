using AspConnectionManagement;
using DevExpress.XtraEditors;
using Entities.DTOs.Identity.GetDTOs;
using Newtonsoft.Json;
using StudentExaminationSystemDesktop.Exceptions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentExaminationSystemDesktop.Forms.Admin.DialogForms.DeleteUser
{
    public partial class DeleteUserDialogForm
    {
        private DataTable usersDataTable;

        private async void FillDataInLookUp()
        {
            string jsonData = await SendGetAllUsersUrl();

            usersDataTable = GetUsersDTByJsonData(jsonData);

            usersLookUpEdit.Properties.DataSource = usersDataTable;

            usersLookUpEdit.Properties.DisplayMember = "User Name";
            usersLookUpEdit.Properties.ValueMember = "User Id";
        }

        private void CheckEnteredData()
        {
            if (usersLookUpEdit.EditValue == null) throw new BaseParameterException("Choose user", "Wrong value");
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

        private async void SendDeleteUserByIdUrl()
        {
            try
            {
                using (UrlBuilder urlBuilder = new UrlBuilder())
                {
                    UrlParameterContainer parameters = new UrlParameterContainer();

                    parameters.AddParameter("userId", (Guid)usersLookUpEdit.EditValue, false);

                    urlBuilder.UrlStartPart = "https://localhost:7199/";

                    urlBuilder.UrlAction = "deleteUserById";

                    urlBuilder.Token = _token;

                    urlBuilder.Method = HttpRequestTypeEnum.Get;

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

        private DataTable GetUsersDTByJsonData(string jsonData)
        {
            DataTable dt = new DataTable();

            List<UserGetDTO> users = JsonConvert.DeserializeObject<List<UserGetDTO>>(jsonData);

            dt.Columns.Add("User Id", typeof(Guid));
            dt.Columns.Add("User Name", typeof(string));
            dt.Columns.Add("User Role", typeof(string));

            foreach (UserGetDTO el in users) dt.Rows.Add(el.UserId, el.UserName, el.Role);

            return dt;
        }
    }
}
