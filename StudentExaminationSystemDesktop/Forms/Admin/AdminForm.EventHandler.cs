using StudentExaminationSystemDesktop.Forms.Admin.DialogForms.AddUser;
using StudentExaminationSystemDesktop.Forms.Admin.DialogForms.DeleteUser;
using StudentExaminationSystemDesktop.Forms.Admin.SubForms;
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
        private Form subForm;

        private void Logout()
        {
            _mainForm.OpenForm(new EntranceForm(_mainForm));
        }

        private void ShowUsers()
        {
            if (subForm != null) subForm.Close();

            OpenForm(new ShowUsersForm(_token));
        }

        private void AddUser()
        {
            AddUserDialogForm addUserDialogForm = new AddUserDialogForm(_token);

            addUserDialogForm.ShowDialog();

            if (subForm != null) ShowUsers();
        }

        private void DeleteUser()
        {
            DeleteUserDialogForm deleteUserDialogForm = new DeleteUserDialogForm(_token);

            deleteUserDialogForm.ShowDialog();

            if (subForm != null) ShowUsers();
        }

        private void OpenForm(Form newSubForm)
        {
            if (subForm != null) subForm.Close();

            subForm = newSubForm;

            subForm.MdiParent = MdiParent;

            subForm.Dock = DockStyle.Fill;

            subForm.TopLevel = false;

            subForm.TopMost = true;

            subForm.FormBorderStyle = FormBorderStyle.None;

            subForm.Show();

            subFormPanelControl.Controls.Add(subForm);
        }
    }
}
