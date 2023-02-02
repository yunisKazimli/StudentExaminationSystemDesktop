﻿using Entities.DTOs.Examination.GetDTOs;
using Entities.DTOs.Identity.GetDTOs;
using Newtonsoft.Json;
using StudentExaminationSystemDesktop.UrlManager;
using System;
using System.Collections.Generic;
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

        public static async Task<List<QuestionGetDTO>> GetQuestions(string token, Guid data)
        {
            string json = await UrlSender.SendGetAllQuestionsUrl(token, data);

            return JsonConvert.DeserializeObject<List<QuestionGetDTO>>(json);
        }
    }
}
