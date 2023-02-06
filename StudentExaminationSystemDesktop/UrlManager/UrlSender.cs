using AspConnectionManagement;
using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.XtraEditors;
using Entities.DTOs.Examination;
using Entities.DTOs.Identity;
using StudentExaminationSystemDesktop.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentExaminationSystemDesktop.UrlManager
{
    public static class UrlSender
    {
        public static async Task<string> SendGetAllGroupsUrl(string token)
        {
            try
            {
                using (UrlBuilder urlBuilder = new UrlBuilder())
                {
                    urlBuilder.UrlStartPart = "https://localhost:7199/";

                    urlBuilder.UrlAction = "getallgroups";

                    urlBuilder.Token = token;

                    urlBuilder.Method = HttpRequestTypeEnum.Get;

                    urlBuilder.GenerateUrl();

                    return await urlBuilder.SubmitRequestAsync();
                }
            }
            catch (BaseException be)
            {
                XtraMessageBox.Show(be.Message, be.Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }
            catch (Exception be)
            {
                XtraMessageBox.Show(be.Message, "Unexpected exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }
        }

        public static async Task<string> SendGetAllUsersUrl(string token)
        {
            try
            {
                using (UrlBuilder urlBuilder = new UrlBuilder())
                {
                    urlBuilder.UrlStartPart = "https://localhost:7199/";

                    urlBuilder.UrlAction = "getallusers";

                    urlBuilder.Token = token;

                    urlBuilder.Method = HttpRequestTypeEnum.Get;

                    urlBuilder.GenerateUrl();

                    return await urlBuilder.SubmitRequestAsync();
                }
            }
            catch (BaseException be)
            {
                XtraMessageBox.Show(be.Message, be.Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }
            catch (Exception be)
            {
                XtraMessageBox.Show(be.Message, "Unexpected exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }
        }

        public static async Task<string> SendGetAllRolesUrl(string token)
        {
            try
            {
                using (UrlBuilder urlBuilder = new UrlBuilder())
                {
                    urlBuilder.UrlStartPart = "https://localhost:7199/";

                    urlBuilder.UrlAction = "getallroles";

                    urlBuilder.Token = token;

                    urlBuilder.Method = HttpRequestTypeEnum.Get;

                    urlBuilder.GenerateUrl();

                    return await urlBuilder.SubmitRequestAsync();
                }
            }
            catch (BaseException be)
            {
                XtraMessageBox.Show(be.Message, be.Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }
            catch (Exception be)
            {
                XtraMessageBox.Show(be.Message, "Unexpected exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }
        }

        public static async Task<string> SendGetAllQuestionsUrl(string token, Guid data)
        {
            try
            {
                using (UrlBuilder urlBuilder = new UrlBuilder())
                {
                    UrlParameterContainer parameters = new UrlParameterContainer();

                    parameters.AddParameter("GroupId", data, false);

                    urlBuilder.UrlStartPart = "https://localhost:7199/";

                    urlBuilder.UrlAction = "getallquestions";

                    urlBuilder.Token = token;

                    urlBuilder.Method = HttpRequestTypeEnum.Get;

                    urlBuilder.Parameters = parameters;

                    urlBuilder.GenerateUrl();

                    return await urlBuilder.SubmitRequestAsync();
                }
            }
            catch (BaseException be)
            {
                XtraMessageBox.Show(be.Message, be.Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }
            catch (Exception be)
            {
                XtraMessageBox.Show(be.Message, "Unexpected exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }
        }

        public static async Task<string> SendGetAllAnswersUrl(string token, Guid data1, Guid data2)
        {
            try
            {
                using (UrlBuilder urlBuilder = new UrlBuilder())
                {
                    UrlParameterContainer parameters = new UrlParameterContainer();

                    parameters.AddParameter("GroupId", data1, false);
                    parameters.AddParameter("StudentId", data2, false);

                    urlBuilder.UrlStartPart = "https://localhost:7199/";

                    urlBuilder.UrlAction = "getallstudentanswers";

                    urlBuilder.Token = token;

                    urlBuilder.Method = HttpRequestTypeEnum.Get;

                    urlBuilder.Parameters = parameters;

                    urlBuilder.GenerateUrl();

                    return await urlBuilder.SubmitRequestAsync();
                }
            }
            catch (BaseException be)
            {
                XtraMessageBox.Show(be.Message, be.Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }
            catch (Exception be)
            {
                XtraMessageBox.Show(be.Message, "Unexpected exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }
        }

        public static async Task<string> SendLoginUrl(LoginDTO data)
        {
            try
            {
                using (UrlBuilder urlBuilder = new UrlBuilder())
                {
                    UrlParameterContainer parameters = new UrlParameterContainer();

                    parameters.AddParameter("data", data, false);

                    urlBuilder.UrlStartPart = "https://localhost:7199/";

                    urlBuilder.UrlAction = "login";

                    urlBuilder.Token = "";

                    urlBuilder.Method = HttpRequestTypeEnum.Post;

                    urlBuilder.Parameters = parameters;

                    urlBuilder.GenerateUrl();

                    return await urlBuilder.SubmitRequestAsync();
                }
            }
            catch (BaseException be)
            {
                XtraMessageBox.Show(be.Message, be.Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }
            catch (Exception be)
            {
                XtraMessageBox.Show(be.Message, "Unexpected exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }
        }

        public static async void SendAddGroupUrl(string token, GroupDTO data)
        {
            try
            {
                using (UrlBuilder urlBuilder = new UrlBuilder())
                {
                    UrlParameterContainer parameters = new UrlParameterContainer();

                    parameters.AddParameter("data", data, false);

                    urlBuilder.UrlStartPart = "https://localhost:7199/";

                    urlBuilder.UrlAction = "addgroup";

                    urlBuilder.Token = token;

                    urlBuilder.Method = HttpRequestTypeEnum.Post;

                    urlBuilder.Parameters = parameters;

                    urlBuilder.GenerateUrl();

                    await urlBuilder.SubmitRequestAsync();
                }
            }
            catch (BaseException be)
            {
                XtraMessageBox.Show(be.Message, be.Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception be)
            {
                XtraMessageBox.Show(be.Message, "Unexpected exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static async void SendRegisterUrl(string token, RegisterDTO data)
        {
            try
            {
                using (UrlBuilder urlBuilder = new UrlBuilder())
                {
                    UrlParameterContainer parameters = new UrlParameterContainer();

                    parameters.AddParameter("data", data, false);

                    urlBuilder.UrlStartPart = "https://localhost:7199/";

                    urlBuilder.UrlAction = "register";

                    urlBuilder.Token = token;

                    urlBuilder.Method = HttpRequestTypeEnum.Post;

                    urlBuilder.Parameters = parameters;

                    urlBuilder.GenerateUrl();

                    await urlBuilder.SubmitRequestAsync();
                }
            }
            catch (BaseException be)
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

        public static async void SendAddUserToGroupUrl(string token, UserToGroupDTO data)
        {
            try
            {
                using (UrlBuilder urlBuilder = new UrlBuilder())
                {
                    UrlParameterContainer parameters = new UrlParameterContainer();

                    parameters.AddParameter("data", data, false);

                    urlBuilder.UrlStartPart = "https://localhost:7199/";

                    urlBuilder.UrlAction = "addusertogroup";

                    urlBuilder.Token = token;

                    urlBuilder.Method = HttpRequestTypeEnum.Post;

                    urlBuilder.Parameters = parameters;

                    urlBuilder.GenerateUrl();

                    await urlBuilder.SubmitRequestAsync();
                }
            }
            catch (BaseException be)
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

        public static async void SendAddQuestionUrl(string token, List<QuestionDTO> data)
        {
            try
            {
                using (UrlBuilder urlBuilder = new UrlBuilder())
                {
                    UrlParameterContainer parameters = new UrlParameterContainer();

                    parameters.AddParameter("data", data, false);

                    urlBuilder.UrlStartPart = "https://localhost:7199/";

                    urlBuilder.UrlAction = "addquestions";

                    urlBuilder.Token = token;

                    urlBuilder.Method = HttpRequestTypeEnum.Post;

                    urlBuilder.Parameters = parameters;

                    urlBuilder.GenerateUrl();

                    await urlBuilder.SubmitRequestAsync();
                }
            }
            catch (BaseException be)
            {
                XtraMessageBox.Show(be.Message, be.Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception be)
            {
                XtraMessageBox.Show(be.Message, "Unexpected exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static async void SendAddStudentAnswersUrl(string token, StudentAnswerDTO data)
        {
            try
            {
                using (UrlBuilder urlBuilder = new UrlBuilder())
                {
                    UrlParameterContainer parameters = new UrlParameterContainer();

                    parameters.AddParameter("data", data, false);

                    urlBuilder.UrlStartPart = "https://localhost:7199/";

                    urlBuilder.UrlAction = "addstudentanswer";

                    urlBuilder.Token = token;

                    urlBuilder.Method = HttpRequestTypeEnum.Post;

                    urlBuilder.Parameters = parameters;

                    urlBuilder.GenerateUrl();

                    await urlBuilder.SubmitRequestAsync();
                }
            }
            catch (BaseException be)
            {
                XtraMessageBox.Show(be.Message, be.Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception be)
            {
                XtraMessageBox.Show(be.Message, "Unexpected exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static async void SendDeleteGroupUrl(string token, Guid data)
        {
            try
            {
                using (UrlBuilder urlBuilder = new UrlBuilder())
                {
                    UrlParameterContainer parameters = new UrlParameterContainer();

                    parameters.AddParameter("groupId", data, false);

                    urlBuilder.UrlStartPart = "https://localhost:7199/";

                    urlBuilder.UrlAction = "deletegroupbyid";

                    urlBuilder.Token = token;

                    urlBuilder.Method = HttpRequestTypeEnum.Get;

                    urlBuilder.Parameters = parameters;

                    urlBuilder.GenerateUrl();

                    await urlBuilder.SubmitRequestAsync();
                }
            }
            catch (BaseException be)
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

        public static async void SendDeleteUserByIdUrl(string token, Guid data)
        {
            try
            {
                using (UrlBuilder urlBuilder = new UrlBuilder())
                {
                    UrlParameterContainer parameters = new UrlParameterContainer();

                    parameters.AddParameter("userId", data, false);

                    urlBuilder.UrlStartPart = "https://localhost:7199/";

                    urlBuilder.UrlAction = "deleteUserById";

                    urlBuilder.Token = token;

                    urlBuilder.Method = HttpRequestTypeEnum.Get;

                    urlBuilder.Parameters = parameters;

                    urlBuilder.GenerateUrl();

                    await urlBuilder.SubmitRequestAsync();
                }
            }
            catch (BaseException be)
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

        public static async void SendDeleteUserFromGroupUrl(string token, Guid data1, Guid data2)
        {
            try
            {
                using (UrlBuilder urlBuilder = new UrlBuilder())
                {
                    UrlParameterContainer parameters = new UrlParameterContainer();

                    parameters.AddParameter("GroupId", data1, false);
                    parameters.AddParameter("UserId", data2, false);

                    urlBuilder.UrlStartPart = "https://localhost:7199/";

                    urlBuilder.UrlAction = "deleteuserfromgroup";

                    urlBuilder.Token = token;

                    urlBuilder.Method = HttpRequestTypeEnum.Get;

                    urlBuilder.Parameters = parameters;

                    urlBuilder.GenerateUrl();

                    await urlBuilder.SubmitRequestAsync();
                }
            }
            catch (BaseException be)
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

        public static async void SendDeleteQuestionUrl(string token, Guid data1, Guid data2)
        {
            try
            {
                using (UrlBuilder urlBuilder = new UrlBuilder())
                {
                    UrlParameterContainer parameters = new UrlParameterContainer();

                    parameters.AddParameter("GroupId", data1, false);
                    parameters.AddParameter("QuestionId", data2, false);

                    urlBuilder.UrlStartPart = "https://localhost:7199/";

                    urlBuilder.UrlAction = "deletequestion";

                    urlBuilder.Token = token;

                    urlBuilder.Method = HttpRequestTypeEnum.Get;

                    urlBuilder.Parameters = parameters;

                    urlBuilder.GenerateUrl();

                    await urlBuilder.SubmitRequestAsync();
                }
            }
            catch (BaseException be)
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
