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
    public class ValiderService
    {
        private ValiderRepository _repo = new ValiderRepository();

        public void Create(C.Valider entity)
        {
            _repo.Create(entity.ToGlobal());
        }




        public void Delete(int id)
        {
            _repo.Delete(id);
        }

        public IEnumerable<C.Valider> Get()
        {
            return _repo.Get().Select(e => e.ToClient());
        }


        public C.Valider Get(int id)
        {
            return _repo.Get(id).ToClient();
        }



        public void Update(int id, C.Valider entity)
        {
            _repo.Update(id, entity.ToGlobal());
        }



    }
}