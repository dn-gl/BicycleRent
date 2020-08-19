using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BicycleRent.DAL.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bicycles",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    RentalStatus = table.Column<bool>(nullable: false),
                    TypeId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bicycles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bicycles_Types_TypeId",
                        column: x => x.TypeId,
                        principalTable: "Types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("069d192a-6086-4c1a-8e03-a98a6184a9ea"), "Road" },
                    { new Guid("3f286884-1ffe-41cb-8838-a07737192bb9"), "City" },
                    { new Guid("261d18cb-21b1-4961-8fc7-5d20b7f70e66"), "Hybrid" },
                    { new Guid("d35fbd03-d7d1-4f71-8b53-493225edf6f7"), "Mountain" }
                });

            migrationBuilder.InsertData(
                table: "Bicycles",
                columns: new[] { "Id", "Name", "Price", "RentalStatus", "TypeId" },
                values: new object[,]
                {
                    { new Guid("b4258eeb-bc93-4ed9-899c-148bd3e20c3f"), "TRINX Tempo", 9.9900000000000002, true, new Guid("069d192a-6086-4c1a-8e03-a98a6184a9ea") },
                    { new Guid("548f4050-1e4c-4e75-bb6f-2f9ac16c7efe"), "Orbea Avant", 14.5, true, new Guid("069d192a-6086-4c1a-8e03-a98a6184a9ea") },
                    { new Guid("96e8406d-e8f5-46c6-9e39-2581ec8ac5be"), "Bergamont PRIME", 16.989999999999998, true, new Guid("069d192a-6086-4c1a-8e03-a98a6184a9ea") },
                    { new Guid("b1db4814-b2a4-4ddf-bdb3-4d43845d0fe7"), "Ardis Santana", 10.99, true, new Guid("3f286884-1ffe-41cb-8838-a07737192bb9") },
                    { new Guid("41c58b30-7a13-4bcd-9ad0-715ce3c91f2b"), "Orbea Vector", 15.99, true, new Guid("3f286884-1ffe-41cb-8838-a07737192bb9") },
                    { new Guid("40c9533b-9742-4c72-9967-7919d8518606"), "Bergamont Helix", 10.5, true, new Guid("261d18cb-21b1-4961-8fc7-5d20b7f70e66") },
                    { new Guid("af5152e0-f63a-4d49-b46d-8eea296ba3e2"), "Author Compact", 10.99, true, new Guid("261d18cb-21b1-4961-8fc7-5d20b7f70e66") },
                    { new Guid("cdce4728-5705-4237-aca1-ed69b7114cd9"), "Crossride Shark", 10.99, true, new Guid("d35fbd03-d7d1-4f71-8b53-493225edf6f7") },
                    { new Guid("e50fcbd6-16fb-4c0d-8992-97d158415e49"), "Ghost Tacana", 8.5, true, new Guid("d35fbd03-d7d1-4f71-8b53-493225edf6f7") },
                    { new Guid("fa1975b7-6ae4-4be0-8a40-e39fa4d0c999"), "Corrado Namitoa", 13.5, true, new Guid("d35fbd03-d7d1-4f71-8b53-493225edf6f7") },
                    { new Guid("2f1cd1e2-125d-4d3c-99da-68e98c54b2c1"), "Vento Monte", 9.5, true, new Guid("d35fbd03-d7d1-4f71-8b53-493225edf6f7") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bicycles_TypeId",
                table: "Bicycles",
                column: "TypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bicycles");

            migrationBuilder.DropTable(
                name: "Types");
        }
    }
}
