using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VsiteZavrsniRad.Migrations
{
    public partial class dbChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SpareParts_WorkOrders_WorkOrderModelId",
                table: "SpareParts");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkOrders_Clients_ClientId",
                table: "WorkOrders");

            migrationBuilder.DropIndex(
                name: "IX_WorkOrders_ClientId",
                table: "WorkOrders");

            migrationBuilder.DropIndex(
                name: "IX_SpareParts_WorkOrderModelId",
                table: "SpareParts");

            migrationBuilder.DropColumn(
                name: "WorkOrderModelId",
                table: "SpareParts");

            migrationBuilder.AddColumn<string>(
                name: "UnitOfMeasure",
                table: "SpareParts",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "WorkOrderId",
                table: "SpareParts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UnitOfMeasure",
                table: "SpareParts");

            migrationBuilder.DropColumn(
                name: "WorkOrderId",
                table: "SpareParts");

            migrationBuilder.AddColumn<int>(
                name: "WorkOrderModelId",
                table: "SpareParts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_WorkOrders_ClientId",
                table: "WorkOrders",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_SpareParts_WorkOrderModelId",
                table: "SpareParts",
                column: "WorkOrderModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_SpareParts_WorkOrders_WorkOrderModelId",
                table: "SpareParts",
                column: "WorkOrderModelId",
                principalTable: "WorkOrders",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkOrders_Clients_ClientId",
                table: "WorkOrders",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
