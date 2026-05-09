using Microsoft.EntityFrameworkCore;
using WebAPI_SprintAPI_Escola.Data;
using WebAPI_SprintAPI_Escola.Models;


namespace WebAPI_SprintAPI_Escola.Repositories;

public class AlunoRepository : IAlunoRepository
{
    private readonly AppDbContext _context;
    
    public AlunoRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Aluno>> ListarTodos()
    {
        return await _context.Alunos.ToListAsync();
    }
    
    public async Task<Aluno?> BuscarPorId(int id)
    {
        return await _context.Alunos.FindAsync(id);
    }
    
    public async Task Adicionar(Aluno aluno)
    {
        await _context.Alunos.AddAsync(aluno);
        await _context.SaveChangesAsync();
    }

    public async Task Atualizar(Aluno aluno)
    {
        _context.Alunos.Update(aluno);
        await _context.SaveChangesAsync();
    }
    
    public async Task Deletar(Aluno aluno)
    {
        _context.Alunos.Remove(aluno);
        await _context.SaveChangesAsync();
    }
}
