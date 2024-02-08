using Librari.Api.Dtoe.BookDtos;
using Librari.Api.Services.Books;
using Microsoft.AspNetCore.Mvc;

namespace Librari.Api.Controllers
{
    [ApiController]
    [Route("api/books")]
    public class BookController : ControllerBase
    {
        private readonly IBookService _service;
        public BookController(IBookService service)
        {
            _service = service;
        }

        [HttpPost("Set")]
        public void Add([FromBody] AddBookDto dto)
        {
            _service.Add(dto);
        }
        [HttpGet("Get")]
        public List<GetBookDto> Get([FromQuery] GetBookDto dto)
        {
            return _service.Get();
        }
        [HttpPatch("update/{id}")]
        public void Update(UpdateBookDto dto, [FromRoute] int id)
        {
            _service.Update(id, dto);
        }
        [HttpDelete("removed/{id}")]
        public void Delete([FromRoute] int id)
        {
            _service.DeleteBook(id);
        }


    }
}
