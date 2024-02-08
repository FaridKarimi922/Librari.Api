using System.ComponentModel.DataAnnotations;

namespace Librari.Api.Dtoe.BookDtos
{
    public class AddBookDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        public DateTime DatePublication { get; set; }
        [Required]
        public int Count { get; set; }
        public int AuthorID { get; set; }
        public int CategoryID { get; set; }
    }
}
