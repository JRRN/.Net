using AutoMapper;

namespace Domain.Logic.Configuration
{
    public class AutomapperDomainProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<Repository.Model.RepositoryExampleModel, Domain.Model.DomainExampleModel>();
            CreateMap<Domain.Model.DomainExampleModel, Repository.Model.RepositoryExampleModel>();
        }
    }
}