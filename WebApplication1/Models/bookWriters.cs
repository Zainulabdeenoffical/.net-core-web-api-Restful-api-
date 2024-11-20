using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class bookWriters
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Gender { get; set; }

        public ICollection<book> Books { get; set; }

        public ICollection<bookCover> BookCovers { get; set; }
        
    }
}
