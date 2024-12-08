using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiVersion("2.0")]
  //  [Route("api/v{version:apiversion}/home")]
    [Route("api/home")]
    [ApiController]
    public class apiVersioningController : ControllerBase
    {
        // Version 1.0 in HomeCOntroller
        static List<bookWriters> bookWriters = new List<bookWriters>()
        {
            new bookWriters()
            {
                Id = 1,
                Name = "Zain",
               
            },
             new bookWriters()
            {
                Id = 2,
                Name = "Zaid",
               
            }
        };
        [HttpGet]
        public IEnumerable<bookWriters> Get()
        {
            return bookWriters;
        }
    };
}

