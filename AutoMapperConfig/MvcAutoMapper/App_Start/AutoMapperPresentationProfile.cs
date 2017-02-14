
using AutoMapper;

namespace MvcAutoMapper.App_Start
{
    public class AutoMapperPresentationProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<Domain.Model.DomainExampleModel, Models.UIExampleModel>();
            CreateMap<Models.UIExampleModel, Domain.Model.DomainExampleModel>();
        }
    }
}