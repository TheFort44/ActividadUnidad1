using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class NumeroController : Controller
    {
        // GET: NumeroController
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ParImpar(int numero)
        {
            string resultado = (numero % 2 == 0)
              ? $"El número {numero} es par."
               : $"El número {numero} es impar.";

            ViewBag.Mensaje = resultado;
            return View();
        }

        // GET: NumeroController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NumeroController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NumeroController1/Create
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

        // GET: NumeroController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NumeroController1/Edit/5
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

        // GET: NumeroController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NumeroController1/Delete/5
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
