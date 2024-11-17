using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Catogrey
    {
        public int Id { get; set; }
        [Required (ErrorMessage ="Name cannot be Null or empty")]
        public string Name { get; set; }
        [Required]
        public int displayorder { get; set;}
        public DateTime  CreatedDate { get; set; } = DateTime.Now;
        //[NotMapped]
        //public IFormatProvider  catogreyimage {  get; set; }
      //  public string catogreimagepath { get; set; }
    }
}
