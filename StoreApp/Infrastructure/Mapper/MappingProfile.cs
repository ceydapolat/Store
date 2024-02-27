using AutoMapper;
using Entities;
using Microsoft.AspNetCore.Identity;

namespace StoreApp;

public class MappingProfile : Profile
{   
    public MappingProfile()
    {
        CreateMap<ProductDtoForInsertion, Product>();
        CreateMap<ProductDtoForUpdate, Product>().ReverseMap();
        CreateMap<UserDtoForCreation, IdentityUser>();
        CreateMap<UserDtoForUpdate, IdentityUser>().ReverseMap();
    }
}
