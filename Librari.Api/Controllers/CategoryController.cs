using Librari.Api.Dtoe.CategoryDtos;
using Librari.Api.Services.Categoris;
using Microsoft.AspNetCore.Mvc;

namespace Librari.Api.Controllers
{
    [ApiController]
    [Route("api/Categories")]
    public class CategoryCController : ControllerBase
    {
        private readonly ICategoryService _service;
        public CategoryCController(ICategoryService service)
        {
            _service = service;
        }

        [HttpPost("Set")]
        public void Add([FromBody] AddCategoryDto dto)
        {
            _service.Add(dto);
        }
        [HttpGet("Get")]
        public List<GetCategoryDto> Get([FromQuery] GetCategoryDto dto)
        {
            return _service.Get();
        }
        [HttpPatch("update/{id}")]
        public void Update([FromBody] UpdateCategoriDto dto, [FromRoute] int id)
        {
            _service.Update(id, dto);
        }
        [HttpDelete("removed/{id}")]
        public void Delete([FromRoute] int id)
        {
            _service.DeleteCategory(id);
        }
    }
}
