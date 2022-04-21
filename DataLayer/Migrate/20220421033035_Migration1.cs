using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrate
{
    public partial class Migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Birim",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    BirimAdi = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Birim", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    EmailAdress = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "BLOB", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "BLOB", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personel",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Adi = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    SoyAdi = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    BirimId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personel_Birim_BirimId",
                        column: x => x.BirimId,
                        principalTable: "Birim",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "EmailAdress", "PasswordHash", "PasswordSalt" },
                values: new object[] { "d55c2a66-204d-48a6-afc7-2020c744cd90", "admin@admin", new byte[] { 190, 22, 128, 23, 190, 59, 4, 53, 36, 125, 139, 185, 147, 230, 5, 166, 123, 8, 13, 45, 34, 154, 72, 162, 206, 31, 194, 60, 237, 190, 1, 100, 3, 181, 182, 129, 60, 42, 249, 144, 157, 181, 218, 126, 54, 205, 0, 206, 110, 197, 36, 72, 209, 170, 249, 134, 168, 160, 46, 183, 164, 100, 200, 150 }, new byte[] { 160, 67, 222, 154, 110, 223, 170, 74, 78, 33, 85, 226, 30, 43, 247, 165, 246, 189, 175, 107, 179, 245, 17, 187, 26, 234, 84, 194, 17, 146, 229, 163, 19, 150, 78, 80, 176, 72, 231, 98, 208, 114, 11, 123, 207, 174, 20, 212, 24, 29, 173, 90, 236, 188, 60, 171, 123, 122, 198, 223, 134, 20, 232, 14, 10, 173, 217, 27, 194, 10, 167, 64, 155, 107, 126, 138, 160, 214, 54, 37, 37, 235, 63, 140, 253, 164, 253, 207, 15, 233, 238, 137, 92, 134, 201, 102, 81, 30, 73, 238, 39, 119, 175, 200, 111, 86, 119, 87, 30, 23, 184, 15, 103, 72, 136, 118, 209, 79, 235, 62, 91, 231, 243, 60, 137, 78, 196, 16 } });

            migrationBuilder.CreateIndex(
                name: "IX_Personel_BirimId",
                table: "Personel",
                column: "BirimId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personel");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Birim");
        }
    }
}
