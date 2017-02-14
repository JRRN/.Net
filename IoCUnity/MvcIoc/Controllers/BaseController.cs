using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Service;

namespace MvcIoc.Controllers
{
    public class BaseController : Controller
    {
        protected readonly IService _service;

        [InjectionConstructor]
        public BaseController(IService service)
        {
            _service = service;
        }

    }
}