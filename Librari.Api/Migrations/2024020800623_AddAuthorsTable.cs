using FluentMigrator;

namespace Librari.Api.Migrations
{
    [Migration(2024020800623)]
    public class _2024020800623_AddAuthorsTable :Migration
    {
        public override void Up()
        {

            Create.Table("Authors")
                .WithColumn("Id").AsInt32().PrimaryKey().Identity()
                 .WithColumn("Name").AsString(50).NotNullable();
        }

        public override void Down()
        {
            Delete.Table("Authors");
        }
    }
}
