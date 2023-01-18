using AspConnectionManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspConnectionManagement
{
    public static class UrlFilterBasedConverter
    {
        public static string ConvertToUrl(UrlParameterContainer urlParamContainer)
        {
            string url = "";

            Dictionary<string, object> parameters = urlParamContainer.GetParameterList();

            if (parameters.Count == 0) return "";

            foreach(KeyValuePair<string, object> el in parameters)
            {
                url += el.Key + "=" + FilterBasedUrlStandart(el.Value.ToString()) + "&";
            }

            url = url.Substring(0, url.Length - 1);

            return "?" + url;
        }

        private static string FilterBasedUrlStandart(string param)
        {
            string newStr = "";

            for (int i = 0; i < param.Length; i++)
            {
                string hex = Convert.ToInt32(param[i]).ToString("X");

                if (((int)param[i] < 65 || (int)param[i] > 90) &&
                    ((int)param[i] < 97 || (int)param[i] > 122) &&
                    ((int)param[i] < 48 || (int)param[i] > 57) &&
                    (int)param[i] != 45 &&
                    (int)param[i] != 56 &&
                    (int)param[i] != 95 &&
                    (int)param[i] != 126) newStr += "%" + hex;
                else newStr += param[i];
            }

            return newStr;
        }
    }
}
