using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class ClaveController : Controller
    {
        // GET: ClaveController
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult segura(string clave)
        {
            if (clave.Length >= 8 &&
             clave.Any(c => char.IsUpper(c)) &&
             clave.Any(c => char.IsDigit(c)))
            {
                ViewBag.Mensaje = "La contraseña es segura.";
            }
            else
            {
                ViewBag.Mensaje = "La contraseña no es segura.";
            }

            return View();
        }

        // GET: ClaveController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ClaveController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClaveController/Create
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

        // GET: ClaveController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClaveController/Edit/5
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

        // GET: ClaveController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClaveController/Delete/5
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
