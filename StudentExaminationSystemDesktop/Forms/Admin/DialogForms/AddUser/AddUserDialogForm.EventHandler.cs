using AspConnectionManagement;
using DevExpress.XtraEditors;
using Entities.DTOs.Identity;
using Entities.DTOs.Identity.GetDTOs;
using Newtonsoft.Json;
using StudentExaminationSystemDesktop.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentExaminationSystemDesktop.Forms.Admin.DialogForms.AddUser
{
    public partial class AddUserDialogForm
    {
        private List<string> allUserNames;

        private Dictionary<string, Guid> roles;

        private async void GetNeccessaryData()
        {
            string usersJsonData = await UrlManager.UrlSender.SendGetAllUsersUrl(_token);

            string rolesJsonData = await UrlManager.UrlSender.SendGetAllRolesUrl(_token);

            allUserNames = GetUserNameStringList(usersJsonData);

            roles = GetAllRolesDictionary(rolesJsonData);

            foreach(KeyValuePair<string, Guid> el in roles)
            {
                roleComboBoxEdit.Properties.Items.Add(el.Key);
            }
        }

        private void CheckEnteredData()
        {
            if (userNameTextEdit.Text == null || userNameTextEdit.Text == "") throw new BaseParameterException("Fill userName field", "Empty field");
            if (passwordTextEdit.Text == null || passwordTextEdit.Text == "") throw new BaseParameterException("Fill password field", "Empty field");
            if (roleComboBoxEdit.Text == null || roleComboBoxEdit.Text == "") throw new BaseParameterException("Choose role", "Empty field");

            if(allUserNames.Find(el => el == userNameTextEdit.Text) != null) throw new BaseParameterException("user with this userName already registered", "Empty field");
        }

        private void SendUrl()
        {
            UrlManager.UrlSender.SendRegisterUrl(_token, new RegisterDTO() { Username = userNameTextEdit.Text, Password = passwordTextEdit.Text, PasswordConfirm = passwordTextEdit.Text, RoleId = roles[roleComboBoxEdit.Text].ToString() });
        }

        private List<string> GetUserNameStringList(string jsonData)
        {
            List<UserGetDTO> users = JsonConvert.DeserializeObject<List<UserGetDTO>>(jsonData);

            List<string> userNameList = new List<string>();

            userNameList = (from el in users select el.UserName).ToList();

            return userNameList;
        }

        private Dictionary<string, Guid> GetAllRolesDictionary(string jsonData)
        {
            Dictionary<string, Guid> allRoles = new Dictionary<string, Guid>();

            List<RoleGetDTO> roleGetDTO = JsonConvert.DeserializeObject<List<RoleGetDTO>>(jsonData);

            foreach (RoleGetDTO rgto in roleGetDTO) allRoles.Add(rgto.RoleName, rgto.RoleId);

            return allRoles;
        }
    }
}
