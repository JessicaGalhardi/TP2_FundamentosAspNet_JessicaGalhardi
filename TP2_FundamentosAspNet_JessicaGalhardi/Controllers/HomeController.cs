using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TP2_FundamentosAspNet_JessicaGalhardi.Models;

namespace TP2_FundamentosAspNet_JessicaGalhardi.Controllers
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


    }
}
