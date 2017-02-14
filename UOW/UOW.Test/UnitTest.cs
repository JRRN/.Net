using System;
using Microsoft.Practices.Unity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repository.Logic.Context;
using Repository.Repositories;

namespace UOW.Test
{
    [TestClass]
    public class UnitTest
    {
        protected readonly IRepository<Employee> _employeRepository;

        public UnitTest(IRepository<Employee> employeRepository)
        {
            _employeRepository = employeRepository;
        }

        [TestMethod]
        public void TestMethod1()
        {
            var results = _employeRepository.QueryAll();
            Assert.IsNotNull(results);
        }
    }
}
