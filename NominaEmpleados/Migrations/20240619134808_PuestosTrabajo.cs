using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NominaEmpleados.Migrations
{
    /// <inheritdoc />
    public partial class PuestosTrabajo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PuestosTrabajos",
                columns: table => new
                {
                    PuestoTrabajoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Puesto = table.Column<string>(type: "TEXT", nullable: false),
                    Sueldo = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PuestosTrabajos", x => x.PuestoTrabajoId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PuestosTrabajos");
        }
    }
}
