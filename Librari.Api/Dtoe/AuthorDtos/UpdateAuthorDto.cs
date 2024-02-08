using System.ComponentModel.DataAnnotations;

namespace Librari.Api.Dtoe.AuthorDtos
{
    public class UpdateAuthorDto
    {
        [Required]
        public string Name { get; set; }
    }
}
