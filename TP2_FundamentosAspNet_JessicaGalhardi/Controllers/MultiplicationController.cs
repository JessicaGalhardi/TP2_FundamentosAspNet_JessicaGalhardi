using Microsoft.AspNetCore.Mvc;

namespace TP2_FundamentosAspNet_JessicaGalhardi.Controllers
{
    public class MultiplicationController : Controller
    {
        public IActionResult CalculateMultiplication(float x, float y)
        {

            ViewBag.x = x;
            ViewBag.y = y;
            ViewBag.Answer = (x * y);

            return View();
        }
    }
}
