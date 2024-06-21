using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NominaEmpleados.Models;

public class Nomina
{
	[Key]
	public int NominaId { get; set; }

    [ForeignKey("Empleados")]
	[Range(1,int.MaxValue, ErrorMessage = "Debe elegir un empleado")]
    public int EmpleadoId { get; set; }

	public string PeriodoPago { get; set; } = "1 de junio - 30 de junio de 2024";

	public decimal AFP { get; set; }

	public decimal SeguroMedico { get; set; }

	public decimal DescuentoPrestamo { get; set; } = 0;

	public decimal HorasExtras { get; set; } = 0;

	public decimal CantidadHorasExtras { get; set; } = 0;

	public decimal ISR { get; set; } = 0;

	public decimal SalarioBruto { get; set; }

	public decimal SalarioNeto { get; set; }

	public Empleados Empleado { get; set; }
}
