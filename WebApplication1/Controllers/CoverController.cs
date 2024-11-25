using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        [HttpGet]
        public async Task<IActionResult> GetCovers(int? pageNumber,int? pageSize)
        {
            int currentpageNumber = pageNumber ?? 0;
            int currentpageSize = pageSize ?? 5;
            var covers = await (from cover in _Context.BookCOvers
                                 select new
                                 {
                                     ID = cover.Id,
                                     Name = cover.Title,
                                     writerId = cover.bookWriterID,
                                 }).ToListAsync();

            return Ok(covers.Skip((currentpageNumber - 1) * currentpageSize).Take(currentpageSize));


        }

        [HttpGet("[Action]")]
        public async Task<IActionResult> coverDeatiles(int id)
        {
            var cover = await (_Context.BookCOvers.Include(x => x.Books)
                .Where(x => x.Id == id)).FirstOrDefaultAsync();

            return Ok(cover);


        }
    }
}
