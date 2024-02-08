using System.ComponentModel.DataAnnotations;

namespace Librari.Api.Dtoe.BookDtos
{
    public class GetBookDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public DateTime DatePublication { get; set; }
        public int Count { get; set; }
        public int AuthorID { get; set; }
        public int CategoryID { get; set; }
        public int RentedBookCount { get; set; }
    }
}
