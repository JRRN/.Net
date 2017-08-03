using System.Collections.Generic;
using Domain.Configuration;
using Service.Confgiuration;
using Service.Logic.Configuration;

namespace Service.Logic.Configuration
{
    public class AutomapperProfileService : IAutomapperProfileService
    {
        private readonly List<IAutommaperProfileContainer> _profiles = new List<IAutommaperProfileContainer>();
        public AutomapperProfileService(IAutomapperDomainContainer domainProfile)
        {
            _profiles.Add(domainProfile);
        }
        public List<IAutommaperProfileContainer> GetProfiles()
        {
            return _profiles;
        }
    }
}