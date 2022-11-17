using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using System;

namespace TP2_FundamentosAspNet_JessicaGalhardi.Controllers
{
    public class DivisionController : Controller
    {
        public IActionResult CalculateDivision(float x, float y)
        {


            ViewBag.x = x;
            ViewBag.y = y;
            ViewBag.Answer = (x / y);

            return View();
        }

    }
}
