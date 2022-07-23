using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VsiteZavrsniRad.Migrations
{
    public partial class dbModelChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CompanyName",
                table: "Clients",
                newName: "ClientName");

            migrationBuilder.AlterColumn<string>(
                name: "WorkOrderNumber",
                table: "WorkOrders",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "ServiceItem",
                table: "WorkOrders",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ClientNumber",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ServiceItem",
                table: "WorkOrders");

            migrationBuilder.DropColumn(
                name: "ClientNumber",
                table: "Clients");

            migrationBuilder.RenameColumn(
                name: "ClientName",
                table: "Clients",
                newName: "CompanyName");

            migrationBuilder.AlterColumn<int>(
                name: "WorkOrderNumber",
                table: "WorkOrders",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
