using Inventario.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Inventario.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Inicio()
        {
            return View();
        }
        public IActionResult AgregarProducto()
        {
         var uniqueId = Guid.NewGuid().ToString();
         ViewBag.UniqueId = uniqueId;
         return View();
        }
        public IActionResult Clientes()
        {
            return View();
        }
        public IActionResult AgregarCliente()
        {
            return View();
        }
        public IActionResult Marcas()
        {
            return View();
        }
        public IActionResult AgregarMarca()
        {
            return View();
        }
        public IActionResult Categorias()
        {
            return View();
        }
        public IActionResult AgregarCategoria()
        {
            return View();
        }
        public IActionResult Empleados()
        {
            return View();
        }
        public IActionResult AgregarEmpleado()
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
