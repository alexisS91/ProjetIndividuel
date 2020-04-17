using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DalDB.Services;
using G = DalDB.Models;
using C = APICrow.Models;
using APICrow.Mapper;


namespace APICrow.Services
{
    public class FinancrerService
    {
        private FinancerRepository _repo = new FinancerRepository();

        public void Create(C.Financer entity)
        {
            _repo.Create(entity.ToGlobal());
        }

        public void Delete(int id)
        {
            _repo.delete(id);
        }

        public IEnumerable<C.Financer> Get()
        {
            return _repo.Get().Select(e => e.ToClient());
        }

        public C.Financer Get(int id)
        {
            return _repo.Get(id).ToClient();
        }

        public void Update(int id, C.Financer entity)
        {
            _repo.update(id, entity.ToGlobal());
        }

    }
}