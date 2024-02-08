using Librari.Api.Entitis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Librari.Api.EntityMaps
{
    public class RentBookEntityMap : IEntityTypeConfiguration<RentBook>
    {
        public void Configure(EntityTypeBuilder<RentBook> builder)
        {
            builder.HasKey("Id");
            builder.Property("Id").ValueGeneratedOnAdd();
            builder.Property("RentDate").IsRequired();
            builder.Property("Days").IsRequired();
            builder.Property("DueDate").IsRequired();
            builder.Property("ReturnDate").IsRequired();
            builder.Property("RentalFee").IsRequired();
            builder.Property("isReturned").IsRequired();


        }
    }
}
