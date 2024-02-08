namespace Librari.Api.Entitis
{
    public class User
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }
        public DateTime CreateAt { get; set; }
        public HashSet<RentBook> RentBooks { get; set; }

    }
}
