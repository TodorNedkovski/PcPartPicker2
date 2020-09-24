using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PcPartPicker2.Data.Migrations
{
    public partial class AddedVideoCardentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VideoCards",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    Chipset = table.Column<string>(nullable: true),
                    Memory = table.Column<string>(nullable: true),
                    MemoryType = table.Column<string>(nullable: true),
                    CoreClock = table.Column<int>(nullable: false),
                    BoostClock = table.Column<int>(nullable: false),
                    EffectiveMemoryClock = table.Column<int>(nullable: false),
                    Interface = table.Column<string>(nullable: true),
                    HDMIPorts = table.Column<int>(nullable: false),
                    CoolingFansCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoCards", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VideoCards_IsDeleted",
                table: "VideoCards",
                column: "IsDeleted");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VideoCards");
        }
    }
}
