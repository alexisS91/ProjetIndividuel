using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APICrow.Controllers
{
    public class SociétéController : ApiController
    {

        private Services.SociétéService proserv = new Services.SociétéService();
        // GET: api/Société
        public IEnumerable<Models.Société> Get()
        {

            return proserv.Get();
        }

        // GET: api/Société/5
        public Models.Société Get(int id)
        {
            return proserv.Get(id);
        }

        // POST: api/Société
        public void Post(Models.Société société)
        {

            proserv.Create(société);
        }

        // PUT: api/Société/5
        public void Put(int id, Models.Société société)
        {
            proserv.Update(id, société);

        }

        // DELETE: api/Société/5
        public void Delete(int id)
        {
            proserv.Delete(id);
        }
    }
}
