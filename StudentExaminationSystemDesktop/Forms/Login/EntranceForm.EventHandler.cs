using AspConnectionManagement;
using DevExpress.XtraEditors;
using StudentExaminationSystemDesktop.Forms.Admin;
using StudentExaminationSystemDesktop.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities.DTOs.Identity;
using StudentExaminationSystemDesktop.Forms.Instructor;

namespace StudentExaminationSystemDesktop.Forms.Login
{
    public partial class EntranceForm
    {
        private MainForm _mainForm;

        private void Login()
        {
            try
            {
                CheckInputParameter();
            }
            catch (BaseException be)
            {
                XtraMessageBox.Show(be.Message, be.Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            SendUrl();
        }

        private void CheckInputParameter()
        {
            if (userNameTextEdit.Text == null || userNameTextEdit.Text == "")
                throw new BaseParameterException("Input 'UserName' field", "Empty field error");

            if (passwordTextEdit.Text == null || passwordTextEdit.Text == "")
                throw new BaseParameterException("Input 'Password' field", "Empty field error");
        }

        private async void SendUrl()
        {
            string data = await UrlManager.UrlSender.SendLoginUrl(new LoginDTO() { Username = userNameTextEdit.Text, Password = passwordTextEdit.Text });

            string token = data.Split(' ')[1];

            string role = data.Split(' ')[0];

            switch (role)
            {
                case "Admin":
                    {
                        _mainForm.OpenForm(new AdminForm(_mainForm, token));
                        break;
                    }
                case "Instructor":
                    {
                        _mainForm.OpenForm(new InstructorForm(_mainForm, token));
                        break;
                    }
                case "Student":
                    {
                        break;
                    }
            }
        }
    }
}
