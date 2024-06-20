using System.ComponentModel.DataAnnotations;

namespace NominaEmpleados.Models;

public class Departamentos
{
	[Key]
	public int DepartamentoId { get; set; }

    public string Departamento { get; set; }
}
