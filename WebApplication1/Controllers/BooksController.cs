using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly ApplicationDbContext _Context;
        public BooksController(ApplicationDbContext Context)
        {

            _Context = Context;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] book books)
        {
            await _Context.Books.AddAsync(books);
            await _Context.SaveChangesAsync();
            return StatusCode(StatusCodes.Status201Created);
        }
        [HttpGet]
        public async Task<IActionResult> GetWriters()
        {
            var writers = await (from writer in _Context.BookWriters
                                 select new
                                 {
                                     ID = writer.Id,
                                     Name = writer.Name,
                                 }).ToListAsync();

            return Ok(writers);


        }

        [HttpGet("[Action]")]
        public async Task<IActionResult> WritersDeatiles(int id)
        {
            var writer = await (_Context.BookWriters.Include(x => x.Books)
                .Where(x => x.Id == id)).FirstOrDefaultAsync();

            return Ok(writer);


        }
    }
}
