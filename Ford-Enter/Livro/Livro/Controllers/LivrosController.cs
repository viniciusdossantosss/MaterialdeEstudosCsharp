using Microsoft.AspNetCore.Mvc;
namespace Livro.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LivrosController : Controller
{
    public IActionResult GetLivros()
    {
        var livros = new List<string>
        {
            "A culpa é das estrelas",
            "Harry Potter",
            "O Senhor dos Aneis"
        };
        
        return Ok(livros);
    }
}