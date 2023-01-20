using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.DataProcessing.InMemoryDataProcessor;
using DevExpress.XtraRichEdit.Import.Html;
using Newtonsoft.Json;
using StudentExaminationSystemDesktop.Exceptions;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace AspConnectionManagement
{
    public class UrlBuilder : IDisposable
    {
        /// <summary>
        /// All parameters for url get(in url) and post(in body)
        /// If method is Get then just add all parameters and names
        /// If method is Post then create object type value with name "data" that include all neccessary datain asp side 
        /// </summary>
        public UrlParameterContainer Parameters { get; set; }

        /// <summary>
        /// For example:  https://port:0000/
        /// </summary>
        public string UrlStartPart { get; set; }

        /// <summary>
        /// Using action name 
        /// For example : AddElement
        /// </summary>
        public string UrlAction { get; set; }

        /// <summary>
        /// Assign it if request not allow anonymus
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// Url method type
        /// </summary>
        public HttpRequestTypeEnum Method { get; set; }

        /// <summary>
        /// Final Url string
        /// </summary>
        public string FullUrl { get; private set; }

        /// <summary>
        /// Generate full url
        /// It is neccessary to call this method after setting all property
        /// </summary>
        public void GenerateUrl()
        {
            if (Method == HttpRequestTypeEnum.Get) FullUrl = UrlStartPart + UrlAction + UrlFilterBasedConverter.ConvertToUrl(Parameters);

            else FullUrl = UrlStartPart + UrlAction;
        }

        /// <summary>
        /// Submit Get method with generated url
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<string> SubmitRequestAsync()
        {
            switch(Method)
            {
                case HttpRequestTypeEnum.Get:
                    return await SubmitGetRequestAsync();
                case HttpRequestTypeEnum.Post:
                    return await SubmitPostRequestAsync();
                default:
                    return null;
            }
        }
        
        private async Task<string> SubmitGetRequestAsync()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Token);

                    var response = await client.GetAsync(FullUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        return await response.Content.ReadAsStringAsync();
                    }
                    else
                    {
                        throw new Exception("Http response error status : " + response.StatusCode + "\n" + response.ReasonPhrase);
                    }
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private async Task<string> SubmitPostRequestAsync()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Token);

                    string jsonData = JsonConvert.SerializeObject(Parameters.GetParameterList()["data"]);

                    FormUrlEncodedContent content =
                        new FormUrlEncodedContent
                        (
                            new[]
                            {
                            new KeyValuePair<string, string>("jsonData", jsonData)
                            }
                        );

                    var response = await client.PostAsync(FullUrl, content);

                    if (response.IsSuccessStatusCode)
                    {
                        return await response.Content.ReadAsStringAsync();
                    }
                    else
                    {
                        throw new Exception("Http response error status : " + response.StatusCode + "\n" + response.ReasonPhrase);
                    }
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Dispose()
        {
        }
    }
}
