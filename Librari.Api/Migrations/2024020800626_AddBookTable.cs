using FluentMigrator;

namespace Librari.Api.Migrations
{
    [Migration(2024020800626)]
    public class _2024020800626_AddBookTable :Migration
    {
        public override void Up()
        {
            Create.Table("Books")
                .WithColumn("Id").AsInt32().PrimaryKey().Identity()
                .WithColumn("Name").AsString(50).NotNullable()
                 .WithColumn("Genre").AsString(50).NotNullable()
                 .WithColumn("DatePublication").AsDateTime().NotNullable()
                 .WithColumn("Count").AsInt32().NotNullable();
                 
        }
        public override void Down()
        {
            Delete.Table("Books");
        }
    }
}
