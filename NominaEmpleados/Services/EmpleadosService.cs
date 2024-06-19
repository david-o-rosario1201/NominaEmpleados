using Microsoft.EntityFrameworkCore;
using NominaEmpleados.DAL;
using NominaEmpleados.Models;
using System.Linq.Expressions;

namespace NominaEmpleados.Services;

public class EmpleadosService
{
	private readonly Contexto _contexto;

    public EmpleadosService(Contexto contexto)
    {
        _contexto = contexto;
    }

    public async Task<bool> Crear(Empleados empleado)
    {
		if (!await Existe(empleado.EmpleadoId))
			return await Insertar(empleado);
		else
			return await Modificar(empleado);
    }

    public async Task<bool> Existe(int id)
    {
		return await _contexto.Empleados
			.AnyAsync(c => c.EmpleadoId == id);
	}

    public async Task<bool> Insertar(Empleados empleado)
    {
		_contexto.Empleados.Add(empleado);
		return await _contexto.SaveChangesAsync() > 0;
	}

	public async Task<bool> Modificar(Empleados empleado)
	{
		_contexto.Update(empleado);
		var modifico = await _contexto.SaveChangesAsync() > 0;
		_contexto.Entry(empleado).State = EntityState.Detached;
		return modifico;
	}

	public async Task<bool> Eliminar(int id)
	{
		var cantidad = await _contexto.Empleados
			.Where(c => c.EmpleadoId == id)
			.ExecuteDeleteAsync();

		return cantidad > 0;
	}

	public async Task<Empleados?> Buscar(int id)
	{
		return await _contexto.Empleados
			.AsNoTracking()
			.FirstOrDefaultAsync(c => c.EmpleadoId == id);
	}

	public async Task<List<Empleados>> Listar(Expression<Func<Empleados, bool>> criterio)
	{
		return await _contexto.Empleados
			.AsNoTracking()
			.Where(criterio)
			.ToListAsync();
	}
}
