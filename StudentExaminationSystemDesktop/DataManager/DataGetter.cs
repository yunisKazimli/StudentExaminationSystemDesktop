using Entities.DTOs.Examination.GetDTOs;
using Entities.DTOs.Identity.GetDTOs;
using Newtonsoft.Json;
using StudentExaminationSystemDesktop.UrlManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentExaminationSystemDesktop.DataManager
{
    public static class DataGetter
    {
        public static async Task<List<GroupGetDTO>> GetGroups(string token)
        {
            string json = await UrlSender.SendGetAllGroupsUrl(token);

            return JsonConvert.DeserializeObject<List<GroupGetDTO>>(json);
        }

        public static async Task<List<UserGetDTO>> GetUsers(string token)
        {
            string json = await UrlSender.SendGetAllUsersUrl(token);

            return JsonConvert.DeserializeObject<List<UserGetDTO>>(json);
        }
    }
}
