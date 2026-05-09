using Microsoft.AspNetCore.Mvc;
using WebAPI_SprintAPI_Escola.Services;
using WebAPI_SprintAPI_Escola.DTOs;

namespace WebAPI_SprintAPI_Escola.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AlunoController : ControllerBase
{
    private readonly IAlunoService _service;

    // Construtor: Aqui fazemos a injeção do IAlunoService
    public AlunoController(IAlunoService service)
    {
        _service = service;
    }

    // Endpoint para buscar todos os alunos
    [HttpGet]
    public async Task<IActionResult> ListarTodos()
    {
        var alunos = await _service.ListarTodos();
        return Ok(alunos); // Retorna 200 OK com a lista de alunos
    }

    // Endpoint para buscar um aluno específico pelo ID
    [HttpGet("{id}")]
    public async Task<IActionResult> BuscarPorId(int id)
    {
        var aluno = await _service.BuscarPorId(id);
        
        // Verifica se o aluno existe. Se não existir, retorna 404.
        if (aluno == null)
        {
            return NotFound("Aluno não encontrado."); 
        }

        // Se existir, retorna os dados do aluno.
        return Ok(aluno);
    }

    // Endpoint para adicionar um novo aluno
    [HttpPost]
    public async Task<IActionResult> Adicionar([FromBody] AlunoDTO alunoDto)
    {
        // Chama o serviço para adicionar o aluno
        await _service.Adicionar(alunoDto);

        return Ok("Aluno cadastrado com sucesso!");
    }

    // Endpoint para atualizar os dados de um aluno
    [HttpPut("{id}")]
    public async Task<IActionResult> Atualizar(int id, [FromBody] AlunoDTO alunoDto)
    {
        // 1. Verifica se o aluno realmente existe antes de tentar atualizar
        var alunoExistente = await _service.BuscarPorId(id);
        
        if (alunoExistente == null)
        {
            return NotFound("Aluno não encontrado para atualização.");
        }

        // 2. Se o aluno existir, chama o serviço para atualizar
        await _service.Atualizar(id, alunoDto);

        // 3. Retorna NoContent (204) ou Ok (200). 
        // 204 NoContent é muito comum porque a atualização deu certo, mas não temos o que devolver na tela.
        return NoContent();
    }

    // Endpoint para deletar um aluno
    [HttpDelete("{id}")]
    public async Task<IActionResult> Deletar(int id)
    {
        // 1. Verifica se o aluno existe
        var alunoExistente = await _service.BuscarPorId(id);
        
        if (alunoExistente == null)
        {
            return NotFound("Aluno não encontrado para exclusão.");
        }

        // 2. Chama o serviço para deletar o aluno
        await _service.Deletar(id);

        // 3. Retorna NoContent (204) ou Ok.
        return NoContent();
    }
}