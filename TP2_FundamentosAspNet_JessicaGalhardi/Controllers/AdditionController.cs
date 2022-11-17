using Microsoft.AspNetCore.Mvc;

namespace TP2_FundamentosAspNet_JessicaGalhardi.Controllers
{
    public class AdditionController : Controller
    {
        public IActionResult CalculateAddition(float x, float y)
        {

            ViewBag.x = x;
            ViewBag.y = y;
            ViewBag.Answer = (x + y);

            return View();
        }
    }
}
