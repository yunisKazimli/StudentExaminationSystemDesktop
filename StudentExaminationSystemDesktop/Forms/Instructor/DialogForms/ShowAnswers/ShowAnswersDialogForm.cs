using DevExpress.XtraEditors;
using Entities.DTOs.Examination.GetDTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentExaminationSystemDesktop.Forms.Instructor.DialogForms.ShowAnswers
{
    public partial class ShowAnswersDialogForm : DevExpress.XtraEditors.XtraForm
    {
        private List<StudentAnswerGetDTO> _allAnswers;
        private List<QuestionGetDTO> _allQuestions;

        public ShowAnswersDialogForm(List<StudentAnswerGetDTO> allAnswers, List<QuestionGetDTO> allQuestions)
        {
            _allAnswers = allAnswers;
            _allQuestions = allQuestions;

            InitializeComponent();

            ShowAnswers();
        }

        private void answersGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            RefreshOptionsGrid();
        }
    }
}