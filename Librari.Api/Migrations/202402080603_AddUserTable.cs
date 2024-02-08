using FluentMigrator;

namespace Librari.Api.Migrations
{
    [Migration(202402080603)]
    public class _202402080603_AddUserTable : Migration
    {
        public override void Up()
        {
            Create.Table("Users")
        .WithColumn("Id").AsInt32().PrimaryKey().Identity()
         .WithColumn("FirstName").AsString(50).NotNullable()
         .WithColumn("LastName").AsString(50).NotNullable()
         .WithColumn("Email").AsString(100).NotNullable()
         .WithColumn("CreateAt").AsDateTime().NotNullable();
        }

        public override void Down()
        {
            Delete.Table("Users");
        }

    }
}
