using Newtonsoft.Json;
using SimpleWebApiCore.Models;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace SimpleWebApiCore.Service
{
    public class SimpleWebApiService
    {
        
        public async static Task<WebApiResponse> GetResponse(string id)
        {

            var deserializedresponse = new WebApiResponse();
               
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://jsonplaceholder.typicode.com/todos/"+id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                     deserializedresponse = JsonConvert.DeserializeObject<WebApiResponse>(apiResponse);
                }
            }
            return deserializedresponse;


           
        }
        }
    }
