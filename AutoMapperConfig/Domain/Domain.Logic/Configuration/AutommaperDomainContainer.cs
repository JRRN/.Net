using AutoMapper;
using Domain.Configuration;

namespace Domain.Logic.Configuration
{
    public class AutommaperDomainContainer : IAutomapperDomainContainer
    {
        private static readonly AutomapperDomainProfile _domainProfile = new AutomapperDomainProfile();
        public Profile GetProfile()
        {
            return _domainProfile;
        }
    }
}