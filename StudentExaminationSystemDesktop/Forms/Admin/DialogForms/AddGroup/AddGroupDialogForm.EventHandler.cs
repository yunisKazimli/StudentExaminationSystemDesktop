using AspConnectionManagement;
using DevExpress.Office.Utils;
using DevExpress.XtraEditors;
using Entities.DTOs.Examination;
using Entities.DTOs.Examination.GetDTOs;
using Entities.DTOs.Identity;
using Newtonsoft.Json;
using StudentExaminationSystemDesktop.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentExaminationSystemDesktop.Forms.Admin.DialogForms.AddGroup
{
    public partial class AddGroupDialogForm
    {
		private List<string> allGroupsName;

		private async void GetNecessaryData()
        {
			string jsonData = await UrlManager.UrlSender.SendGetAllGroupsUrl(_token);

			FillAllgroupsName(jsonData);
		}

		private void CheckEnteredData()
		{
			if (groupTextEdit.Text == null || groupTextEdit.Text == "") throw new BaseException("Enter group name", "Empty field");

			if (allGroupsName.Where(el => el == groupTextEdit.Text).Count() != 0)
				throw new BaseException("Group with this name already havs been created", "Empty field");
		}

		private void SendUrl()
		{
			UrlManager.UrlSender.SendAddGroupUrl(_token, new GroupDTO() { GroupName = groupTextEdit.Text });
		}

		private void FillAllgroupsName(string jsonData)
		{
			List<GroupGetDTO> groups = JsonConvert.DeserializeObject<List<GroupGetDTO>>(jsonData);

			allGroupsName =
				(
					from el
					in groups
					select el.GroupName
				).ToList();
		}
	}
}
