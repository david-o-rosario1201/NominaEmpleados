using Microsoft.EntityFrameworkCore;
using NominaEmpleados.DAL;
using NominaEmpleados.Models;
using System.Linq.Expressions;

namespace NominaEmpleados.Services;

public class NominaService
{
	private readonly Contexto _contexto;

	public NominaService(Contexto contexto)
	{
		_contexto = contexto;
	}

	public async Task<bool> Crear(Nomina nomina)
	{
		if (!await Existe(nomina.NominaId))
			return await Insertar(nomina);
		else
			return await Modificar(nomina);
	}

	public async Task<bool> Existe(int id)
	{
		return await _contexto.Nomina
			.AnyAsync(c => c.NominaId == id);
	}

	public async Task<bool> Insertar(Nomina nomina)
	{
		_contexto.Nomina.Add(nomina);
		return await _contexto.SaveChangesAsync() > 0;
	}

	public async Task<bool> Modificar(Nomina nomina)
	{
		_contexto.Update(nomina);
		var modifico = await _contexto.SaveChangesAsync() > 0;
		_contexto.Entry(nomina).State = EntityState.Detached;
		return modifico;
	}

	public async Task<bool> Eliminar(int id)
	{
		var cantidad = await _contexto.Nomina
			.Where(c => c.NominaId == id)
			.ExecuteDeleteAsync();

		return cantidad > 0;
	}

	public async Task<Nomina?> Buscar(int id)
	{
		return await _contexto.Nomina
			.Include(e => e.Empleado.PuestosTrabajo)
			.AsNoTracking()
			.FirstOrDefaultAsync(c => c.NominaId == id);
	}

	public async Task<List<Nomina>> Listar(Expression<Func<Nomina, bool>> criterio)
	{
		return await _contexto.Nomina
			.Include(e => e.Empleado.PuestosTrabajo)
			.AsNoTracking()
			.Where(criterio)
			.ToListAsync();
	}
}
