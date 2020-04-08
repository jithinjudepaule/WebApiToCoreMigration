using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleWebApi.Models
{
    public class WebApiResponse
    {
        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("completed")]
        public string Completed { get; set; }
    }

}