using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        :base(options) 
        
        {
            
        }
        public DbSet<Catogrey> catogreys { get; set; }
        public DbSet<book> Books { get; set; }
        public DbSet<bookCover> BookCOvers { get; set; }
        public DbSet<bookWriters> BookWriters { get; set; }


    //    protected override void OnModelCreating(ModelBuilder modelBuilder)
    //    {
    //        modelBuilder.Entity<Catogrey>().HasData(

    //            new Catogrey
    //            {
    //                Id = 2,
    //                Name = "Hp",
    //                displayorder = 2
    //            },
    //            new Catogrey
    //            {
    //                Id = 3,
    //                Name = "Apple",
    //                displayorder = 3
    //            }
    //            );

    //    }

    }
      
}
