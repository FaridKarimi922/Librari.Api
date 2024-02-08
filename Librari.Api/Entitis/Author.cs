namespace Librari.Api.Entitis
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public HashSet<Book> Books { get; set; }

    }
}
