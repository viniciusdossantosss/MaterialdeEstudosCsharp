using AutoMapper;
using WebAPI_SprintAPI_Escola.DTOs;
using WebAPI_SprintAPI_Escola.Models;
using WebAPI_SprintAPI_Escola.Repositories;

namespace WebAPI_SprintAPI_Escola.Services;

public class AlunoService : IAlunoService
{
    private readonly IAlunoRepository _repository;
    private readonly IMapper _mapper;
    
    public AlunoService(IAlunoRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }
    
    public async Task<IEnumerable<AlunoDTO>> ListarTodos()
    {
        var alunosModel = await _repository.ListarTodos();
        var alunosDTO = _mapper.Map<IEnumerable<AlunoDTO>>(alunosModel);
        return alunosDTO;
    }

    public async Task<AlunoDTO?> BuscarPorId(int id)
    {
        var alunoModel = await _repository.BuscarPorId(id);
        var alunoDTO = _mapper.Map<AlunoDTO>(alunoModel);
        return alunoDTO;
    }

    public async Task Adicionar(AlunoDTO alunoDTO)
    {
        var alunoModel = _mapper.Map<Aluno>(alunoDTO);
        await _repository.Adicionar(alunoModel);
    }
    
    public async Task Atualizar(int id, AlunoDTO alunoDTO)
    {
        var alunoModel = _mapper.Map<Aluno>(alunoDTO);
        alunoModel.IdAluno = id;
        await _repository.Atualizar(alunoModel);
    }
    
    public async Task Deletar(int id)
    {
        var alunoModel = await _repository.BuscarPorId(id);
        await _repository.Deletar(alunoModel);
    }


}