using Calculator.Models;
using Microsoft.AspNetCore.Mvc;

namespace Calculator.Controllers
{
    public class CalculatorController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {

            return View(new Calc());
        }

        [HttpPost]
        public IActionResult Add(Calc c) 
        {
            c.Total = Convert.ToInt32(c.Num1) + Convert.ToInt32(c.Num2);
            return View(c);
        }

        public IActionResult Divide(Calc c)
        {
            if (Convert.ToInt32(c.Num2) == 0)
                throw new DivideByZeroException();

            c.Quotient = Convert.ToInt32(c.Num1) / Convert.ToInt32(c.Num2);

            return View(c);
        }
    }
}
