using Microsoft.AspNetCore.Mvc;
using WebAPI_SprintAPI_Escola.Services;
using WebAPI_SprintAPI_Escola.DTOs;

namespace WebAPI_SprintAPI_Escola.Controllers;

[ApiController]
[Route("api/[controller]")]
public class NotaController : ControllerBase
{
    private readonly INotaService _service;

    public NotaController(INotaService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> ListarTodos()
    {
        var notas = await _service.ListarTodos();
        return Ok(notas);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> BuscarPorId(int id)
    {
        var nota = await _service.BuscarPorId(id);
        
        if (nota == null)
        {
            return NotFound("Nota não encontrada."); 
        }

        return Ok(nota);
    }

    [HttpPost]
    public async Task<IActionResult> Adicionar([FromBody] NotaDTO notaDto)
    {
        await _service.Adicionar(notaDto);
        return Ok("Nota cadastrada com sucesso!");
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Atualizar(int id, [FromBody] NotaDTO notaDto)
    {
        var notaExistente = await _service.BuscarPorId(id);
        
        if (notaExistente == null)
        {
            return NotFound("Nota não encontrada para atualização.");
        }

        await _service.Atualizar(id, notaDto);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Deletar(int id)
    {
        var notaExistente = await _service.BuscarPorId(id);
        
        if (notaExistente == null)
        {
            return NotFound("Nota não encontrada para exclusão.");
        }

        await _service.Deletar(id);
        return NoContent(); 
    }
}