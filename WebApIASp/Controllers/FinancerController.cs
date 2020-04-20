using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApIASp.Controllers
{
    public class FinancerController : Controller
    {
        Services.FinancerService finance = new Services.FinancerService();

        // GET: Financer
        public ActionResult Index()
        {
            var fin = finance.Get();
            return View(fin);
        }

        // GET: Financer/Details/5
        public ActionResult Details(int id)
        {
            var fin = finance.Get(id);
            return View(fin);
        }

        // GET: Financer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Financer/Create
        [HttpPost]
        public ActionResult Create(WebApIASp.Models.Financer fin)
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
            finance.Create(fin);
            return RedirectToAction("Index");

        }

        // GET: Financer/Edit/5
        public ActionResult Edit(int id)
        {
            var fin = finance.Get(id);
            return View(fin);
        }

        // POST: Financer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, WebApIASp.Models.Financer fin)
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
            finance.Update(id, fin);
            return RedirectToAction("Index");

        }

        // GET: Financer/Delete/5
        public ActionResult Delete(int id)
        {
            var fin = finance.Get(id);
            return View(fin);
        }

        // POST: Financer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, WebApIASp.Models.Financer fin)
        {
            try
            {
                // TODO: Add delete logic here
                finance.Delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
