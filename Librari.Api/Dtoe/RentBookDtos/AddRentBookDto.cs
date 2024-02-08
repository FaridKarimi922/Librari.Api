using System.ComponentModel.DataAnnotations;

namespace Librari.Api.Dtoe.RentBookDtos
{
    public class AddRentBookDto
    {
        public DateTime RentDate { get; set; }
        public int Days { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public int RentalFee { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
    }
}
