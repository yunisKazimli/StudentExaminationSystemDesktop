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

namespace StudentExaminationSystemDesktop.Forms.Instructor.SubForms.Questions
{
    public partial class QuestionShowForm : DevExpress.XtraEditors.XtraForm
    {
        private string _token;

        public QuestionShowForm(string token)
        {
            _token = token;

            InitializeComponent();

            FillGroupsGrid();
        }

        private void groupsGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            FillQuestionGrid();
        }

        private void questionsGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            FillOptionGrid();
        }
    }
}