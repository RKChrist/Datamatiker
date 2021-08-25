using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExploreCalifornia.Controllers
{
    public class HomeController : Controller
    {
        //Get :
        //This method is called an action
        //In ASP NET.CORE controllers is just an container for actions.
        public IActionResult Index()
        {
            return View();
        }
    }
}
