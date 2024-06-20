using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NominaEmpleados.Models;

public class Empleados
{
	[Key]
	public int EmpleadoId { get; set; }

	[Required(ErrorMessage = "Debe ingresar un nombre")]
	public string Nombre { get; set; }

	[Required(ErrorMessage = "Debe ingresar un apellido")]
	public string Apellido { get; set; }

	[Required(ErrorMessage = "Debe ingresar un cédula")]
	public string Cedula { get; set; }

	[Required(ErrorMessage = "Debe ingresar una dirección")]
	public string Direccion { get; set; }

	[Required(ErrorMessage = "Debe ingresar un teléfono")]
	public string Telefono { get; set; }

	[Required(ErrorMessage = "Debe ingresar una profesión")]
	public string Profesion { get; set; }

	[ForeignKey("Departamentos")]
	[Range(1,int.MaxValue, ErrorMessage = "Debe elegir un departamento")]
	public int DepartamentoId { get; set; }

	[ForeignKey ("PuestosTrabajo")]
	[Range(1, int.MaxValue, ErrorMessage = "Debe elegir un puesto de trabajo")]
	public int PuestoId { get; set; }


	public Departamentos Departamento { get; set; }
	public PuestosTrabajo PuestosTrabajo { get; set; }

	//(nombre, apellidos, cédula, dirección, teléfono, profesión,
	//registrar el departamento y el puesto que va a desempeñar).
}
