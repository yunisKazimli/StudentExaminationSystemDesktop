using AspConnectionManagement;
using DevExpress.Office.Utils;
using DevExpress.XtraEditors;
using Entities.DTOs.Identity.GetDTOs;
using Newtonsoft.Json;
using StudentExaminationSystemDesktop.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace StudentExaminationSystemDesktop.Forms.Admin.DialogForms.DeleteUser
{
    public partial class DeleteUserDialogForm
    {
        private Dictionary<string, string> allUsers;

        private async void GetNeccessaryData()
        {
            string jsonData = await SendGetAllUsersUrl();

            allUsers = GetlAllUsers(jsonData);

            FillLookUp();
        }

        private void CheckEnteredData()
        {
            if (allUsers.Where(el => el.Key == usersGridLookUpEdit.Text) == null) 
                throw new BaseParameterException("Choose user", "Wrong value");
        }

        private void SendDeleteUserUrl()
        {

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

        private Dictionary<string, string> GetlAllUsers(string json)
        {
            Dictionary<string, string> users = new Dictionary<string, string>();

            List<UserGetDTO> usersDTO = JsonConvert.DeserializeObject<List<UserGetDTO>>(json);

            foreach(UserGetDTO userDTO in usersDTO) 
            {
                users.Add(userDTO.UserName, userDTO.Role);
            }

            return users;
        }

        private void FillLookUp()
        {
            //there is a place where i am supposed to fill my dictionary data in lookup
        }
    }
}
