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

namespace StudentExaminationSystemDesktop.Forms.Instructor.DialogForms.AddQuestion
{
    public partial class AddQuestionDialogForm : DevExpress.XtraEditors.XtraForm
    {
        private string _token;

        public AddQuestionDialogForm(string token)
        {
            _token = token;

            InitializeComponent();
        }
    }
}