using AutoMapper;
using Core.Domain;

namespace Core
{
    public class AppMapper : Profile
    {
        public AppMapper()
        {
            CreateMap<Product, ProductDTO>();
        }
    }
}