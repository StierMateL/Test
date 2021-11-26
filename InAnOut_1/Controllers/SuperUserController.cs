using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InAnOut_1.Controllers
{
    public class SuperUserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
