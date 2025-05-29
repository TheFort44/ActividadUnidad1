using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class CapicuController : Controller
    {
        // GET: CapicuController
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Verificar(int numero)
        {
            string original = numero.ToString();
            string invertido = new string(original.Reverse().ToArray());

            bool esCapicua = original == invertido;

            ViewBag.Mensaje = esCapicua
                ? $"El número {numero} es capicúa."
                : $"El número {numero} no es capicúa.";

            return View();
        }

        // GET: CapicuController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CapicuController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CapicuController1/Create
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

        // GET: CapicuController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CapicuController1/Edit/5
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

        // GET: CapicuController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CapicuController1/Delete/5
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
