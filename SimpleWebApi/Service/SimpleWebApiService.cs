using SimpleWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace SimpleWebApi.Service
{
    public class SimpleWebApiService
    {
        public static WebApiResponse GetResponse(string id)
        {
            using (var client = new System.Net.Http.HttpClient())
            {
                client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/todos/");
                //HTTP GET
                var responseTask = client.GetAsync(id);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    var readTask = result.Content.ReadAsAsync<WebApiResponse>();
                    readTask.Wait();

                   return readTask.Result;
                }
                else
                {
                    return new WebApiResponse();
                }
            }
        }
    }
}