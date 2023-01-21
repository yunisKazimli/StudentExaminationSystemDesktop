using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentExaminationSystemDesktop.Forms.Admin
{
    public partial class AdminForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private MainForm _mainForm;

        private string _token;

        public AdminForm(MainForm mainForm, string token)
        {
            InitializeComponent();

            _mainForm = mainForm;
            _token = token;
        }

        private void logoutBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            Logout();
        }

        private void showUsersBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowUsers();
        }

        private void addUsersBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddUser();
        }

        private void deleteUsersBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            DeleteUser();
        }

        private void showGroupsBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowGroups();
        }

        private void addGroupsBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddGroup();
        }

        private void deleteGroupsBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            DeleteGroup();
        }

        private void addUserToGroupBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddUserToGroup();
        }

        private void deleteUserFromGroupBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            DeleteUserFromGroup();
        }
    }
}