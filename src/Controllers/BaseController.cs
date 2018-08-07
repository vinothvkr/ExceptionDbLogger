using System;
using ExceptionDbLogger.Filters;
using Microsoft.AspNetCore.Mvc;

namespace ExceptionDbLogger.Controllers
{
    [ServiceFilter(typeof(DblExceptionFilter))]
    public class BaseController : Controller
    {
    }
}