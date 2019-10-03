using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace vega.Migrations
{
    public partial class UnwantedIdCleanup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_VehicleFeatures",
                table: "VehicleFeatures");

            migrationBuilder.DropIndex(
                name: "IX_VehicleFeatures_FeatureId",
                table: "VehicleFeatures");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "VehicleFeatures");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VehicleFeatures",
                table: "VehicleFeatures",
                columns: new[] { "FeatureId", "VehicleId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_VehicleFeatures",
                table: "VehicleFeatures");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "VehicleFeatures",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_VehicleFeatures",
                table: "VehicleFeatures",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleFeatures_FeatureId",
                table: "VehicleFeatures",
                column: "FeatureId");
        }
    }
}
