using Microsoft.AspNetCore.Mvc;
using Livros.DTOs;

namespace Livros.Controllers;

[Route("api/[controller]")]
[ApiController]

public class CategoriaController : ControllerBase
{
    private readonly ICategoriaService _service;

    public CategoriaController(ICategoriaService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> Get() => Ok(await _service.ListarTodosAsCategorias());

    [HttpPost]
    public async Task<IActionResult> Post(CategoriaDTO categoriaDto)
    {
        try
        {
            await 
        }
    }
}