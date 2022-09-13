using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projekt_PIV.Migrations
{
    public partial class dd1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DaneAdresowe",
                columns: table => new
                {
                    Id_Adresu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ulica = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Miasto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kod_pocztowy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kraj = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DaneAdresowe", x => x.Id_Adresu);
                });

            migrationBuilder.CreateTable(
                name: "Faktury",
                columns: table => new
                {
                    Id_Faktury = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Klienta = table.Column<int>(type: "int", nullable: false),
                    Id_Pracownika = table.Column<int>(type: "int", nullable: false),
                    Id_Zamówienia = table.Column<int>(type: "int", nullable: false),
                    Termin_płatności = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Całkowita_kwota_do_zapłaty = table.Column<double>(type: "float", nullable: false),
                    Termin_wpłaty = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faktury", x => x.Id_Faktury);
                });

            migrationBuilder.CreateTable(
                name: "Klienci",
                columns: table => new
                {
                    Id_Klienta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imię_klienta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nazwisko_klienta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Numer_telefonu_klienta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PESEL_klienta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email_klienta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id_Adresu = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klienci", x => x.Id_Klienta);
                });

            migrationBuilder.CreateTable(
                name: "Pracownicy",
                columns: table => new
                {
                    Id_Pracownika = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imię_pracownika = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nazwisko_pracownika = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Numer_telefonu_pracownika = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PESEL_pracownika = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email_pracownika = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Data_zatrudnienia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Data_urodzenia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Id_Adresu = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pracownicy", x => x.Id_Pracownika);
                });

            migrationBuilder.CreateTable(
                name: "Produkty",
                columns: table => new
                {
                    Id_Produktu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa_produktu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cena_jednostkowa = table.Column<double>(type: "float", nullable: false),
                    Dostępna_ilość = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produkty", x => x.Id_Produktu);
                });

            migrationBuilder.CreateTable(
                name: "Zamówienia",
                columns: table => new
                {
                    Id_Zamówienia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Produktu = table.Column<int>(type: "int", nullable: false),
                    Cena_jednostkowa = table.Column<double>(type: "float", nullable: false),
                    Ilość = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zamówienia", x => x.Id_Zamówienia);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DaneAdresowe");

            migrationBuilder.DropTable(
                name: "Faktury");

            migrationBuilder.DropTable(
                name: "Klienci");

            migrationBuilder.DropTable(
                name: "Pracownicy");

            migrationBuilder.DropTable(
                name: "Produkty");

            migrationBuilder.DropTable(
                name: "Zamówienia");
        }
    }
}
