using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class CalculadoraController : Controller
    {
        // GET: CalculadoraController
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Suma([FromQuery] double a, [FromQuery] double b)
        {
            double resultado = a + b;
            ViewBag.Operacion = "Suma";
            ViewBag.Resultado = resultado;
            return View("Resultado");
        }

        public ActionResult Resta([FromQuery] double a, [FromQuery] double b)
        {
            double resultado = a - b;
            ViewBag.Operacion = "Resta";
            ViewBag.Resultado = resultado;
            return View("Resultado");
        }

        public ActionResult Multiplicacion([FromQuery] double a, [FromQuery] double b)
        {
            double resultado = a * b;
            ViewBag.Operacion = "Multiplicacion";
            ViewBag.Resultado = resultado;
            return View("Resultado");
        }

        public ActionResult Division([FromQuery] double a, [FromQuery] double b)
        {
            double resultado = a / b;
            ViewBag.Operacion = "Division";
            ViewBag.Resultado = resultado;
            return View("Resultado");
        }


        // GET: CalculadoraController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CalculadoraController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CalculadoraController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CalculadoraController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CalculadoraController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CalculadoraController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CalculadoraController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
