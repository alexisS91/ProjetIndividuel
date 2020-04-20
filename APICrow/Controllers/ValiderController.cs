using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APICrow.Controllers
{
    public class ValiderController : ApiController
    {
        private Services.ValiderService proserv = new Services.ValiderService();

        // GET: api/Valider
        public IEnumerable<Models.Valider> Get()
        {
            return proserv.Get();
        }

        // GET: api/Valider/5
        public Models.Valider Get(int id)
        {
            return proserv.Get(id);
        }

        // POST: api/Valider
        public void Post(Models.Valider valider)
        {
            proserv.Create(valider);
        }

        // PUT: api/Valider/5
        public void Put(int id, Models.Valider valider)
        {
            proserv.Update(id, valider);

        }

        // DELETE: api/Valider/5
        public void Delete(int id)
        {
            proserv.Delete(id);
        }
    }
}
