using AutoMapper;
using WebAPI_SprintAPI_Escola.Models;
using WebAPI_SprintAPI_Escola.DTOs;

namespace WebAPI_SprintAPI_Escola.Profiles;

public class ResponsavelProfile : Profile
{
    public ResponsavelProfile()
    {
        CreateMap<Responsavel, ResponsavelDTO>();
        CreateMap<ResponsavelDTO, Responsavel>();
    }
}