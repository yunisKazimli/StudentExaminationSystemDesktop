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

namespace StudentExaminationSystemDesktop.Forms.Student
{
    public partial class StudentForm : DevExpress.XtraEditors.XtraForm
    {
        private string _token;
        private MainForm _mainForm;
        private Guid _studentId;

        public StudentForm(MainForm mainForm, string token, Guid studentId)
        {
            _token = token;
            _mainForm = mainForm;
            _studentId = studentId;

            InitializeComponent();

            GetNecessaryData();
        }

        private void logoutSimpleButton_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void groupLookUpEdit_Properties_EditValueChanged(object sender, EventArgs e)
        {
            RefreshQuestions();
        }

        private void saveSimpleButton_Click(object sender, EventArgs e)
        {
            SaveAnswers();
        }
    }
}