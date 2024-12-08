using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiVersion("1.0")]
    // [Route("api/v{version:apiversion}/home")]
    [Route("api/home")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        static List<bookWriters> bookWriters = new List<bookWriters>()
        {
            new bookWriters()
            {
                Id = 1,
                Name = "Zain",
                Gender = "Male"
            },
             new bookWriters()
            {
                Id = 2,
                Name = "Zaid",
                Gender = "Male"
            }
        };
        [HttpGet]
        public IEnumerable<bookWriters> Get()
        {
            return bookWriters;
        }
    }
}
