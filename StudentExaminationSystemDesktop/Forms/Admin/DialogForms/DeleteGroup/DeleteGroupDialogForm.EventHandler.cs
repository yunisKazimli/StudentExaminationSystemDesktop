using AspConnectionManagement;
using DevExpress.Pdf.Native.BouncyCastle.Asn1.Cms;
using DevExpress.XtraEditors;
using Entities.DTOs.Examination.GetDTOs;
using Newtonsoft.Json;
using StudentExaminationSystemDesktop.Exceptions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentExaminationSystemDesktop.Forms.Admin.DialogForms.DeleteGroup
{
    public partial class DeleteGroupDialogForm
    {
        private async void FillLookUp()
        {
            string jsonData = await SendGetAllGroupsUrl();

            SetDataToLookUp(jsonData);
        }

        private void CheckEnteredValues()
        {
            if (groupsLookUpEdit.EditValue == null) throw new BaseException("Choose group", "Empty field");
        }

        private async void SendDeleteGroupUrl()
        {
            try
            {
                using (UrlBuilder urlBuilder = new UrlBuilder())
                {
                    UrlParameterContainer parameters = new UrlParameterContainer();

                    parameters.AddParameter("groupId", (Guid)groupsLookUpEdit.EditValue, false);

                    urlBuilder.UrlStartPart = "https://localhost:7199/";

                    urlBuilder.UrlAction = "deletegroupbyid";

                    urlBuilder.Token = _token;

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

        private async Task<string> SendGetAllGroupsUrl()
        {
            try
            {
                using (UrlBuilder urlBuilder = new UrlBuilder())
                {
                    urlBuilder.UrlStartPart = "https://localhost:7199/";

                    urlBuilder.UrlAction = "getallgroups";

                    urlBuilder.Token = _token;

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

        private void SetDataToLookUp(string jsonData)
        {
            List<GroupGetDTO> groups = JsonConvert.DeserializeObject<List<GroupGetDTO>>(jsonData);

            groupsLookUpEdit.Properties.DataSource = ConvertJsonToDt(groups);

            groupsLookUpEdit.Properties.ValueMember = "Group Id";
            groupsLookUpEdit.Properties.DisplayMember = "Group Name";
        }

        private DataTable ConvertJsonToDt(List<GroupGetDTO> groups)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Group Id", typeof(Guid));
            dt.Columns.Add("Group Name", typeof(string));
            dt.Columns.Add("Instructor Name", typeof(string));
            dt.Columns.Add("Student count", typeof(int));

            foreach(GroupGetDTO group in groups)
            {
                string instructorName;

                if (group.Instructor != null) instructorName = group.Instructor.UserName;
                else instructorName = "N/A";

                dt.Rows.Add(group.GroupId, group.GroupName, instructorName, group.Students.Count);
            }

            return dt;
        }
    }
}
