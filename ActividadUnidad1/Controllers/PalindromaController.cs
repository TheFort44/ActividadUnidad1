using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class PalindromaController : Controller
    {
        // GET: PalindromaController
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Palabra(String texto)
        {
            var palabra = texto.ToLower();
            var invertida = new string(palabra.Reverse().ToArray());
            bool esPalindroma = palabra == invertida;

            ViewBag.Resultado = esPalindroma ? "Es palíndroma" : "No es palíndroma";
            return View();
        }

        // GET: PalindromaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PalindromaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PalindromaController/Create
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

        // GET: PalindromaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PalindromaController/Edit/5
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

        // GET: PalindromaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PalindromaController/Delete/5
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
