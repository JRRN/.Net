using System.Collections.Generic;
using Domain.Configuration;

namespace Service.Confgiuration
{
    public interface IAutomapperProfileService
    {
        List<IAutommaperProfileContainer> GetProfiles();
    }
}