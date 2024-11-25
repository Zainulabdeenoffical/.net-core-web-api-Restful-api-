using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;
using System.Linq;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WritersController : ControllerBase

    {
        private readonly ApplicationDbContext _Context;
        public WritersController(ApplicationDbContext Context) {

            _Context = Context;
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] bookWriters writers)
        {
            await _Context.BookWriters.AddAsync(writers);
            await _Context.SaveChangesAsync();
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpGet]
        public async Task <IActionResult> GetWriters(int? pageNumber, int? pageSize)
        {
            int currentpageNumber = pageNumber ?? 0;
            int currentpageSize = pageSize ?? 5;
            var writers = await (from writer in _Context.BookWriters
                                select new
            {
                ID = writer.Id,
                Name = writer.Name,
            }).ToListAsync();

            return Ok (writers.Skip((currentpageNumber - 1) * currentpageSize).Take(currentpageSize));

            
        }

        [HttpGet("[Action]")]
        public async Task<IActionResult> WritersDeatiles(int id)
        {
            var writer = await (_Context.BookWriters.Include(x=>x.Books)
                .Where(x=>x.Id==id)).FirstOrDefaultAsync();

            return Ok(writer);


        }
    }
}
