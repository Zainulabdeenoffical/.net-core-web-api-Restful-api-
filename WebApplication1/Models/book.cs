namespace WebApplication1.Models
{
    public class book
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }

        public DateTime  CreatedDate { get; set; }
         public String  ISBNNumber { get; set; }

        public bool Trending { get; set; }

        public int  BookCoverID {  get; set; }

        public bookCover bookCover { get; set; }

        public int bookWriterID { get; set; }

        public bookWriters BookWriters { get; set; }


    }
}
