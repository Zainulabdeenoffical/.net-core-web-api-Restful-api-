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
        public async Task<IActionResult> GetBooks(int? pageNumber, int? pageSize)
        {
            int currentpageNumber = pageNumber ?? 0;
            int currentpageSize = pageSize ?? 5;
            var books = await (from book in _Context.Books
                                 select new
                                 {
                                     ID = book.Id,
                                     Name = book.Title,
                                     Description = book.Description,
                                 }).ToListAsync();

            return Ok(books.Skip((currentpageNumber-1)*currentpageSize).Take(currentpageSize));


        }

        [HttpGet("[Action]")]
        public async Task<IActionResult> booksDeatiles(int id)
        {
            var books = await (_Context.Books
                .Where(x => x.Id == id)).FirstOrDefaultAsync();

            return Ok(books);


        }

        //api/books/trendingbooks
        [HttpGet("[Action]")]
        public async Task<IActionResult> TrendingBooks()
        {
            var books = await (from book in _Context.Books
                               where book.Trending==true
                               select new
                               {
                                   ID = book.Id,
                                   Name = book.Title,
                                   Description = book.Description,
                               }).ToListAsync();

            return Ok(books);


        }
        //api/books/NewBooks
        [HttpGet("[Action]")]
        public async Task<IActionResult> NewBooks()
        {
            var books = await (from book in _Context.Books
                               orderby book.CreatedDate  descending
                               select new
                               {
                                   ID = book.Id,
                                   Name = book.Title,
                                   Description = book.Description,
                               }).Take(5).ToListAsync();

            return Ok(books);


        }
        //api/books/searchBooks?query=""
        [HttpGet("[Action]")]
        public async Task<IActionResult> SearchBooks(string query)
        {
            var books = await (from book in _Context.Books
                               where book.Title.StartsWith(query)
                               select new
                               {
                                   ID = book.Id,
                                   Name = book.Title,
                                   Description = book.Description,
                               }).Take(5).ToListAsync();

            return Ok(books);


        }
    }
}
