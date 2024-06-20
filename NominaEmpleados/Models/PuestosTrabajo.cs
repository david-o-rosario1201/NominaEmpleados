using System.ComponentModel.DataAnnotations;

namespace NominaEmpleados.Models;

public class PuestosTrabajo
{
    [Key]
    public int PuestoTrabajoId { get; set; }

    [Required(ErrorMessage = "Debe ingresar un nombre para el puesto de trabajo")]
    public string Puesto {  get; set; }

    [Range(0.01, 500000,ErrorMessage = "El sueldo debe ser mayor a 0.01 y menor que 500,001")]
    public decimal Sueldo { get; set; }
}
