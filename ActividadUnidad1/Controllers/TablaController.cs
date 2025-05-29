using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class TablaController : Controller
    {
        // GET: TablaController
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Multiplicar(int numero)
        {
            List<string> tabla = new List<string>();

            for (int i = 1; i <= 10; i++)
            {
                tabla.Add($"{numero} x {i} = {numero * i}");
            }

            ViewBag.Tabla = tabla;
            ViewBag.Numero = numero;
            return View();
        }

        // GET: TablaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TablaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TablaController/Create
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

        // GET: TablaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TablaController/Edit/5
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

        // GET: TablaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TablaController/Delete/5
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
