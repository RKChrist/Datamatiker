using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CalculatorMVC.Models;
using System.Net.Http;
using System.IO;

namespace CalculatorMVC.Controllers
{

    public class HomeController : Controller
    {
        object _lock = new object();
        private readonly ILogger<HomeController> _logger;
        private readonly ICalculate _cProxy;

        public HomeController(ILogger<HomeController> logger, ICalculate cProxy)
        {
            _logger = logger;
            _cProxy = cProxy;
        }

        public async Task<IActionResult> Index(int a, int b, string operatorName)
        {
            var result = 0;
            switch(operatorName)
            {
                case "add":
                    result = await _cProxy.Add(a,b);
                    break;
                case "subtract":
                    result = await _cProxy.Subtract(a,b);
                    break;
                
            }
           ViewBag.Result = result;
            return View();
        }
        public async Task<IActionResult> Download()
        {
            var stream = await _cProxy.Download();
            return File(stream, "text/plain", "Diploma.txt"); 
            
            
        }
 

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
