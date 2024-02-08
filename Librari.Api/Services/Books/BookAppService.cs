using Librari.Api.Dtoe.BookDtos;
using Librari.Api.Entitis;
using Librari.Api.EntityMaps;
using Librari.Api.Services.Authors;
using Microsoft.EntityFrameworkCore;

namespace Librari.Api.Services.Books
{
    public class BookAppService : IBookService
    {
        private readonly EfDataContext _context;
        public BookAppService(EfDataContext context)
        {
            _context = context;
        }

        public void Add(AddBookDto dto)
        {
            var book = new Book()
            {
                Genre = dto.Genre,
                Name = dto.Name,
                Count = dto.Count,
                CategoryId = dto.CategoryID,
                AuthorID = dto.AuthorID,
                DatePublication = DateTime.Now,

            };
            _context.Set<Book>().Add(book);
            _context.SaveChanges();
        }

        public void DeleteBook(int id)
        {
            var book = _context.Set<Book>().Find(id);
            if (book == null)
            {
                throw new Exception("BookNotFoundException");
            }
            _context.Set<Book>().Remove(book);
            _context.SaveChanges();
        }

        public List<GetBookDto> Get()
        {
            return _context.Set<Book>().Select(_ => new GetBookDto
            {

                Id = _.Id,
                Name = _.Name,
                Genre = _.Genre,
                Count = _.Count,
                CategoryID = _.CategoryId,
                AuthorID = _.AuthorID,
                RentedBookCount = _context.RentBooks.Where(b => b.Id == _.Id && b.isReturned == false).Count(),
                DatePublication = _.DatePublication

            }).ToList();
        }

        public void Update(int id, UpdateBookDto dto)
        {
            var book = _context.Set<Book>().Find(id);
            if (book == null)
            {
                throw new Exception("BookNotFoundException");
            }
            book.Id = dto.Id;
            book.Name = dto.Name;

            _context.SaveChanges();
        }
    }
}
