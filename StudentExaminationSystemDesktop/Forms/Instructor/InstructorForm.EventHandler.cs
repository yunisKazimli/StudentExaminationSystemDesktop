using StudentExaminationSystemDesktop.Forms.Controllers;
using StudentExaminationSystemDesktop.Forms.Instructor.DialogForms.AddQuestion;
using StudentExaminationSystemDesktop.Forms.Instructor.DialogForms.DeleteQuestion;
using StudentExaminationSystemDesktop.Forms.Instructor.SubForms.Groups;
using StudentExaminationSystemDesktop.Forms.Instructor.SubForms.Questions;
using StudentExaminationSystemDesktop.Forms.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentExaminationSystemDesktop.Forms.Instructor
{
    public partial class InstructorForm
    {
        private SubFormController subFormCtrl;

        private void ShowGroups()
        {
            subFormCtrl.OpenForm(new GroupsShowForm(_token));
        }

        private void Logout()
        {
            _mainForm.OpenForm(new EntranceForm(_mainForm));
        }

        private void ShowQuestions()
        {
            subFormCtrl.OpenForm(new QuestionShowForm(_token));
        }

        private void AddQuestion()
        {
            AddQuestionDialogForm addQuestionDialogForm = new AddQuestionDialogForm(_token);

            if (addQuestionDialogForm.ShowDialog() == DialogResult.OK) subFormCtrl.OpenForm(new QuestionShowForm(_token));
        }

        private void DeleteQuestion()
        {
            DeleteQuestionDialogForm deleteQuestionDialogForm = new DeleteQuestionDialogForm(_token);

            if (deleteQuestionDialogForm.ShowDialog() == DialogResult.OK) subFormCtrl.OpenForm(new QuestionShowForm(_token));
        }
    }
}
