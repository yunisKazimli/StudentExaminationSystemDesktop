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
			string jsonData = await SendGetAllGroupsUrl();

			FillAllgroupsName(jsonData);
		}

		private void CheckEnteredData()
		{
			if (groupTextEdit.Text == null || groupTextEdit.Text == "") throw new BaseException("Enter group name", "Empty field");

			if (allGroupsName.Where(el => el == groupTextEdit.Text).Count() != 0)
				throw new BaseException("Group with this name already havs been created", "Empty field");
		}

		private async void SendAddGroupUrl()
		{
			try
			{
				using (UrlBuilder urlBuilder = new UrlBuilder())
				{
					UrlParameterContainer parameters = new UrlParameterContainer();

					parameters.AddParameter("data", new GroupDTO() { GroupName = groupTextEdit.Text }, false);

					urlBuilder.UrlStartPart = "https://localhost:7199/";

					urlBuilder.UrlAction = "addgroup";

					urlBuilder.Token = _token;

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
