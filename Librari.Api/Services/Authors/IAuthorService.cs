using Librari.Api.Dtoe.AuthorDtos;

namespace Librari.Api.Services.Authors
{
    public interface IAuthorService
    {
        public void Add(AddAuthorDto dto);
        public List<GetAuthorDto> Get();
        public void Update(int id, UpdateAuthorDto dto);
        public void DeleteAuthor(int id);

    }
}
