using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentExaminationSystemDesktop.Forms.Admin.SubForms
{
    public partial class ShowGroupsForm : DevExpress.XtraEditors.XtraForm
    {
        private string _token;

        public ShowGroupsForm(string token)
        {
            _token = token;

            InitializeComponent();

            RefreshGroupsGrid();
        }

        private void groupsGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            RefreshUsersGrid();
        }
    }
}