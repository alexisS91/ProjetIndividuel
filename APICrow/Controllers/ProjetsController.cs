using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DalDB; 

namespace APICrow.Controllers
{
    public class ProjetsController : ApiController
    {
        // private DalDB.PateFormeEntities db = new DalDB.PateFormeEntities();
        // private DalDB.Services.ProjetRepository projet = new DalDB.Services.ProjetRepository();
        private Services.ProjetService proserv = new Services.ProjetService();
        // GET: api/Projets
        public IEnumerable<Models.Projet> Get()
        {

            return proserv.Get();
        }

        // GET: api/Projets/5
        public Models.Projet Get(int id)
        {
            return proserv.Get(id);
        }

        // POST: api/Projets
        public void Post(Models.Projet projet)
        {
            proserv.Create(projet);
        }

        // PUT: api/Projets/5
        public void Put(int id, Models.Projet projet)
        {
            proserv.Update(id, projet);

        }

        // DELETE: api/Projets/5
        public void Delete(int id)
        {
            proserv.Delete(id);
        }
    }
}
