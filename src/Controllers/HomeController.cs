using System;
using Microsoft.AspNetCore.Mvc;

namespace ExceptionDbLogger.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            return Content("Hello World");
        }

        public IActionResult AppError()
        {
            throw new Exception("Let's log the exception");
        }
    }
}