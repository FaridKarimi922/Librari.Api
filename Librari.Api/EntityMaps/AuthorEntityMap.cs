using Librari.Api.Entitis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Librari.Api.EntityMaps
{
    public class AuthorEntityMap : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasKey("Id");
            builder.Property("Id").ValueGeneratedOnAdd();
            builder.Property("Name").HasMaxLength(50).IsRequired();
            builder.HasMany(_ => _.Books)
                .WithOne(_ => _.Author)
                .HasForeignKey(_ => _.AuthorID);
        }
    }
}
