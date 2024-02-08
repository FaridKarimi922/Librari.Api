using Librari.Api.Dtoe.AuthorDtos;
using Librari.Api.Entitis;
using Librari.Api.EntityMaps;
using Microsoft.EntityFrameworkCore;

namespace Librari.Api.Services.Authors
{
    public class AuthorAppService : IAuthorService
    {
        private readonly EfDataContext _context;
        public AuthorAppService(EfDataContext context)
        {
            _context = context;
        }

        public void Add(AddAuthorDto dto)
        {
            var author = new Entitis.Author()
            {

                Name = dto.Name,



            };
            _context.Set<Entitis.Author>().Add(author);
            _context.SaveChanges();

        }

        public void DeleteAuthor(int id)
        {
            var author = _context.Set<Entitis.Author>().Find(id);
            if (author == null)
            {
                throw new Exception("authorNotFoundException");
            }
            _context.Set<Entitis.Author>().Remove(author);
            _context.SaveChanges();

        }

        public List<GetAuthorDto> Get()
        {
            return _context.Set<Author>().Select(_ => new GetAuthorDto
            {

                Id = _.Id,
                Name = _.Name


            }).ToList();
        }

        public void Update(int id, UpdateAuthorDto dto)
        {
            var author = _context.Set<Author>().Find(id);
            if (author == null)
            {
                throw new Exception("BookNotFoundException");
            }

            author.Name = dto.Name;

            _context.SaveChanges();
        }
    }
}
