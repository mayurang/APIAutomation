using APIAutomation.API;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace APIAutomation.Utility
{
    public class RESTUtility
    {



        public string GetAPIGetMethodResponse(string preUrl)
        {

            string result;
            using (var client = new WebClient())
            {
                client.Headers.Add("Content-Type", "application/json");
                //client.Headers.Add("X-Mobius-Version", versionNumber);
                client.Credentials = CredentialCache.DefaultCredentials;
                result = client.DownloadString(preUrl);
            }
            return result;
        }


        public string GetAPIPOSTMethodResponse(string url, string contentType, string methodType, string body)
        {

            string result;
            using (var client = new WebClient())
            {
                client.Headers[HttpRequestHeader.ContentType] = contentType;
                result = client.UploadString(url, methodType, body);
            }
            return result;
        }

        public CountryStates CountryStatesResult(string response)
        {
            var deserializedItem = JsonConvert.DeserializeObject<CountryStates>(response);
            return deserializedItem;
        }
    }
    }
