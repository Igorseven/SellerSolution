using AutoMapper;
using SellerSolution.ApplicationService.Responses.Product;
using SellerSolution.Domain.Entities;

namespace SellerSolution.ApplicationService.AutoMapperConfigurations.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductResponse>()
                .ForMember(pr => pr.PictureResponses, map => map.MapFrom(p => p.Pictures))
                .ReverseMap();
        }
    }
}
