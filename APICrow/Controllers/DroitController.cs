using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APICrow.Controllers
{
    public class DroitController : ApiController
    {
        private Services.DroitService proserv = new Services.DroitService();
        // GET: api/Droit
        public IEnumerable<Models.Droit> Get()
        {
            return proserv.Get();
        }

        // GET: api/Droit/5
        public Models.Droit Get(int id)
        {
            return proserv.Get(id);
        }

        // POST: api/Droit
        public void Post(Models.Droit droit)
        {
            proserv.Create(droit);
        }

        // PUT: api/Droit/5
        public void Put(int id, Models.Droit droit)
        {
            proserv.Update(id, droit);
        }

        // DELETE: api/Droit/5
        public void Delete(int id)
        {
            proserv.Delete(id);
        }
    }
}
