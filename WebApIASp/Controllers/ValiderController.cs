using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApIASp.Controllers
{
    public class ValiderController : Controller
    {
        Services.ValiderService valide  = new Services.ValiderService();

        // GET: Valider
        public ActionResult Index()
        {
            var val = valide.Get();
            return View(val);
        }

        // GET: Valider/Details/5
        public ActionResult Details(int id)
        {
            var val = valide.Get(id);
            return View(val);
        }

        // GET: Valider/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Valider/Create
        [HttpPost]
        public ActionResult Create(WebApIASp.Models.Valider val)
        {
            //try
            //{
            //    // TODO: Add insert logic here

            //    return RedirectToAction("Index");
            //}
            //catch
            //{
            //    return View();
            //}
            valide.Create(val);
            return RedirectToAction("Index");

        }

        // GET: Valider/Edit/5
        public ActionResult Edit(int id)
        {
            var val = valide.Get(id);
            return View(val);
        }

        // POST: Valider/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, WebApIASp.Models.Valider val)
        {
            //try
            //{
            //    // TODO: Add update logic here

            //    return RedirectToAction("Index");
            //}
            //catch
            //{
            //    return View();
            //}
            valide.Update(id, val);
            return RedirectToAction("Index");

        }

        // GET: Valider/Delete/5
        public ActionResult Delete(int id)
        {
            var val = valide.Get(id);
            return View(val);
        }

        // POST: Valider/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, WebApIASp.Models.Valider val)
        {
            try
            {
                // TODO: Add delete logic here
                valide.Delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
