using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class AnioController : Controller
    {
        // GET: AnioController
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Bisiesto(int anio)
        {
            ViewBag.Mensaje = DateTime.IsLeapYear(anio)
          ? $"El año {anio} es bisiesto."
           : $"El año {anio} no es bisiesto.";

            return View();
        }

        // GET: AnioController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AnioController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AnioController/Create
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

        // GET: AnioController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AnioController/Edit/5
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

        // GET: AnioController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AnioController/Delete/5
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
