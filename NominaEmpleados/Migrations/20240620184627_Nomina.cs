using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NominaEmpleados.Migrations
{
    /// <inheritdoc />
    public partial class Nomina : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Nomina",
                columns: table => new
                {
                    NominaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EmpleadoId = table.Column<int>(type: "INTEGER", nullable: false),
                    PeriodoPago = table.Column<string>(type: "TEXT", nullable: false),
                    AFP = table.Column<decimal>(type: "TEXT", nullable: false),
                    SeguroMedico = table.Column<decimal>(type: "TEXT", nullable: false),
                    DescuentoPrestamo = table.Column<decimal>(type: "TEXT", nullable: false),
                    HorasExtras = table.Column<decimal>(type: "TEXT", nullable: false),
                    ISR = table.Column<decimal>(type: "TEXT", nullable: false),
                    SalarioBruto = table.Column<decimal>(type: "TEXT", nullable: false),
                    SalarioNeto = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomina", x => x.NominaId);
                    table.ForeignKey(
                        name: "FK_Nomina_Empleados_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleados",
                        principalColumn: "EmpleadoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Nomina_EmpleadoId",
                table: "Nomina",
                column: "EmpleadoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Nomina");
        }
    }
}
