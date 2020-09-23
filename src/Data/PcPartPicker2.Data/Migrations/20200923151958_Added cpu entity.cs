using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PcPartPicker2.Data.Migrations
{
    public partial class Addedcpuentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AuthorId",
                table: "Builds",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Cpus",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    CoreCount = table.Column<int>(nullable: false),
                    Manufacturer = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    CoreClock = table.Column<double>(nullable: false),
                    BoostClock = table.Column<double>(nullable: false),
                    IntegratedGraphics = table.Column<bool>(nullable: false),
                    MaximumSupportedMemory = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cpus", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Builds_AuthorId",
                table: "Builds",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Cpus_IsDeleted",
                table: "Cpus",
                column: "IsDeleted");

            migrationBuilder.AddForeignKey(
                name: "FK_Builds_AspNetUsers_AuthorId",
                table: "Builds",
                column: "AuthorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Builds_AspNetUsers_AuthorId",
                table: "Builds");

            migrationBuilder.DropTable(
                name: "Cpus");

            migrationBuilder.DropIndex(
                name: "IX_Builds_AuthorId",
                table: "Builds");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Builds");
        }
    }
}
