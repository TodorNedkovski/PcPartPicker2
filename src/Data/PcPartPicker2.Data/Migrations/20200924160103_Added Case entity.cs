using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PcPartPicker2.Data.Migrations
{
    public partial class AddedCaseentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cases",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    PowerSupply = table.Column<string>(nullable: true),
                    SidePanelWindow = table.Column<string>(nullable: true),
                    Height = table.Column<double>(nullable: false),
                    Width = table.Column<double>(nullable: false),
                    Length = table.Column<double>(nullable: false),
                    VolumeInLiters = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cases", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cases_IsDeleted",
                table: "Cases",
                column: "IsDeleted");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cases");
        }
    }
}
