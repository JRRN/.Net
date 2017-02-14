using Domain.Configuration;
using Microsoft.Practices.Unity;

namespace Domain.Logic.Configuration
{
    public class DomainConfig : IDomainConfig
    {
        public void Configure(IUnityContainer container)
        {
            container.RegisterType<IAutomapperDomainContainer, AutommaperDomainContainer>();
        }
    }
}