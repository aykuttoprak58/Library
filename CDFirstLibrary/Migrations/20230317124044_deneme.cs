using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CDFirstLibrary.Migrations
{
    public partial class deneme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "eserler",
                columns: table => new
                {
                    EserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EserAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Yazar = table.Column<int>(type: "int", nullable: true),
                    Kategori = table.Column<int>(type: "int", nullable: true),
                    YayinTarihi = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eserler", x => x.EserId);
                });

            migrationBuilder.CreateTable(
                name: "kategoriler",
                columns: table => new
                {
                    KategoriId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAdi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kategoriler", x => x.KategoriId);
                });

            migrationBuilder.CreateTable(
                name: "ülkeler",
                columns: table => new
                {
                    UlkeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UlkeAdi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ülkeler", x => x.UlkeId);
                });

            migrationBuilder.CreateTable(
                name: "yazarlar",
                columns: table => new
                {
                    YazarId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YazarAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YazarYasi = table.Column<int>(type: "int", nullable: true),
                    YazarUlkesi = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_yazarlar", x => x.YazarId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "eserler");

            migrationBuilder.DropTable(
                name: "kategoriler");

            migrationBuilder.DropTable(
                name: "ülkeler");

            migrationBuilder.DropTable(
                name: "yazarlar");
        }
    }
}
