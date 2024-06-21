using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NominaEmpleados.Migrations
{
    /// <inheritdoc />
    public partial class Nomina2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "CantidadHorasExtras",
                table: "Nomina",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CantidadHorasExtras",
                table: "Nomina");
        }
    }
}
