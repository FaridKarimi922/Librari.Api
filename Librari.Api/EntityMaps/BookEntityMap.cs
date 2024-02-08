using Librari.Api.Entitis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Librari.Api.EntityMaps
{
    public class BookEntityMap : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey("Id");
            builder.Property("Id").ValueGeneratedOnAdd();
            builder.Property("Name").HasMaxLength(50).IsRequired();
            builder.Property("Genre").HasMaxLength(50).IsRequired();
            builder.Property("DatePublication").IsRequired();
            builder.Property("Count").IsRequired();
            builder.HasMany(_ => _.RentBooks)
               .WithOne(_ => _.Book)
               .HasForeignKey(_ => _.BookId);
        }
    }
}
