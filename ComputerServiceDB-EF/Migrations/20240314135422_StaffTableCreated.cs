using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComputerServiceDB_EF.Migrations
{
    /// <inheritdoc />
    public partial class StaffTableCreated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServiceRecords_ServiceStatuses_StatusId",
                table: "ServiceRecords");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ServiceStatuses",
                table: "ServiceStatuses");

            migrationBuilder.RenameTable(
                name: "ServiceStatuses",
                newName: "ServiceStatus");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ServiceStatus",
                table: "ServiceStatus",
                column: "StatusId");

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    StaffId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SurName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.StaffId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceRecords_ServiceStatus_StatusId",
                table: "ServiceRecords",
                column: "StatusId",
                principalTable: "ServiceStatus",
                principalColumn: "StatusId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServiceRecords_ServiceStatus_StatusId",
                table: "ServiceRecords");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ServiceStatus",
                table: "ServiceStatus");

            migrationBuilder.RenameTable(
                name: "ServiceStatus",
                newName: "ServiceStatuses");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ServiceStatuses",
                table: "ServiceStatuses",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceRecords_ServiceStatuses_StatusId",
                table: "ServiceRecords",
                column: "StatusId",
                principalTable: "ServiceStatuses",
                principalColumn: "StatusId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
