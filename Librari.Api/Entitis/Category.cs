namespace Librari.Api.Entitis
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public HashSet<Book> Books { get; set; }

    }
}
