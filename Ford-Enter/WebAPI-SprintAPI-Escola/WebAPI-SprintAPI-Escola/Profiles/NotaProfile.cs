using AutoMapper;
using WebAPI_SprintAPI_Escola.Models;
using WebAPI_SprintAPI_Escola.DTOs;

namespace WebAPI_SprintAPI_Escola.Profiles;

public class NotaProfile : Profile
{
    public NotaProfile()
    {
        CreateMap<Nota, NotaDTO>();
        CreateMap<NotaDTO, Nota>();
    }
}