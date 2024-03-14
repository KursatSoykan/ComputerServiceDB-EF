using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComputerServiceDB_EF.Migrations
{
    /// <inheritdoc />
    public partial class SparePartsTableCreated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_serviceRecords_customers_CustomersId",
                table: "serviceRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_serviceRecords_serviceStatuses_StatusId",
                table: "serviceRecords");

            migrationBuilder.DropPrimaryKey(
                name: "PK_serviceStatuses",
                table: "serviceStatuses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_serviceRecords",
                table: "serviceRecords");

            migrationBuilder.DropPrimaryKey(
                name: "PK_customers",
                table: "customers");

            migrationBuilder.RenameTable(
                name: "serviceStatuses",
                newName: "ServiceStatuses");

            migrationBuilder.RenameTable(
                name: "serviceRecords",
                newName: "ServiceRecords");

            migrationBuilder.RenameTable(
                name: "customers",
                newName: "Customers");

            migrationBuilder.RenameIndex(
                name: "IX_serviceRecords_StatusId",
                table: "ServiceRecords",
                newName: "IX_ServiceRecords_StatusId");

            migrationBuilder.RenameIndex(
                name: "IX_serviceRecords_CustomersId",
                table: "ServiceRecords",
                newName: "IX_ServiceRecords_CustomersId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ServiceStatuses",
                table: "ServiceStatuses",
                column: "StatusId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ServiceRecords",
                table: "ServiceRecords",
                column: "ServiceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "CustomersId");

            migrationBuilder.CreateTable(
                name: "SpareParts",
                columns: table => new
                {
                    PartId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StockQuantity = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<decimal>(type: "money", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpareParts", x => x.PartId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceRecords_Customers_CustomersId",
                table: "ServiceRecords",
                column: "CustomersId",
                principalTable: "Customers",
                principalColumn: "CustomersId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceRecords_ServiceStatuses_StatusId",
                table: "ServiceRecords",
                column: "StatusId",
                principalTable: "ServiceStatuses",
                principalColumn: "StatusId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServiceRecords_Customers_CustomersId",
                table: "ServiceRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceRecords_ServiceStatuses_StatusId",
                table: "ServiceRecords");

            migrationBuilder.DropTable(
                name: "SpareParts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ServiceStatuses",
                table: "ServiceStatuses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ServiceRecords",
                table: "ServiceRecords");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.RenameTable(
                name: "ServiceStatuses",
                newName: "serviceStatuses");

            migrationBuilder.RenameTable(
                name: "ServiceRecords",
                newName: "serviceRecords");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "customers");

            migrationBuilder.RenameIndex(
                name: "IX_ServiceRecords_StatusId",
                table: "serviceRecords",
                newName: "IX_serviceRecords_StatusId");

            migrationBuilder.RenameIndex(
                name: "IX_ServiceRecords_CustomersId",
                table: "serviceRecords",
                newName: "IX_serviceRecords_CustomersId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_serviceStatuses",
                table: "serviceStatuses",
                column: "StatusId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_serviceRecords",
                table: "serviceRecords",
                column: "ServiceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_customers",
                table: "customers",
                column: "CustomersId");

            migrationBuilder.AddForeignKey(
                name: "FK_serviceRecords_customers_CustomersId",
                table: "serviceRecords",
                column: "CustomersId",
                principalTable: "customers",
                principalColumn: "CustomersId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_serviceRecords_serviceStatuses_StatusId",
                table: "serviceRecords",
                column: "StatusId",
                principalTable: "serviceStatuses",
                principalColumn: "StatusId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
