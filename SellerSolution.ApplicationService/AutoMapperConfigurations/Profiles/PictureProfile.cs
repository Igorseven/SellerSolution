using AutoMapper;
using SellerSolution.ApplicationService.Responses.Picture;
using SellerSolution.Domain.Entities;

namespace SellerSolution.ApplicationService.AutoMapperConfigurations.Profiles
{
    public class PictureProfile : Profile
    {
        public PictureProfile()
        {
            CreateMap<Picture, PictureResponse>()
                .ReverseMap();
        }
    }
}
