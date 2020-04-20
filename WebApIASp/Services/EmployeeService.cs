using DalDB.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApIASp.Mapper;
using C = WebApIASp.Models;

namespace WebApIASp.Services
{
    public class EmployeeService
    {
        private EmployeeRepository _repo = new EmployeeRepository();

        public void Create(C.Employee entity)
        {
            _repo.Create(entity.ToGlobal());
        }




        public void Delete(int id)
        {
            _repo.Delete(id);
        }

        public IEnumerable<C.Employee> Get()
        {
            return _repo.Get().Select(e => e.ToClient());
        }


        public C.Employee Get(int id)
        {
            return _repo.Get(id).ToClient();
        }



        public void Update(int id, C.Employee entity)
        {
            _repo.Update(id, entity.ToGlobal());
        }


    }
}
