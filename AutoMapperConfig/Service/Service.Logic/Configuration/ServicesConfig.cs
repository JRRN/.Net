using Domain.Configuration;
using Domain.Logic.Configuration;
using Microsoft.Practices.Unity;
using Service.Confgiuration;

namespace Service.Logic.Configuration
{
    public class ServicesConfig : IServicesConfig
    {
        public void Configure(IUnityContainer container)
        {
            RegisterDomain(container);
        }

        private void RegisterDomain(IUnityContainer container)
        {
            container.RegisterType<IDomainConfig, DomainConfig>();
            container.RegisterType<IAutomapperDomainContainer, AutommaperDomainContainer>();
        }
    }

}