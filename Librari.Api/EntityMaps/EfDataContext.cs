using Librari.Api.Entitis;
using Microsoft.EntityFrameworkCore;

namespace Librari.Api.EntityMaps
{
    public class EfDataContext : DbContext
    {
        internal DbSet<Book> Books { get; set; }
        internal DbSet<User> Users { get; set; }
        internal DbSet<Category> Categories { get; set; }
        internal DbSet<Author> Authors { get; set; }
        internal DbSet<RentBook> RentBooks { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Librari;User Id=sa;Password=Farid22922;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EfDataContext).Assembly);
        }


    }
}
