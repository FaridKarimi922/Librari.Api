using Librari.Api.Dtoe.CategoryDtos;

namespace Librari.Api.Services.Categoris
{
    public interface ICategoryService
    {
        public void Add(AddCategoryDto dto);
        public List<GetCategoryDto> Get();
        public void Update(int id, UpdateCategoriDto dto);
        public void DeleteCategory(int id);
    }
}
