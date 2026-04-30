using AutoMapper;
using Livros.DTOs;
using Livros.Models;

namespace Livros.Profiles;

public class LivroProfile : Profile
{
    public LivroProfile()
    {
        CreateMap<LivroDTO, Livro>();
        CreateMap<Livro, LivroDTO>();
    }    
}