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
        // for read
        [HttpGet]
        public IEnumerable<Catogrey> Get()
        {
            return listCategories;
        }
        // for add
        [HttpPost]
        public void post([FromBody]Catogrey cat)
        {
            listCategories.Add(cat);
        }
        // for edit
        // remember eidt by index number not id
        // pass index number in url not id number in url 

        [HttpPut ("{Id}")]
        public void put ( int Id,[FromBody] Catogrey cat)
        {
            listCategories[Id] = cat;
        }
        // for Delete
        // remember Delete by index number not id
        // pass index number in url not id number in url 

        

        [HttpDelete("{Id}")]
        public void Delete(int Id)
        {
            listCategories.RemoveAt(Id);
        }
    }
}
