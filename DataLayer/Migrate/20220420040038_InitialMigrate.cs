using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrate
{
    public partial class InitialMigrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Birim",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
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
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
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
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Adi = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    SoyAdi = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    BirimId = table.Column<Guid>(type: "TEXT", nullable: false)
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
                values: new object[] { new Guid("e26993e8-0c18-4ee2-8f54-17b08e5d945a"), "admin@admincom", new byte[] { 19, 2, 216, 121, 140, 157, 21, 75, 129, 194, 123, 124, 42, 40, 193, 158, 31, 196, 187, 215, 32, 0, 205, 66, 136, 102, 40, 67, 55, 1, 57, 126, 138, 2, 225, 23, 250, 103, 91, 76, 246, 62, 138, 90, 72, 90, 205, 213, 117, 132, 193, 205, 202, 11, 43, 79, 23, 156, 93, 78, 103, 197, 54, 252 }, new byte[] { 121, 111, 230, 106, 196, 98, 49, 246, 65, 61, 139, 88, 57, 192, 97, 102, 99, 31, 71, 83, 218, 57, 81, 8, 234, 139, 111, 159, 241, 194, 117, 145, 169, 221, 123, 192, 60, 72, 249, 133, 37, 93, 101, 54, 54, 168, 95, 116, 81, 103, 26, 13, 78, 17, 209, 122, 254, 59, 76, 113, 70, 125, 99, 77, 244, 62, 132, 158, 35, 180, 92, 10, 182, 70, 7, 190, 107, 190, 152, 239, 128, 162, 128, 110, 64, 34, 11, 192, 11, 85, 166, 43, 224, 184, 217, 176, 5, 13, 149, 30, 115, 108, 7, 149, 59, 125, 215, 25, 160, 248, 60, 147, 37, 126, 65, 107, 174, 91, 228, 110, 105, 51, 32, 121, 209, 118, 3, 132 } });

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
