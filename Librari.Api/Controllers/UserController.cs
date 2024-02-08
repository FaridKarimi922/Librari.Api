using Librari.Api.Dtoe.UserDto;
using Librari.Api.Services.Users;
using Microsoft.AspNetCore.Mvc;

namespace Librari.Api.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController : ControllerBase
    {

        private readonly IUserService _service;
        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpPost("Set")]
        public void Add([FromBody] AddUserDto dto)
        {
            _service.Add(dto);
        }
        [HttpGet("Get")]
        public List<GetUserDto> Get()
        {
            return _service.Get();
        }
        [HttpPatch("update/{id}")]
        public void Update([FromBody] UpdateUserDto dto, [FromRoute] int id)
        {
            _service.Update(dto, id);
        }
        [HttpDelete("removed/{id}")]
        public void Delete([FromRoute] int id)
        {
            _service.DeleteUser(id);
        }


    }
}
