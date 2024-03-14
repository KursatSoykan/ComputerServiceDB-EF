using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComputerServiceDB_EF.Migrations
{
    /// <inheritdoc />
    public partial class ServiceRecordsTableCreated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "serviceRecords",
                columns: table => new
                {
                    ServiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomersId = table.Column<int>(type: "int", nullable: false),
                    DeviceType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeriesNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FaultExplanation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AcceptDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EstimatedCompletionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_serviceRecords", x => x.ServiceId);
                    table.ForeignKey(
                        name: "FK_serviceRecords_customers_CustomersId",
                        column: x => x.CustomersId,
                        principalTable: "customers",
                        principalColumn: "CustomersId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_serviceRecords_serviceStatuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "serviceStatuses",
                        principalColumn: "StatusId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_serviceRecords_CustomersId",
                table: "serviceRecords",
                column: "CustomersId");

            migrationBuilder.CreateIndex(
                name: "IX_serviceRecords_StatusId",
                table: "serviceRecords",
                column: "StatusId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "serviceRecords");
        }
    }
}
