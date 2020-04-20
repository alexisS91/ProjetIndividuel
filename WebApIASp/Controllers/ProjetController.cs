using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApIASp.Controllers
{
    public class ProjetController : Controller
    {
        Services.ProjetService projet = new Services.ProjetService();

        // GET: Projet
        public ActionResult Index()
        {
            var pro = projet.Get();
            return View(pro);
        }

        // GET: Projet/Details/5
        public ActionResult Details(int id)
        {
            var pro = projet.Get(id);
            return View(pro);
         
        }

        // GET: Projet/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Projet/Create
        [HttpPost]
        public ActionResult Create(WebApIASp.Models.Projet pro)
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
            projet.Create(pro);
              return RedirectToAction("Index");

        }

        // GET: Projet/Edit/5
        public ActionResult Edit(int id)
        {
            var pro = projet.Get(id);
            return View(pro);
        }

        // POST: Projet/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, WebApIASp.Models.Projet proj)
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

            projet.Update(id, proj);
            return RedirectToAction("Index");

        }

        // GET: Projet/Delete/5
        public ActionResult Delete(int id)
        {
            var pro = projet.Get(id);
            return View(pro);
        }

        // POST: Projet/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, WebApIASp.Models.Projet pro)
        {
            try
            {
                // TODO: Add delete logic here
                projet.Delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
