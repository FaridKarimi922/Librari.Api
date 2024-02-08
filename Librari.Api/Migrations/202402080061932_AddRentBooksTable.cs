using FluentMigrator;

namespace Librari.Api.Migrations
{
    [Migration(202402080061932)]
    public class _202402080061932_AddRentBooksTable :Migration
    {
        public override void Up()
        {
            Create.Table("RentBooks")
                .WithColumn("Id").AsInt32().PrimaryKey().Identity()
                 .WithColumn("RentDate").AsDateTime().NotNullable()
                 .WithColumn("Days").AsInt32().NotNullable()
                 .WithColumn("DueDate").AsDateTime().NotNullable()
                 .WithColumn("ReturnDate").AsDateTime().NotNullable()
                 .WithColumn("RentalFee").AsDateTime().NotNullable()
                 .WithColumn("isReturned").AsBoolean().NotNullable();

        }
        public override void Down()
        {
            Delete.Table("RentBooks");
        }
    }
}
