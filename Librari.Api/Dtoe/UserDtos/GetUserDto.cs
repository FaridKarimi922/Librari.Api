namespace Librari.Api.Dtoe.UserDto
{
    public class GetUserDto
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }
        public DateTime CreateAt { get; set; } 
    }
}
