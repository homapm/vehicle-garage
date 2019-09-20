using Microsoft.EntityFrameworkCore.Migrations;

namespace vega.Migrations
{
    public partial class SeedFeatures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Sun roof')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Music player')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Auto gear')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Features WHERE NAME IN ('Sun roof', 'Music player', 'Auto gear' ) ");
        }
    }
}
