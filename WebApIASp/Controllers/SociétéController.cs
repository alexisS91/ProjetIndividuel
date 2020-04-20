using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApIASp.Controllers
{
    public class SociétéController : Controller
    {
        Services.SociétéService société = new Services.SociétéService();

        // GET: Société
        public ActionResult Index()
        {
            var soc = société.Get();
            return View(soc);
        }

        // GET: Société/Details/5
        public ActionResult Details(int id)
        {
            var soc = société.Get(id);
            return View(soc);
        }

        // GET: Société/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: Société/Create
        [HttpPost]
        public ActionResult Create(WebApIASp.Models.Société soc)
        {
            //    try
            //    {
            //        // TODO: Add insert logic here

            //        return RedirectToAction("Index");
            //    }
            //    catch
            //    {
            //        return View();
            //    }
            société.Create(soc);
            return RedirectToAction("Index");

        }

    // GET: Société/Edit/5
    public ActionResult Edit(int id)
        {
            var soc = société.Get(id);

            return View(soc);
        }

        // POST: Société/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, WebApIASp.Models.Société soc)
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
            société.Update(id, soc);
            return RedirectToAction("Index");

        }

        // GET: Société/Delete/5
        public ActionResult Delete(int id)
        {
            var soc = société.Get(id);
            return View(soc);
        }

        // POST: Société/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, WebApIASp.Models.Société soc)
        {
            try
            {
                // TODO: Add delete logic here
                société.Delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
