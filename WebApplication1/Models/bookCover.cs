namespace WebApplication1.Models
{
    public class bookCover
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public int bookWriterID { get; set; }

        public bookWriters bookWriters { get; set; }
        public ICollection<book> Books { get; set; }

    }
}
