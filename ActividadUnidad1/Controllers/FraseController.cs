using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class FraseController : Controller
    {
        // GET: FraseController1
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ContarPalabras(String frase)
        {
            int cantidad = 0;

            if (!string.IsNullOrWhiteSpace(frase))
            {
                var palabras = frase.Split(' ', System.StringSplitOptions.RemoveEmptyEntries);
                cantidad = palabras.Length;
            }

            ViewBag.Mensaje = $"La frase contiene {cantidad} palabra(s).";

            return View();
        }

        // GET: FraseController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FraseController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FraseController1/Create
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

        // GET: FraseController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FraseController1/Edit/5
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

        // GET: FraseController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FraseController1/Delete/5
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
