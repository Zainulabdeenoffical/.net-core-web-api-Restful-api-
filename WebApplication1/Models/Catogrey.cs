using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Catogrey
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int displayorder { get; set;}
        public DateTime  CreatedDate { get; set; } = DateTime.Now;
        [NotMapped]
        public IFormatProvider  catogreyimage {  get; set; }
        public string catogreimagepath { get; set; }
    }
}
