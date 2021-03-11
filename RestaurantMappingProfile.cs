using AutoMapper;
using RestaurantAPI.Entities;
using RestaurantAPI.Models;

namespace RestaurantAPI
{
    public class RestaurantMappingProfile : Profile
    {
        public RestaurantMappingProfile()
        {
            CreateMap<Restaurant, RestaurantDto>()
                .ForMember(m => m.City, m => m.MapFrom(s => s.Address.City))
                .ForMember(m => m.Street, m => m.MapFrom(s => s.Address.Street))
                .ForMember(m => m.PostalCode, m => m.MapFrom(s => s.Address.PostalCode));

            CreateMap<Dish, DishDto>();

        }
    }
}
