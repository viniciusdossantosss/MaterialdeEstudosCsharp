using CriandoUmaWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CriandoUmaWebAPI.Controllers;


[ApiController]
[Route("[controller]")]
public class FimeController
{
    private static List<Filme> filmes = new List<Filme>();
    
    [HttpPost]
    public void AdicionaFilme([FromBody] Filme filme)
    {
        filmes.Add(filme);
    }
}