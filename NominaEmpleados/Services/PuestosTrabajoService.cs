using Microsoft.EntityFrameworkCore;
using NominaEmpleados.DAL;
using NominaEmpleados.Models;
using System.Linq.Expressions;

namespace NominaEmpleados.Services;

public class PuestosTrabajoService
{
	private readonly Contexto _contexto;

	public PuestosTrabajoService(Contexto contexto)
	{
		_contexto = contexto;
	}

	public async Task<bool> Crear(PuestosTrabajo puesto)
	{
		if (!await Existe(puesto.PuestoTrabajoId))
			return await Insertar(puesto);
		else
			return await Modificar(puesto);
	}

	public async Task<bool> Existe(int id)
	{
		return await _contexto.PuestosTrabajos
			.AnyAsync(c => c.PuestoTrabajoId == id);
	}

	public async Task<bool> Insertar(PuestosTrabajo puesto)
	{
		_contexto.PuestosTrabajos.Add(puesto);
		return await _contexto.SaveChangesAsync() > 0;
	}

	public async Task<bool> Modificar(PuestosTrabajo puesto)
	{
		_contexto.Update(puesto);
		var modifico = await _contexto.SaveChangesAsync() > 0;
		_contexto.Entry(puesto).State = EntityState.Detached;
		return modifico;
	}

	public async Task<bool> Eliminar(int id)
	{
		var cantidad = await _contexto.PuestosTrabajos
			.Where(c => c.PuestoTrabajoId == id)
			.ExecuteDeleteAsync();

		return cantidad > 0;
	}

	public async Task<PuestosTrabajo?> Buscar(int id)
	{
		return await _contexto.PuestosTrabajos
			.AsNoTracking()
			.FirstOrDefaultAsync(c => c.PuestoTrabajoId == id);
	}

	public async Task<List<PuestosTrabajo>> Listar(Expression<Func<PuestosTrabajo, bool>> criterio)
	{
		return await _contexto.PuestosTrabajos
			.AsNoTracking()
			.Where(criterio)
			.ToListAsync();
	}
}
