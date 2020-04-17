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
    public class SociétéService
    {

        private SociétéRepository _repo = new SociétéRepository();

        public void Create(string v, string v1, C.Société entity)
        {
            _repo.Create(entity.ToGlobal());
        }




        public void Delete(int id)
        {
            _repo.Delete(id);
        }

        public IEnumerable<C.Société> Get()
        {
            return _repo.Get().Select(e => e.ToClient());
        }


        public C.Société Get(int id)
        {
            return _repo.Get(id).ToClient();
        }



        public void Update(int id, C.Société entity)
        {
            _repo.Update(id, entity.ToGlobal());
        }
    }
}