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
        private async void FillDataInLookUp()
        {
            DataTable dt = new DataTable();

            List<UserGetDTO> users = await DataManager.DataGetter.GetUsers(_token);

            dt.Columns.Add("User Id", typeof(Guid));
            dt.Columns.Add("User Name", typeof(string));
            dt.Columns.Add("User Role", typeof(string));

            foreach (UserGetDTO el in users) dt.Rows.Add(el.UserId, el.UserName, el.Role);

            usersLookUpEdit.Properties.DataSource = dt;

            usersLookUpEdit.Properties.DisplayMember = "User Name";
            usersLookUpEdit.Properties.ValueMember = "User Id";
        }

        private void CheckEnteredData()
        {
            if (usersLookUpEdit.EditValue == null) throw new BaseParameterException("Choose user", "Wrong value");
        }

        private async void SendUrl()
        {
            UrlManager.UrlSender.SendDeleteUserByIdUrl(_token, (Guid)usersLookUpEdit.EditValue);
        }
    }
}
