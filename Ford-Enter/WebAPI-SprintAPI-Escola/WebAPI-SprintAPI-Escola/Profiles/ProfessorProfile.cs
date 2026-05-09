using AutoMapper;
using WebAPI_SprintAPI_Escola.Models;
using WebAPI_SprintAPI_Escola.DTOs;

namespace WebAPI_SprintAPI_Escola.Profiles;

public class ProfessorProfile : Profile
{
    public ProfessorProfile()
    {
        CreateMap<Professor, ProfessorDTO>();
        CreateMap<ProfessorDTO, Professor>();
    }
}