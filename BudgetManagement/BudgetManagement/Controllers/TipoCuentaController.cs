using BudgetManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace BudgetManagement.Controllers
{
    public class TipoCuentaController : Controller
    {
        public IActionResult CrearCuenta()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CrearCuenta(TipoCuenta tipoCuenta)
        {
            return View();
        }
    }

}
