using Microsoft.Practices.Unity;

namespace Service.Confgiuration
{
    public interface IServicesConfig
    {
        void Configure(IUnityContainer container);
    }
}