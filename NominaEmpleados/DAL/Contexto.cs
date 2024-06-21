using Microsoft.EntityFrameworkCore;
using NominaEmpleados.Models;

namespace NominaEmpleados.DAL;

public class Contexto : DbContext
{
    public Contexto(DbContextOptions<Contexto> options) : base(options)
    {
        
    }

    public DbSet<Empleados> Empleados { get; set; }
    public DbSet<Departamentos> Departamentos { get; set;}
    public DbSet<PuestosTrabajo> PuestosTrabajos { get; set;}

    public DbSet<Nomina> Nomina { get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Departamentos>().HasData(new List<Departamentos>
        {
            new Departamentos { DepartamentoId = 1, Departamento = "Recursos Humanos"},
            new Departamentos { DepartamentoId = 2, Departamento = "Finanzas y Contabilidad"},
            new Departamentos { DepartamentoId = 3, Departamento = "Ventas"},
            new Departamentos { DepartamentoId = 4, Departamento = "Tecnología de la Información"},
            new Departamentos { DepartamentoId = 5, Departamento = "Investigación y Desarrollo"},
            new Departamentos { DepartamentoId = 6, Departamento = "Servicio al Cliente"},
            new Departamentos { DepartamentoId = 7, Departamento = "Compras"}
        });
    }
}
