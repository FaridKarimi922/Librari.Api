using Librari.Api.Dtoe.AuthorDtos;
using Librari.Api.Services.Authors;
using Microsoft.AspNetCore.Mvc;

namespace Librari.Api.Controllers
{
    [ApiController]
    [Route("api/Authors")]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService _service;
        public AuthorController(IAuthorService service)
        {
            _service = service;
        }

        [HttpPost("Set")]
        public void Add([FromBody] AddAuthorDto dto)
        {
            _service.Add(dto);
        }
        [HttpGet("Get")]
        public List<GetAuthorDto> Get([FromQuery] GetAuthorDto dto)
        {
            return _service.Get();
        }
        [HttpPatch("update/{id}")]
        public void Update([FromBody] UpdateAuthorDto dto, [FromRoute] int id)
        {
            _service.Update(id, dto);
        }
        [HttpDelete("removed/{id}")]
        public void Delete([FromRoute] int id)
        {
            _service.DeleteAuthor(id);
        }
    }
}
