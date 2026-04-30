using Microsoft.AspNetCore.Mvc;
using Livros.DTOs;
using Livros.Services;

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
    public async Task<IActionResult> Get() => Ok(await _service.ListarTodasAsCategorias());

    [HttpPost]
    public async Task<IActionResult> Post(CategoriaDTO categoriaDto)
    {
        try
        {
            await _service.CriarCategoria(categoriaDto);
            return Ok("Categoria cadastrada com sucesso");
        }
        catch(Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}