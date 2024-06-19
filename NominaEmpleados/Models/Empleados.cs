using System.ComponentModel.DataAnnotations;

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

	[Required(ErrorMessage = "Debe ingresar un departamento")]
	public string Departamento { get; set; }

	[Required (ErrorMessage = "Debe ingresar un puesto de trabajo")]
	public string Puesto { get; set; }

	//(nombre, apellidos, cédula, dirección, teléfono, profesión,
	//registrar el departamento y el puesto que va a desempeñar).
}
