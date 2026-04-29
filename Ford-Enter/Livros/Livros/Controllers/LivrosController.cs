using Livros.DTOs;
using Livros.Models;
using Livros.Repositories;
using Livros.Services;
using Microsoft.AspNetCore.Mvc;

namespace Livros.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class LivrosController : ControllerBase
    {
        private readonly ILivroService _service;

        public LivrosController(ILivroService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get() => Ok(await _service.ListarTodosOsLivros());

        [HttpPost]
        public async Task<IActionResult> Post(LivroDTO livroDTO)
        {
            try
            {
                await _service.Criar(livroDTO);
                return Ok("Livro cadastrado com sucesso");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
