using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class dbCatogreyController : ControllerBase
    {
        // GET: api/<dbCatogreyController>
        private readonly ApplicationDbContext _context;

        public dbCatogreyController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Catogrey> Get()
        {
            return _context.catogreys;
        }

        // GET api/<dbCatogreyController>/5
        [HttpGet("{id}")]
        public Catogrey Get(int id)
        {
            return  _context.catogreys.FirstOrDefault(x=>x.Id==id);
        }

        // POST api/<dbCatogreyController>
        [HttpPost]
        public void Post([FromBody] Catogrey Catogrey)
        {
            _context.catogreys.Add(Catogrey);
            _context.SaveChanges();
        }

        // PUT api/<dbCatogreyController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Catogrey catogrey)
        {
            var catogreyfromDb = _context.catogreys.Find(id);
            _context.catogreys.Update(catogreyfromDb);
            _context.SaveChanges();

        }

        // DELETE api/<dbCatogreyController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var catogreyfromDb = _context.catogreys.Find(id);
            _context.catogreys.Remove(catogreyfromDb);
            _context.SaveChanges();

        }
    }
}
