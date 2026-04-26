using AutoMapper;
using CriandoUmaWebAPI.Data.Dtos;
using CriandoUmaWebAPI.Models;

namespace CriandoUmaWebAPI.Profiles;

public class FilmeProfile : Profile
{
    public FilmeProfile()
    {
        CreateMap<CreateFilmeDto, Filme>();
        CreateMap<UpdateFilmeDto, Filme>();
        CreateMap<Filme, UpdateFilmeDto>();
    }
}