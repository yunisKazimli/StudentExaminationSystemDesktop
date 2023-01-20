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

namespace StudentExaminationSystemDesktop.Forms.Admin.SubForms
{
    public partial class ShowUsersForm : DevExpress.XtraEditors.XtraForm
    {
        private string _token;
        public ShowUsersForm(string token)
        {
            _token = token;

            InitializeComponent();

            GridRefresh();
        }
    }
}