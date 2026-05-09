using Microsoft.AspNetCore.Mvc;
using WebAPI_SprintAPI_Escola.Services;
using WebAPI_SprintAPI_Escola.DTOs;

namespace WebAPI_SprintAPI_Escola.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DisciplinaController : ControllerBase
{
    private readonly IDisciplinaService _service;

    public DisciplinaController(IDisciplinaService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> ListarTodos()
    {
        var disciplinas = await _service.ListarTodos();
        return Ok(disciplinas);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> BuscarPorId(int id)
    {
        var disciplina = await _service.BuscarPorId(id);
        
        if (disciplina == null)
        {
            return NotFound("Disciplina não encontrada."); 
        }

        return Ok(disciplina);
    }

    [HttpPost]
    public async Task<IActionResult> Adicionar([FromBody] DisciplinaDTO disciplinaDto)
    {
        await _service.Adicionar(disciplinaDto);
        return Ok("Disciplina cadastrada com sucesso!");
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Atualizar(int id, [FromBody] DisciplinaDTO disciplinaDto)
    {
        var disciplinaExistente = await _service.BuscarPorId(id);
        
        if (disciplinaExistente == null)
        {
            return NotFound("Disciplina não encontrada para atualização.");
        }

        await _service.Atualizar(id, disciplinaDto);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Deletar(int id)
    {
        var disciplinaExistente = await _service.BuscarPorId(id);
        
        if (disciplinaExistente == null)
        {
            return NotFound("Disciplina não encontrada para exclusão.");
        }

        await _service.Deletar(id);
        return NoContent(); 
    }
}