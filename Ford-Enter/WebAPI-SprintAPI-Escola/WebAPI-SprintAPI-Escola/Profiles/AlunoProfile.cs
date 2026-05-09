using AutoMapper;
using WebAPI_SprintAPI_Escola.DTOs;
using WebAPI_SprintAPI_Escola.Models;
    

namespace WebAPI_SprintAPI_Escola.Profiles;

public class AlunoProfile : Profile
{
    public AlunoProfile()
    {
        CreateMap<AlunoDTO, Aluno>().ReverseMap();
    }
}