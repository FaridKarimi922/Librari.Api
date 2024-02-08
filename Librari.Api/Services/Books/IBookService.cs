using Librari.Api.Dtoe.BookDtos;

namespace Librari.Api.Services.Books
{
    public interface IBookService
    {
        public void Add(AddBookDto dto);
        public List<GetBookDto> Get();
        public void Update(int id, UpdateBookDto dto);
        public void DeleteBook(int id);
    }
}
