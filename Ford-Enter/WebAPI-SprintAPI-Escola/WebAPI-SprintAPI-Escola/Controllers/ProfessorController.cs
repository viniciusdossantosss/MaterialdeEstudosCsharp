using Microsoft.AspNetCore.Mvc;
using WebAPI_SprintAPI_Escola.Services;
using WebAPI_SprintAPI_Escola.DTOs;

namespace WebAPI_SprintAPI_Escola.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProfessorController : ControllerBase
{
    private readonly IProfessorService _service;

    public ProfessorController(IProfessorService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> ListarTodos()
    {
        var professores = await _service.ListarTodos();
        return Ok(professores);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> BuscarPorId(int id)
    {
        var professor = await _service.BuscarPorId(id);
        
        if (professor == null)
        {
            return NotFound("Professor não encontrado."); 
        }

        return Ok(professor);
    }

    [HttpPost]
    public async Task<IActionResult> Adicionar([FromBody] ProfessorDTO professorDto)
    {
        await _service.Adicionar(professorDto);
        return Ok("Professor cadastrado com sucesso!");
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Atualizar(int id, [FromBody] ProfessorDTO professorDto)
    {
        var professorExistente = await _service.BuscarPorId(id);
        
        if (professorExistente == null)
        {
            return NotFound("Professor não encontrado para atualização.");
        }

        await _service.Atualizar(id, professorDto);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Deletar(int id)
    {
        var professorExistente = await _service.BuscarPorId(id);
        
        if (professorExistente == null)
        {
            return NotFound("Professor não encontrado para exclusão.");
        }

        await _service.Deletar(id);
        return NoContent(); 
    }
}