using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VsiteZavrsniRad.Migrations
{
    public partial class ManyToManyAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WorkOrderId",
                table: "SpareParts");

            migrationBuilder.CreateTable(
                name: "SparePart_WorkOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SparePartId = table.Column<int>(type: "int", nullable: false),
                    WorkOrderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SparePart_WorkOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SparePart_WorkOrders_SpareParts_SparePartId",
                        column: x => x.SparePartId,
                        principalTable: "SpareParts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SparePart_WorkOrders_WorkOrders_WorkOrderId",
                        column: x => x.WorkOrderId,
                        principalTable: "WorkOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SparePart_WorkOrders_SparePartId",
                table: "SparePart_WorkOrders",
                column: "SparePartId");

            migrationBuilder.CreateIndex(
                name: "IX_SparePart_WorkOrders_WorkOrderId",
                table: "SparePart_WorkOrders",
                column: "WorkOrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SparePart_WorkOrders");

            migrationBuilder.AddColumn<int>(
                name: "WorkOrderId",
                table: "SpareParts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
