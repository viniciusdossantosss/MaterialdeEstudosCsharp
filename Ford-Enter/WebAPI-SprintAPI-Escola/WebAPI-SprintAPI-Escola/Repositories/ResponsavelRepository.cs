using Microsoft.EntityFrameworkCore;
using WebAPI_SprintAPI_Escola.Data;
using WebAPI_SprintAPI_Escola.Models;

namespace WebAPI_SprintAPI_Escola.Repositories;

public class ResponsavelRepository : IResponsavelRepository
{
    private readonly AppDbContext _context;

    public ResponsavelRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Responsavel>> ListarTodos()
    {
        return await _context.Responsaveis.ToListAsync();
    }

    public async Task<Responsavel?> BuscarPorId(int id)
    {
        return await _context.Responsaveis.FindAsync(id);
    }

    public async Task Adicionar(Responsavel responsavel)
    {
        await _context.Responsaveis.AddAsync(responsavel);
        await _context.SaveChangesAsync();
    }

    public async Task Atualizar(Responsavel responsavel)
    {
        _context.Responsaveis.Update(responsavel);
        await _context.SaveChangesAsync();
    }

    public async Task Deletar(Responsavel responsavel)
    {
        _context.Responsaveis.Remove(responsavel);
        await _context.SaveChangesAsync();
    }
}