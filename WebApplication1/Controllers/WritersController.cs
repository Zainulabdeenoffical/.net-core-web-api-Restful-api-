using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

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
    }
}
