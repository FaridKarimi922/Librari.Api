using System.ComponentModel.DataAnnotations;

namespace Librari.Api.Dtoe.RentBookDto
{
    public class UpdateRentBookDto
    {
        [Required]
        public DateTime RentDate { get; set; }
        public int Days { get; set; }
    }
}
