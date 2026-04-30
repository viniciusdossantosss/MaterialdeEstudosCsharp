using AutoMapper;
using Livros.DTOs;
using Livros.Models;

namespace Livros.Profiles;

public class CategoriaProfile : Profile
{
    public CategoriaProfile()
    {
        CreateMap<CategoriaDTO, Categoria>();
        CreateMap<Categoria, CategoriaDTO>();
    }    
}