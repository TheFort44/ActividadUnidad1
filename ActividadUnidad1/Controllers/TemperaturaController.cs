using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class TemperaturaController : Controller
    {
        // GET: TemperaturaController
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Convertir(double celsius)
        {
            double fahrenheit = (celsius * 9 / 5) + 32;

            ViewBag.Celsius = celsius;
            ViewBag.Fahrenheit = fahrenheit;

            return View();
        }

        // GET: TemperaturaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TemperaturaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TemperaturaController/Create
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

        // GET: TemperaturaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TemperaturaController/Edit/5
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

        // GET: TemperaturaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TemperaturaController/Delete/5
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
