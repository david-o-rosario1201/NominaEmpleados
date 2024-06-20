using Microsoft.EntityFrameworkCore;
using NominaEmpleados.DAL;
using NominaEmpleados.Models;
using System.Linq.Expressions;

namespace NominaEmpleados.Services;

public class DepartamentosService
{
	private readonly Contexto _contexto;

	public DepartamentosService(Contexto contexto)
	{
		_contexto = contexto;
	}

	public async Task<bool> Crear(Departamentos departamento)
	{
		if (!await Existe(departamento.DepartamentoId))
			return await Insertar(departamento);
		else
			return await Modificar(departamento);
	}

	public async Task<bool> Existe(int id)
	{
		return await _contexto.Departamentos
			.AnyAsync(c => c.DepartamentoId == id);
	}

	public async Task<bool> Insertar(Departamentos departamento)
	{
		_contexto.Departamentos.Add(departamento);
		return await _contexto.SaveChangesAsync() > 0;
	}

	public async Task<bool> Modificar(Departamentos departamento)
	{
		_contexto.Update(departamento);
		var modifico = await _contexto.SaveChangesAsync() > 0;
		_contexto.Entry(departamento).State = EntityState.Detached;
		return modifico;
	}

	public async Task<bool> Eliminar(int id)
	{
		var cantidad = await _contexto.Departamentos
			.Where(c => c.DepartamentoId == id)
			.ExecuteDeleteAsync();

		return cantidad > 0;
	}

	public async Task<Departamentos?> Buscar(int id)
	{
		return await _contexto.Departamentos
			.AsNoTracking()
			.FirstOrDefaultAsync(c => c.DepartamentoId == id);
	}

	public async Task<List<Departamentos>> Listar(Expression<Func<Departamentos, bool>> criterio)
	{
		return await _contexto.Departamentos
			.AsNoTracking()
			.Where(criterio)
			.ToListAsync();
	}
}
