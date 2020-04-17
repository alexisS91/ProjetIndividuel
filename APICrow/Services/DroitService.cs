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
    public class DroitService
    {
        private DroitRepository _repo = new DroitRepository();

        public void Create(C.Droit entity)
        {
            _repo.Create(entity.ToGlobal());
        }




        public void Delete(int id)
        {
            _repo.Delete(id);
        }

        public IEnumerable<C.Droit> Get()
        {
            return _repo.Get().Select(e => e.ToClient());
        }


        public C.Droit Get(int id)
        {
            return _repo.Get(id).ToClient();
        }



        public void Update(int id, C.Droit entity)
        {
            _repo.Update(id, entity.ToGlobal());
        }

    }
}