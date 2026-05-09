using Microsoft.EntityFrameworkCore;
using WebAPI_SprintAPI_Escola.Data;
using WebAPI_SprintAPI_Escola.Models;

namespace WebAPI_SprintAPI_Escola.Repositories;

public class TurmaRepository : ITurmaRepository
{
    private readonly AppDbContext _context;

    public TurmaRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Turma>> ListarTodos()
    {
        return await _context.Turmas.ToListAsync();
    }

    public async Task<Turma?> BuscarPorId(int id)
    {
        return await _context.Turmas.FindAsync(id);
    }

    public async Task Adicionar(Turma turma)
    {
        await _context.Turmas.AddAsync(turma);
        await _context.SaveChangesAsync();
    }

    public async Task Atualizar(Turma turma)
    {
        _context.Turmas.Update(turma);
        await _context.SaveChangesAsync();
    }

    public async Task Deletar(Turma turma)
    {
        _context.Turmas.Remove(turma);
        await _context.SaveChangesAsync();
    }
}