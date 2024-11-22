using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoverController : ControllerBase
    {
        private readonly ApplicationDbContext _Context;
        public CoverController(ApplicationDbContext Context)
        {

            _Context = Context;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] bookCover cover)
        {
            await _Context.BookCOvers.AddAsync(cover);
            await _Context.SaveChangesAsync();
            return StatusCode(StatusCodes.Status201Created);
        }
    }
}
