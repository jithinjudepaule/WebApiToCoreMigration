using SimpleWebApi.Models;
using SimpleWebApi.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace SimpleWebApi.Controllers
{
    public class HomeController:ApiController
    {
        
        public WebApiResponse GetDetails(string id)
        {
            return SimpleWebApiService.GetResponse(id);
        }
       
    }
}