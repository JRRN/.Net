using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Service;

namespace MvcIoc.Controllers
{
    public class HomeController : BaseController
    {
        private readonly IServiceMapper _serviceMapper;

        [InjectionConstructor]
        public HomeController(IService service, IServiceMapper serviceMapper) : base(service)
        {
            _serviceMapper = serviceMapper;
        }

        public ActionResult Index()
        {
            _serviceMapper.ServiceMapperMethod(); // Inicializado en el constructor local
            _service.ServiceMethod(); // IOC desde el Base Controller
            return View();
        }
    }
}