using Microsoft.EntityFrameworkCore.Migrations;

namespace vega.Migrations
{
    public partial class SeedDaatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Makes ([Name]) VALUES ('Make1')");
            migrationBuilder.Sql("INSERT INTO Makes ([Name]) VALUES ('Make2')");
            migrationBuilder.Sql("INSERT INTO Makes ([Name]) VALUES ('Make3')");

            migrationBuilder.Sql("INSERT INTO [dbo].[Models] ([Name],[MakeId]) VALUES ('ModelA11' , (SELECT ID FROM Makes WHERE Name = 'Make1'))");
            migrationBuilder.Sql("INSERT INTO [dbo].[Models] ([Name],[MakeId]) VALUES ('ModelB11' , (SELECT ID FROM Makes WHERE Name = 'Make1'))");
            migrationBuilder.Sql("INSERT INTO [dbo].[Models] ([Name],[MakeId]) VALUES ('ModelC11' , (SELECT ID FROM Makes WHERE Name = 'Make1'))");

            migrationBuilder.Sql("INSERT INTO [dbo].[Models] ([Name],[MakeId]) VALUES ('ModelA12' , (SELECT ID FROM Makes WHERE Name = 'Make2'))");
            migrationBuilder.Sql("INSERT INTO [dbo].[Models] ([Name],[MakeId]) VALUES ('ModelB12' , (SELECT ID FROM Makes WHERE Name = 'Make2'))");
            migrationBuilder.Sql("INSERT INTO [dbo].[Models] ([Name],[MakeId]) VALUES ('ModelC12' , (SELECT ID FROM Makes WHERE Name = 'Make2'))");

            migrationBuilder.Sql("INSERT INTO [dbo].[Models] ([Name],[MakeId]) VALUES ('ModelA13' , (SELECT ID FROM Makes WHERE Name = 'Make3'))");
            migrationBuilder.Sql("INSERT INTO [dbo].[Models] ([Name],[MakeId]) VALUES ('ModelB13' , (SELECT ID FROM Makes WHERE Name = 'Make3'))");
            migrationBuilder.Sql("INSERT INTO [dbo].[Models] ([Name],[MakeId]) VALUES ('ModelC13' , (SELECT ID FROM Makes WHERE Name = 'Make3'))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM MAKES");
            migrationBuilder.Sql("DELETE FROM MODELS");
        }
    }
}
