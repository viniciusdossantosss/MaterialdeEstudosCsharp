using AutoMapper;
using WebAPI_SprintAPI_Escola.DTOs;
using WebAPI_SprintAPI_Escola.Models;
using WebAPI_SprintAPI_Escola.Repositories;

namespace WebAPI_SprintAPI_Escola.Services;

public class ResponsavelService : IResponsavelService
{
    private readonly IResponsavelRepository _repository;
    private readonly IMapper _mapper;

    public ResponsavelService(IResponsavelRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<ResponsavelDTO>> ListarTodos()
    {
        var responsaveisModel = await _repository.ListarTodos();
        return _mapper.Map<IEnumerable<ResponsavelDTO>>(responsaveisModel);
    }

    public async Task<ResponsavelDTO?> BuscarPorId(int id)
    {
        var responsavelModel = await _repository.BuscarPorId(id);
        return _mapper.Map<ResponsavelDTO>(responsavelModel);
    }

    public async Task Adicionar(ResponsavelDTO responsavelDto)
    {
        var responsavelModel = _mapper.Map<Responsavel>(responsavelDto);
        await _repository.Adicionar(responsavelModel);
    }

    public async Task Atualizar(int id, ResponsavelDTO responsavelDto)
    {
        var responsavelModel = _mapper.Map<Responsavel>(responsavelDto);
        responsavelModel.IdResponsavel = id;
        await _repository.Atualizar(responsavelModel);
    }

    public async Task Deletar(int id)
    {
        var responsavelModel = await _repository.BuscarPorId(id);
        if (responsavelModel != null)
        {
            await _repository.Deletar(responsavelModel);
        }
    }
}