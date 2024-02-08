using Librari.Api.Entitis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Librari.Api.EntityMaps
{
    public class UserEntityMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey("Id");
            builder.Property("Id").ValueGeneratedOnAdd();
            builder.Property("FirstName").HasMaxLength(50).IsRequired();
            builder.Property("LastName").HasMaxLength(50).IsRequired();
            builder.Property("Email").HasMaxLength(50).IsRequired();
            builder.Property("CreateAt").HasMaxLength(50).IsRequired();
            builder.HasMany(_ => _.RentBooks)
               .WithOne(_ => _.User)
               .HasForeignKey(_ => _.UserId);
        }
    }


}
