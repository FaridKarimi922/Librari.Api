using System.ComponentModel.DataAnnotations;

namespace Librari.Api.Dtoe.CategoryDtos
{
    public class AddCategoryDto
    {
        [Required]
        public string Name { get; set; }
    }
}
