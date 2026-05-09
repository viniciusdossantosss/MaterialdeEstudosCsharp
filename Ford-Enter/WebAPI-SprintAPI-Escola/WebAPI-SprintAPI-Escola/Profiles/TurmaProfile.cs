using AutoMapper;
using WebAPI_SprintAPI_Escola.Models;
using WebAPI_SprintAPI_Escola.DTOs;

namespace WebAPI_SprintAPI_Escola.Profiles;

public class TurmaProfile : Profile
{
    public TurmaProfile()
    {
        CreateMap<Turma, TurmaDTO>();
        CreateMap<TurmaDTO, Turma>();
    }
}