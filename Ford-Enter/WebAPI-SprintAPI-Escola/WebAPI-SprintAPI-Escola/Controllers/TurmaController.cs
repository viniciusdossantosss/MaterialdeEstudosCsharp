using Microsoft.AspNetCore.Mvc;
using WebAPI_SprintAPI_Escola.Services;
using WebAPI_SprintAPI_Escola.DTOs;

namespace WebAPI_SprintAPI_Escola.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TurmaController : ControllerBase
{
    private readonly ITurmaService _service;

    public TurmaController(ITurmaService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> ListarTodos()
    {
        var turmas = await _service.ListarTodos();
        return Ok(turmas);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> BuscarPorId(int id)
    {
        var turma = await _service.BuscarPorId(id);
        
        if (turma == null)
        {
            return NotFound("Turma não encontrada."); 
        }

        return Ok(turma);
    }

    [HttpPost]
    public async Task<IActionResult> Adicionar([FromBody] TurmaDTO turmaDto)
    {
        await _service.Adicionar(turmaDto);
        return Ok("Turma cadastrada com sucesso!");
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Atualizar(int id, [FromBody] TurmaDTO turmaDto)
    {
        var turmaExistente = await _service.BuscarPorId(id);
        
        if (turmaExistente == null)
        {
            return NotFound("Turma não encontrada para atualização.");
        }

        await _service.Atualizar(id, turmaDto);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Deletar(int id)
    {
        var turmaExistente = await _service.BuscarPorId(id);
        
        if (turmaExistente == null)
        {
            return NotFound("Turma não encontrada para exclusão.");
        }

        await _service.Deletar(id);
        return NoContent(); 
    }
}