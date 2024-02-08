using Librari.Api.Entitis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Librari.Api.EntityMaps
{
    public class CategoryEntityMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey("Id");
            builder.Property("Id").ValueGeneratedOnAdd();
            builder.Property("Name").HasMaxLength(50).IsRequired();
            builder.HasMany(_ => _.Books)
               .WithOne(_ => _.Category)
               .HasForeignKey(_ => _.CategoryId);
        }
    }
}
