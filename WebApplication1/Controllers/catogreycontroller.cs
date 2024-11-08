using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class catogreycontroller : ControllerBase
    {
      public static  List<Catogrey> listCategories = new List<Catogrey>
        {
        new Catogrey { Id = 1, Name = "Lenovo", displayorder = 1 },
        new Catogrey { Id = 2, Name = "HP", displayorder = 2 },
        new Catogrey { Id = 3, Name = "Dell", displayorder = 3 },
    };
        [HttpGet]
        public IEnumerable<Catogrey> Get()
        {
            return listCategories;
        }
        [HttpPost]
        public void post([FromBody]Catogrey cat)
        {
            listCategories.Add(cat);
        }
    }
}
