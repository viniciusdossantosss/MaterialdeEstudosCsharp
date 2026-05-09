using Microsoft.EntityFrameworkCore;
using WebAPI_SprintAPI_Escola.Data;
using WebAPI_SprintAPI_Escola.Models;

namespace WebAPI_SprintAPI_Escola.Repositories;

public class NotaRepository : INotaRepository
{
    private readonly AppDbContext _context;

    public NotaRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Nota>> ListarTodos()
    {
        return await _context.Notas.ToListAsync();
    }

    public async Task<Nota?> BuscarPorId(int id)
    {
        return await _context.Notas.FindAsync(id);
    }

    public async Task Adicionar(Nota nota)
    {
        await _context.Notas.AddAsync(nota);
        await _context.SaveChangesAsync();
    }

    public async Task Atualizar(Nota nota)
    {
        _context.Notas.Update(nota);
        await _context.SaveChangesAsync();
    }

    public async Task Deletar(Nota nota)
    {
        _context.Notas.Remove(nota);
        await _context.SaveChangesAsync();
    }
}