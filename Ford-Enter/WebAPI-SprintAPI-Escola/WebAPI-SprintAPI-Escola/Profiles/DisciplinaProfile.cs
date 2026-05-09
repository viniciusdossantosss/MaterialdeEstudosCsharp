using AutoMapper;
using WebAPI_SprintAPI_Escola.Models;
using WebAPI_SprintAPI_Escola.DTOs;

namespace WebAPI_SprintAPI_Escola.Profiles;

public class DisciplinaProfile : Profile
{
    public DisciplinaProfile()
    {
        CreateMap<Disciplina, DisciplinaDTO>();
        CreateMap<DisciplinaDTO, Disciplina>();
    }
}