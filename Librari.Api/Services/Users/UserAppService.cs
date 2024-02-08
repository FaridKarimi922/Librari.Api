using Librari.Api.Dtoe.UserDto;
using Librari.Api.Entitis;
using Librari.Api.EntityMaps;
using Librari.Api.Services.Authors;
using Microsoft.EntityFrameworkCore;

namespace Librari.Api.Services.Users
{
    public class UserAppService : IUserService
    {
        private readonly EfDataContext _context;
        public UserAppService(EfDataContext context)
        {
            _context = context;
        }

        public void Add(AddUserDto dto)
        {
            var user = new User()
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Email = dto.Email,
                CreateAt = DateTime.Now

            };
            _context.Set<User>().Add(user);
            _context.SaveChanges();
        }

        public void DeleteUser(int id)
        {
            var user = _context.Set<User>().Find(id);
            if (user == null)
            {
                throw new Exception("UserNotFoundException");
            }
            _context.Set<User>().Remove(user);
            _context.SaveChanges();
        }

        public List<GetUserDto> Get()
        {
            return _context.Set<User>().Select(_ => new GetUserDto
            {
                Email = _.Email,
                Id = _.Id,
                FirstName = _.FirstName,
                LastName = _.LastName,
                CreateAt = _.CreateAt

            }).ToList();
        }

        public void Update(UpdateUserDto dto, int id)
        {
            var user = _context.Set<User>().Find(id);
            if (user == null)
            {
                throw new Exception("BookNotFoundException");
            }
            user.Email = dto.Email;
            user.FirstName = dto.FirstName;
            user.LastName = dto.LastName;
            _context.SaveChanges();

        }

    }
}
