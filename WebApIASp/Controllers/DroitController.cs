using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApIASp.Services;


namespace WebApIASp.Controllers
{
    public class DroitController : Controller
    {
        DroitService law = new DroitService();
        // GET: Droit
        public ActionResult Index()
        {
            var droit = law.Get();
            return View(droit);
        }

        // GET: Droit/Details/5
        public ActionResult Details(int id)
        {
            var droit = law.Get(id); 
            return View(droit);
        }

        // GET: Droit/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: Droit/Create
        [HttpPost]
        public ActionResult Create(WebApIASp.Models.Droit droit)
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
            law.Create(droit); 
            return RedirectToAction("Index");

        }

        // GET: Droit/Edit/5
        public ActionResult Edit(int id)
        {
            var dr = law.Get(id);
            return View(dr);
        }

        // POST: Droit/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, WebApIASp.Models.Droit dr)
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
            law.Update(id, dr);
            return RedirectToAction("Index");

        }

        // GET: Droit/Delete/5
        public ActionResult Delete(int id)
        {
            var dr = law.Get(id);
            return View(dr);
            
        }

        // POST: Droit/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, WebApIASp.Models.Droit droit)
        {
            try
            {
                // TODO: Add delete logic here
                law.Delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
