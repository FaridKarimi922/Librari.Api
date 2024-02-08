namespace Librari.Api.Dtoe.RentBookDto
{
    public class GetRentBookDto
    {
        public int Id { get; set; }
        public DateTime RentDate { get; set; }
        public int Days { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public bool isReturned { get; set; } 
        public int RentalFee { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
    }
}
