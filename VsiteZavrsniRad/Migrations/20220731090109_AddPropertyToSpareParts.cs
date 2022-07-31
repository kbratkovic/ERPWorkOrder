using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VsiteZavrsniRad.Migrations
{
    public partial class AddPropertyToSpareParts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "quantityTimesPriceWithoutVAT",
                table: "SpareParts",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "quantityTimesPriceWithoutVAT",
                table: "SpareParts");
        }
    }
}
