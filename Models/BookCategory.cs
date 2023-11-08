namespace Rad_Andrada_Lab2.Models
{
    public class BookCategory
    {
        public int ID { get; set; }
        public int BookID { get; set; }
        public Book Book { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }

        public static implicit operator BookCategory(Book v)
        {
            throw new NotImplementedException();
        }
    }
}
