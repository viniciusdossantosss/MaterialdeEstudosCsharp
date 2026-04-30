using Livros.Data;
using Livros.Models;
using Microsoft.EntityFrameworkCore;

namespace Livros.Repositories;

public class CategoriaRepository : ICategoriaRepository
{
    private readonly AppDbContext _context;
    
    public CategoriaRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Categoria>> ListarTodasAsCategorias()
    {
        return await _context.Categorias.ToListAsync();
    }

    public async Task Adicionar(Categoria categoria)
    {
        await _context.Categorias.AddAsync(categoria);
        await _context.SaveChangesAsync();
    }
        
}