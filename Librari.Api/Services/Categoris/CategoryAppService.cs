using Librari.Api.Dtoe.CategoryDtos;
using Librari.Api.Entitis;
using Librari.Api.EntityMaps;
using Librari.Api.Services.Authors;
using Microsoft.EntityFrameworkCore;

namespace Librari.Api.Services.Categoris
{
    public class CategoryAppService : ICategoryService
    {
        private readonly EfDataContext _context;
        public CategoryAppService(EfDataContext context)
        {
            _context = context;
        }

        public void Add(AddCategoryDto dto)
        {
            var category = new Category()
            {
                Name = dto.Name,

            };
            _context.Set<Category>().Add(category);
            _context.SaveChanges();

        }

        public void DeleteCategory(int id)
        {
            var category = _context.Set<Category>().Find(id);
            if (category == null)
            {
                throw new Exception("categoryNotFoundException");
            }
            _context.Set<Category>().Remove(category);
            _context.SaveChanges();

        }

        public List<GetCategoryDto> Get()
        {
            return _context.Set<Category>().Select(_ => new GetCategoryDto
            {

                Id = _.Id,
                Name = _.Name


            }).ToList();
        }

        public void Update(int id, UpdateCategoriDto dto)
        {
            var category = _context.Set<Category>().Find(id);
            if (category == null)
            {
                throw new Exception("BookNotFoundException");
            }

            category.Name = dto.Name;

            _context.SaveChanges();
        }

    }
}
