using Microsoft.AspNetCore.Mvc;
using WebAPI_SprintAPI_Escola.Services;
using WebAPI_SprintAPI_Escola.DTOs;

namespace WebAPI_SprintAPI_Escola.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ResponsavelController : ControllerBase
{
    private readonly IResponsavelService _service;

    public ResponsavelController(IResponsavelService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> ListarTodos()
    {
        var responsaveis = await _service.ListarTodos();
        return Ok(responsaveis);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> BuscarPorId(int id)
    {
        var responsavel = await _service.BuscarPorId(id);
        
        if (responsavel == null)
        {
            return NotFound("Responsável não encontrado."); 
        }

        return Ok(responsavel);
    }

    [HttpPost]
    public async Task<IActionResult> Adicionar([FromBody] ResponsavelDTO responsavelDto)
    {
        await _service.Adicionar(responsavelDto);
        return Ok("Responsável cadastrado com sucesso!");
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Atualizar(int id, [FromBody] ResponsavelDTO responsavelDto)
    {
        var responsavelExistente = await _service.BuscarPorId(id);
        
        if (responsavelExistente == null)
        {
            return NotFound("Responsável não encontrado para atualização.");
        }

        await _service.Atualizar(id, responsavelDto);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Deletar(int id)
    {
        var responsavelExistente = await _service.BuscarPorId(id);
        
        if (responsavelExistente == null)
        {
            return NotFound("Responsável não encontrado para exclusão.");
        }

        await _service.Deletar(id);
        return NoContent(); 
    }
}