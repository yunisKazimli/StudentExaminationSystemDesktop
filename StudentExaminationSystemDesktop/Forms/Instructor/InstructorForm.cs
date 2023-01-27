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

namespace StudentExaminationSystemDesktop.Forms.Instructor
{
    public partial class InstructorForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private MainForm _mainForm;
        private string _token;

        public InstructorForm(MainForm mainForm, string token)
        {
            _mainForm = mainForm;
            _token = token;

            InitializeComponent();

            subFormCtrl = new Controllers.SubFormController(_mainForm, subFormPanelControl);
        }

        private void groupsBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowGroups();
        }

        private void logoutBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            Logout();
        }

        private void showQuestionsBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowQuestions();
        }

        private void addQuestionBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddQuestion();
        }

        private void deleteQuestionBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            DeleteQuestion();
        }
    }
}