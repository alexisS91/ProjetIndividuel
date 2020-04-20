using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApIASp.Controllers
{
    public class PalierController : Controller
    {
        Services.PalierService pale = new Services.PalierService();

        // GET: Palier
        public ActionResult Index()
        {

            var pal = pale.Get();
            return View(pal);
        }

        // GET: Palier/Details/5
        public ActionResult Details(int id)
        {
            var pal = pale.Get(id);
            return View(pal);
        }

        // GET: Palier/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Palier/Create
        [HttpPost]
        public ActionResult Create(WebApIASp.Models.Palier pal)
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
            pale.Create(pal);
           return RedirectToAction("Index");

        }

        // GET: Palier/Edit/5
        public ActionResult Edit(int id)
        {
            var pal = pale.Get(id);
            return View(pal);
        }

        // POST: Palier/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, WebApIASp.Models.Palier pal)
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
            pale.Update(id, pal);
            return RedirectToAction("Index");
        }

        // GET: Palier/Delete/5
        public ActionResult Delete(int id)
        {
            var pal = pale.Get(id);

            return View(pal);
        }

        // POST: Palier/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, WebApIASp.Models.Palier pa)
        {
            try
            {
                // TODO: Add delete logic here
                pale.Delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
