using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DemoMVC.Models;
using NewCode.Model;

namespace DemoMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Books() 
        { 
            var _getBooks = new List<Books>(){
                new Books(){ID = 1, Name="Gözlerini Sımsıkı Kapat",Author = "Jules Verne",Page = 300},
                new Books(){ID = 2, Name="Gözlerini Sımsıkı Kapat 1",Author = "Jules Verne",Page = 400},
                new Books(){ID = 3, Name="Gözlerini Sımsıkı Kapat 2",Author = "Jules Verne",Page = 300}
            };
            return View(_getBooks);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
