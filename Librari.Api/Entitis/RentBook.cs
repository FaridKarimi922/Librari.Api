namespace Librari.Api.Entitis
{
    public class RentBook
    {
        public int Id { get; set; }
        public DateTime RentDate { get; set; }
        public int Days { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public int RentalFee { get; set; }
        public bool isReturned { get; set; } = false;
        public Book Book { get; set; }
        public int BookId { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }


    }
}
