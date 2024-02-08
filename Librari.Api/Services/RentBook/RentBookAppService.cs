using Librari.Api.Dtoe.RentBookDto;
using Librari.Api.Dtoe.RentBookDtos;
using Librari.Api.Entitis;
using Librari.Api.EntityMaps;
using Microsoft.VisualBasic;

namespace Librari.Api.Services.RentBook
{
    public class RentBookAppService : IRentBookService
    {
        private readonly EfDataContext _context;
        public RentBookAppService(EfDataContext context)
        {
            _context = context;
        }

        public void Add(AddRentBookDto dto)
        {
            var rentedbooksByUser = _context.RentBooks.Where(r => r.UserId == dto.UserId && r.isReturned == false);
            var book = _context.Books.FirstOrDefault(b => b.Id == dto.BookId);
            var rentedbooksNumber = _context.RentBooks.Where(b => b.isReturned == false).Count();
            if (rentedbooksByUser.Count() < 4 && book.Count > rentedbooksNumber)
            {

                var rentbook = new Entitis.RentBook()
                {
                    ReturnDate = dto.ReturnDate,
                    RentDate = dto.RentDate,
                    RentalFee = dto.RentalFee,
                    DueDate = dto.DueDate,
                    Days = dto.Days,
                    BookId = dto.BookId,
                    UserId = dto.UserId

                };
                _context.Set<Entitis.RentBook>().Add(rentbook);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("this count is out of range");
            }
        }

        public void GetBack(int id)
        {
            var rentbook = _context.Set<Entitis.RentBook>().Find(id);
            if (rentbook == null)
            {
                throw new Exception("RentBookNotFoundException");
            }
            rentbook.isReturned = true;
            _context.Set<Entitis.RentBook>().Update(rentbook);
            _context.SaveChanges();

        }

        public List<GetRentBookDto> Get()
        {
            return _context.Set<Entitis.RentBook>().Select(_ => new GetRentBookDto
            {
                Id = _.Id,
                RentDate = _.RentDate,
                RentalFee=_.RentalFee,
                ReturnDate = _.ReturnDate,
                UserId = _.UserId,
                BookId = _.BookId,
                Days = _.Days

            }).ToList();
        }
    }
}
