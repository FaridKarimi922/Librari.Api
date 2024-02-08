using Librari.Api.Dtoe.RentBookDto;
using Librari.Api.Dtoe.RentBookDtos;

namespace Librari.Api.Services.RentBook
{
    public interface IRentBookService
    {
        public void Add(AddRentBookDto dto);
        public List<GetRentBookDto> Get();
        public void GetBack(int id);
    }
}
