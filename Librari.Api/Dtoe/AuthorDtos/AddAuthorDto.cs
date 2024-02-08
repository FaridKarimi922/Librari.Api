using System.ComponentModel.DataAnnotations;

namespace Librari.Api.Dtoe.AuthorDtos
{
    public class AddAuthorDto
    {
        [Required]
        public string Name { get; set; }
    }
}
