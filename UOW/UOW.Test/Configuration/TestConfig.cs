using Microsoft.Practices.Unity;
using Repository.Logic.Context;
using Repository.Logic.Repositories.Base;
using Repository.Repositories;

namespace UOW.Test.Configuration
{
    public class TestConfig
    {
        public void Configure(UnityContainer container)
        {
            container.RegisterType<IRepository<Employee>, Repository<Employee>>();
        }
    }
}