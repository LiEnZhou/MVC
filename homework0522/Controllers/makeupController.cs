using homework0522.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace homework0522.Controllers
{
    public class makeupController : Controller
    {
        private static List<Makeup> _makeups = new List<Makeup>()
        {
            new Makeup(){Id = 1, Name = "唇膏", price = 500, color = "red"},
            new Makeup(){Id = 2, Name = "眼線", price = 450, color = "black"}
        };
        // GET: makeup
        public ActionResult Index()
        {
            return View(_makeups);
        }

        // GET: makeup/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: makeup/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: makeup/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Makeup Model)
        {
            try
            {
              _makeups.Add(Model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: makeup/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: makeup/Edit/5
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

        // GET: makeup/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: makeup/Delete/5
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
