using Librari.Api.Dtoe.RentBookDto;
using Librari.Api.Dtoe.RentBookDtos;
using Librari.Api.Services.RentBook;
using Microsoft.AspNetCore.Mvc;

namespace Librari.Api.Controllers
{
    [ApiController]
    [Route("api/Rentbooks")]
    public class RentBookController : ControllerBase
    {
        private readonly IRentBookService _service;
        public RentBookController(IRentBookService service)
        {
            _service = service;
        }

        [HttpPost("Set")]
        public void Add([FromQuery] AddRentBookDto dto)
        {
            _service.Add(dto);
        }
        [HttpGet("Get")]
        public List<GetRentBookDto> Get([FromQuery] GetRentBookDto dto)
        {
            return _service.Get();
        }


        [HttpDelete("GetBack/{id}")]
        public void GetBack([FromRoute] int id)
        {
            _service.GetBack(id);
        }


    }
}
