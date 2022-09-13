using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata.Ecma335;

namespace mvc.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Soma(int valor1, int valor2) { 

        var total = valor1 + valor2;
        return Ok(total);
        }
        public IActionResult Subtrai(int valor1, int valor2)
        {

            var total = valor1 - valor2;
            return Ok(total);
        }
        public IActionResult Multiplica(int valor1, int valor2)
        {

            var total = valor1 * valor2;
            return Ok(total);
        }
        public IActionResult Divide(int valor1, int valor2)
        {

            var total = valor1 / valor2;
            return Ok(total);
        }
    }
}
