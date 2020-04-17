using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APICrow.Controllers
{
    public class EmployeeController : ApiController
    {

        private Services.EmployeeService proserv = new Services.EmployeeService();
        // GET: api/Employee
        public IEnumerable<Models.Employee> Get()
        {
            return proserv.Get();
        }

        // GET: api/Employee/5
        public Models.Employee Get(int id)
        {
            return proserv.Get(id);
        }

        // POST: api/Employee
        public void Post(int id, Models.Employee employee)
        {
            proserv.Update(id, employee);
        }

        // PUT: api/Employee/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Employee/5
        public void Delete(int id)
        {
            proserv.Delete(id);
        }
    }
}
