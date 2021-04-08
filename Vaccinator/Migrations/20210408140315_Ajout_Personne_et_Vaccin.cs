using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Vaccinator.Migrations
{
    public partial class Ajout_Personne_et_Vaccin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnneeDeNaissance",
                table: "Personne");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateDeNaissance",
                table: "Personne",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "Vaccin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TypeVaccin = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Marque = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    NumLot = table.Column<int>(type: "INTEGER", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DateRappel = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PersonneId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vaccin", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vaccin_Personne_PersonneId",
                        column: x => x.PersonneId,
                        principalTable: "Personne",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vaccin_PersonneId",
                table: "Vaccin",
                column: "PersonneId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vaccin");

            migrationBuilder.DropColumn(
                name: "DateDeNaissance",
                table: "Personne");

            migrationBuilder.AddColumn<int>(
                name: "AnneeDeNaissance",
                table: "Personne",
                type: "INTEGER",
                nullable: true);
        }
    }
}
