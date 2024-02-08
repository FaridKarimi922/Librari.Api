namespace Librari.Api.Entitis
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public DateTime DatePublication { get; set; }
        public Author Author { get; set; }
        public int AuthorID { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public int Count { get; set; }
        public HashSet<RentBook> RentBooks { get; set; }


    }
}
