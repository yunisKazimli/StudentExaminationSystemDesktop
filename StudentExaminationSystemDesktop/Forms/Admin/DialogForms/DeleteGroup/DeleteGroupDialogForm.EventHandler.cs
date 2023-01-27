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
            SetDataToLookUp();
        }

        private void CheckEnteredValues()
        {
            if (groupsLookUpEdit.EditValue == null) throw new BaseException("Choose group", "Empty field");
        }

        private async void SendUrl()
        {
            UrlManager.UrlSender.SendDeleteGroupUrl(_token, (Guid)groupsLookUpEdit.EditValue);
        }

        private async void SetDataToLookUp()
        {
            groupsLookUpEdit.Properties.DataSource = ConvertJsonToDt(await DataManager.DataGetter.GetGroups(_token));

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
