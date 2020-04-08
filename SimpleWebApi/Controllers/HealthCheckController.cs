using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace SimpleWebApi.Controllers
{
    public class HealthCheckController:ApiController
    {
        [HttpGet]
        public IHttpActionResult HealthCheck()
        {
            return Ok<string>("Endpoint is working");
        }
    }
}