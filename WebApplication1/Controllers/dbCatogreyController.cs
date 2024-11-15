using Azure.Storage.Blobs;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        
        public async  Task<IActionResult> Get()
        {
           return Ok ( await _context.catogreys.ToListAsync());
        }

        //public IEnumerable<Catogrey> Get()
        //{
        //    return _context.catogreys;
        //}

        // GET api/<dbCatogreyController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult>  Get(int id)
        {
            return Ok ( await  _context.catogreys.FirstOrDefaultAsync(x=>x.Id==id));
        }

        // POST api/<dbCatogreyController>
        [HttpPost]
        //public async  Task <IActionResult> Post([FromBody] Catogrey Catogrey)
        //{
        //   await     _context.catogreys.AddAsync(Catogrey);
        //   await     _context.SaveChangesAsync();
        //    return StatusCode(StatusCodes.Status201Created);
        //}
        // Note Please ucomment it if you want to uplod image on Azure
        public async  Task<IActionResult> Post([FromForm] Catogrey Catogrey)
        {
            String ConnetionString = "insert your azure Account Access Connection String";
            String Container = "enter container thats defined";
            BlobContainerClient containerClient =  new BlobContainerClient(ConnetionString, Container);
            // BlobClient blobClient = containerClient.GetBlobClient(Catogrey.catogreyimage.FileName);
            MemoryStream ms = new MemoryStream();
            //   await Catogrey.catogreyimage.CopytoAsyn(ms);
            // await ms.Position = 0;
            // await BlobClient.uplodtoAysnc(ms);
           // Catogrey.catogreyimagepath = BlobClient.Uri.AbsoluteUri;
            await _context.catogreys.AddAsync(Catogrey);
            await _context.SaveChangesAsync();
            return StatusCode(StatusCodes.Status201Created); 
        }


        // PUT api/<dbCatogreyController>/5
        [HttpPut("{id}")]
        public async Task <IActionResult> put(int id, [FromBody] Catogrey catogrey)
        {
            var catogreyfromDb = await _context.catogreys.FirstOrDefaultAsync(x=> x.Id==id);
            if (catogreyfromDb == null)
            {
                return NotFound();

            }
            else
            {
                catogreyfromDb.Name = catogrey.Name;
                catogreyfromDb.displayorder = catogrey.displayorder;
                _context.catogreys.Update(catogreyfromDb);
                await _context.SaveChangesAsync();
                return NoContent();
            }
        }

        // DELETE api/<dbCatogreyController>/5
        [HttpDelete("{id}")]
        public async Task <IActionResult> Delete(int id)
        {
            var catogreyfromDb = await _context.catogreys.FindAsync(id);
            if (catogreyfromDb == null)
            {
                return NoContent();
            }
            else
            {
                _context.catogreys.Remove(catogreyfromDb);
                await _context.SaveChangesAsync();
                return Ok("Conetnt Deleted");
            }
        }
    }
}
