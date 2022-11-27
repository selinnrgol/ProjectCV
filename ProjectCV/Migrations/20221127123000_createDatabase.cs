using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectCV.Migrations
{
    public partial class createDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TblAdmins",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblAdmins", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TblDeneyimlerims",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Baslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AltBaslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tarih = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblDeneyimlerims", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TblEgitimlerims",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Baslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AltBaslik1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AltBaslik2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GNO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tarih = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblEgitimlerims", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TblHakkimdas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Resim = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblHakkimdas", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TblHobilerims",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aciklama1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aciklama2 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblHobilerims", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TblIletisims",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdSoyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Konu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mesaj = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblIletisims", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TblSertifikalarims",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tarih = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblSertifikalarims", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TblSosyalMedyas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ikon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblSosyalMedyas", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TblYeteneklerims",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Yetenek = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Oran = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblYeteneklerims", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblAdmins");

            migrationBuilder.DropTable(
                name: "TblDeneyimlerims");

            migrationBuilder.DropTable(
                name: "TblEgitimlerims");

            migrationBuilder.DropTable(
                name: "TblHakkimdas");

            migrationBuilder.DropTable(
                name: "TblHobilerims");

            migrationBuilder.DropTable(
                name: "TblIletisims");

            migrationBuilder.DropTable(
                name: "TblSertifikalarims");

            migrationBuilder.DropTable(
                name: "TblSosyalMedyas");

            migrationBuilder.DropTable(
                name: "TblYeteneklerims");
        }
    }
}
