using StudentExaminationSystemDesktop.Forms.Admin.DialogForms.AddGroup;
using StudentExaminationSystemDesktop.Forms.Admin.DialogForms.AddUser;
using StudentExaminationSystemDesktop.Forms.Admin.DialogForms.AddUserToGroup;
using StudentExaminationSystemDesktop.Forms.Admin.DialogForms.DeleteGroup;
using StudentExaminationSystemDesktop.Forms.Admin.DialogForms.DeleteUser;
using StudentExaminationSystemDesktop.Forms.Admin.DialogForms.DeleteUserFromGroup;
using StudentExaminationSystemDesktop.Forms.Admin.SubForms;
using StudentExaminationSystemDesktop.Forms.Controllers;
using StudentExaminationSystemDesktop.Forms.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentExaminationSystemDesktop.Forms.Admin
{
    public partial class AdminForm
    {
        private SubFormController subFormCtrl;

        private void Logout()
        {
            _mainForm.OpenForm(new EntranceForm(_mainForm));
        }

        private void ShowUsers()
        {
            subFormCtrl.OpenForm(new ShowUsersForm(_token));
        }

        private void AddUser()
        {
            AddUserDialogForm addUserDialogForm = new AddUserDialogForm(_token);

            if (addUserDialogForm.ShowDialog() == DialogResult.OK) subFormCtrl.OpenForm(new ShowUsersForm(_token));
        }

        private void DeleteUser()
        {
            DeleteUserDialogForm deleteUserDialogForm = new DeleteUserDialogForm(_token);

            if (deleteUserDialogForm.ShowDialog() == DialogResult.OK) subFormCtrl.OpenForm(new ShowUsersForm(_token));
        }

        private void AddGroup()
        {
            AddGroupDialogForm addGroupDialogForm = new AddGroupDialogForm(_token);

            if (addGroupDialogForm.ShowDialog() == DialogResult.OK) subFormCtrl.OpenForm(new ShowGroupsForm(_token));
        }

        private void DeleteGroup()
        {
            DeleteGroupDialogForm deleteGroupDialogForm = new DeleteGroupDialogForm(_token);

            if (deleteGroupDialogForm.ShowDialog() == DialogResult.OK) subFormCtrl.OpenForm(new ShowGroupsForm(_token));
        }

        private void AddUserToGroup()
        {
            AddUserToGroupDialogForm addUserToGroupDialogForm = new AddUserToGroupDialogForm(_token);

            if (addUserToGroupDialogForm.ShowDialog() == DialogResult.OK) subFormCtrl.OpenForm(new ShowGroupsForm(_token));
        }

        private void DeleteUserFromGroup()
        {
            DeleteUserFromGroupDialogForm deleteUserToGroupDialogForm = new DeleteUserFromGroupDialogForm(_token);

            if (deleteUserToGroupDialogForm.ShowDialog() == DialogResult.OK) subFormCtrl.OpenForm(new ShowGroupsForm(_token));
        }

        private void ShowGroups()
        {
            subFormCtrl.OpenForm(new ShowGroupsForm(_token));
        }
    }
}
