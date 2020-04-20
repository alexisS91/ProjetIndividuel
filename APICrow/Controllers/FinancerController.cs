using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APICrow.Controllers
{
    public class FinancerController : ApiController
    {
        private Services.FinancrerService proserv = new Services.FinancrerService();
        // GET: api/Financer
        public IEnumerable<Models.Financer> Get()
        {
            return proserv.Get();
        }

        // GET: api/Financer/5
        public Models.Financer Get(int id)
        {
            return proserv.Get(id);
        }

        // POST: api/Financer
        public void Post(Models.Financer financer)
        {
            proserv.Create(financer);
        }

        // PUT: api/Financer/5
        public void Put(int id, Models.Financer financer)
        {
            proserv.Update(id, financer);

        }

        // DELETE: api/Financer/5
        public void Delete(int id)
        {
            proserv.Delete(id);
        }
    }
}
