using Microsoft.AspNetCore.Mvc;
using SimpleWebApiCore.Models;
using SimpleWebApiCore.Service;
using System.Threading.Tasks;

namespace SimpleWebApiCore.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController
    {
        [HttpGet("{id}")]
        public Task<WebApiResponse> GetDetails(string id)
        {
            return SimpleWebApiService.GetResponse(id);
        }
       
    }
}