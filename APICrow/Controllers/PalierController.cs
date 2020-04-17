using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APICrow.Controllers
{
    public class PalierController : ApiController
    {
        private Services.PalierService proserv = new Services.PalierService();
        // GET: api/Palier
        public IEnumerable<Models.Palier> Get()
        {
            return proserv.Get();
        }

        // GET: api/Palier/5
        public Models.Palier Get(int id)
        {
            return proserv.Get(id);
        }

        // POST: api/Palier
        public void Post(int id, Models.Palier palier)
        {
            proserv.Update(id, palier);
        }

        // PUT: api/Palier/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Palier/5
        public void Delete(int id)
        {
            proserv.Delete(id);
        }
    }
}
