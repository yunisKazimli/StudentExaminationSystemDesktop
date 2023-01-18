using AspConnectionManagement;
using DevExpress.XtraEditors;
using StudentExaminationSystemDesktop.Admin;
using StudentExaminationSystemDesktop.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentExaminationSystemDesktop.Login
{
    public partial class EntranceForm
    {
        private MainForm _mainForm;

        private void CheckInputParameter()
        {
            if (userNameTextEdit.Text == null || userNameTextEdit.Text == "")
                throw new BaseParameterException("Input 'UserName' field", "Empty field error");

            if (passwordTextEdit.Text == null || passwordTextEdit.Text == "")
                throw new BaseParameterException("Input 'Password' field", "Empty field error");
        }

        private async void SendUrl()
        {
            try
            {
                using (UrlBuilder urlBuilder = new UrlBuilder())
                {
                    UrlParameterContainer parameters = new UrlParameterContainer();

                    parameters.AddParameter("data", new { Username = userNameTextEdit.Text, Password = passwordTextEdit.Text }, false);

                    urlBuilder.UrlStartPart = "https://localhost:7199/";

                    urlBuilder.UrlAction = "login";

                    urlBuilder.Token = "";

                    urlBuilder.Method = HttpRequestTypeEnum.Post;

                    urlBuilder.Parameters = parameters;

                    urlBuilder.GenerateUrl();

                    string data = await urlBuilder.SubmitRequestAsync();

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
                                break;
                            }
                        case "Student":
                            {
                                break;
                            }
                    }
                }
            }
            catch(BaseException be)
            {
                XtraMessageBox.Show(be.Message, be.Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            catch (Exception be)
            {
                XtraMessageBox.Show(be.Message, "Unexpected exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
        }
    }
}
