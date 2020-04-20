using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApIASp.Services;

namespace WebApIASp.Controllers
{
    
    public class UtilisateurController : Controller
    {
        UtilisateurService utilisateur = new UtilisateurService(); 
        // GET: Utilisateur
        public ActionResult Index()
        {
          var utilisateurs= utilisateur.Get();  
            return View(utilisateurs);
        }

        // GET: Utilisateur/Details/5
        public ActionResult Details(int id)
        {
            var user = utilisateur.Get(id);
            return View(user);
        }

        // GET: Utilisateur/Create
        public ActionResult Create()
        {


            return View();
        }

        // POST: Utilisateur/Create
        [HttpPost]
        public ActionResult Create(WebApIASp.Models.Utilisateur user)
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
            utilisateur.Create(user);

            return RedirectToAction("Index");
        }

        // GET: Utilisateur/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Utilisateur/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Utilisateur/Delete/5
        public ActionResult Delete(int id)
        {
            var user = utilisateur.Get(id);
            return View(user);
        }

        // POST: Utilisateur/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, WebApIASp.Models.Utilisateur user)
        {
            try
            {
                // TODO: Add delete logic here
                utilisateur.Delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
