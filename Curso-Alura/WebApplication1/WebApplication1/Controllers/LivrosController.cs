using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;


[Route("api/[controller]")]
[ApiController]

public class LivrosController : Controller
{
    [HttpGet]
    public  IActionResult GetLivros()
    {
        var livros = new List<String>
        {
            "A culpa das estrelas",
            "Harry Potter",
            "O senhor dos Aneis"
        };

        return Ok(livros);
    }
    
    [HttpGet("boas-vindas")]
    public IActionResult GetBoasVindas()
    {
        var mensagem = "Bem vindo ao sistema de livros!!";

        return Ok(mensagem);
    }
}