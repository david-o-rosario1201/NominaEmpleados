using Microsoft.EntityFrameworkCore;
using NominaEmpleados.Models;

namespace NominaEmpleados.DAL;

public class Contexto : DbContext
{
    public Contexto(DbContextOptions<Contexto> options) : base(options)
    {
        
    }

    public DbSet<Empleados> Empleados { get; set;}
}
