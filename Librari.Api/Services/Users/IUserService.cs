using Librari.Api.Dtoe.UserDto;

namespace Librari.Api.Services.Users
{
    public interface IUserService
    {
        public void Add(AddUserDto dto);
        public List<GetUserDto> Get();
        public void Update(UpdateUserDto dto, int id);
        public void DeleteUser(int id);
    }
}
