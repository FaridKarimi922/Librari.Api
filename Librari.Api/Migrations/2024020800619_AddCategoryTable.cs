using FluentMigrator;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Librari.Api.Migrations
{
    [Migration(2024020800619)]
    public class _2024020800619_AddCategoryTable : Migration
    {
        public override void Up()
        {

            Create.Table("Categories")
                .WithColumn("Id").AsInt32().PrimaryKey().Identity()
                 .WithColumn("Name").AsString(50).NotNullable();
        }

        public override void Down()
        {

            Delete.Table("Categories");
        }



    }
}
