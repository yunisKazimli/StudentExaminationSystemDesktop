using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentExaminationSystemDesktop.Forms.Instructor.SubForms.Groups
{
    public partial class GroupsShowForm : DevExpress.XtraEditors.XtraForm
    {
        private string _token;

        public GroupsShowForm(string token)
        {
            _token = token;

            InitializeComponent();

            RefreshGroupGrid();
        }

        private void groupsGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            RefreshUsersGrid();
        }
    }
}