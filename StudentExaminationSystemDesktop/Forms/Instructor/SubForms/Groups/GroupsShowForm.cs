using DevExpress.XtraEditors;
using StudentExaminationSystemDesktop.Forms.Instructor.DialogForms.ShowAnswers;
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

        private async void usersGridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            new ShowAnswersDialogForm(
                await DataManager.DataGetter.GetStudentAnswers
                (
                    _token, 
                    (Guid)groupsGridView.GetFocusedDataRow()["Group Id"], 
                    (Guid)usersGridView.GetFocusedDataRow()["User Id"]
                ),
                await DataManager.DataGetter.GetQuestions
                (
                    _token, 
                    (Guid)groupsGridView.GetFocusedDataRow()["Group Id"]
                )
            ).ShowDialog();
        }
    }
}