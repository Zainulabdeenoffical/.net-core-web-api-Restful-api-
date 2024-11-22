using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    }
}
