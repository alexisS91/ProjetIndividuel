using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APICrow.Controllers
{
    public class UtilisateurController : ApiController
    {

        private Services.UtilisateurService proserv = new Services.UtilisateurService();
        // GET: api/Utilisateur
        public IEnumerable<Models.Utilisateur> Get()
        {

            return proserv.Get();
        }

        // GET: api/Utilisateur/5
        public Models.Utilisateur Get(int id)
        {
            return proserv.Get(id);
        }

        // POST: api/Utilisateur
        public void Post(int id, Models.Utilisateur utilisateur)
        {
            proserv.Create(utilisateur);
        }

        // PUT: api/Utilisateur/5
        public void Put(int id, Models.Utilisateur utilisateur)
        {
            proserv.Update(id, utilisateur);

        }

        // DELETE: api/Utilisateur/5
        public void Delete(int id)
        {
            proserv.Delete(id);
        }
    }
}
