using DalDB.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApIASp.Mapper;
using C = WebApIASp.Models;

namespace WebApIASp.Services
{
    public class UtilisateurService
    {
        private UtilisateurRepository _repo = new UtilisateurRepository();

        public void Create(C.Utilisateur entity)
        {
            _repo.Create(entity.ToGlobal());
        }




        public void Delete(int id)
        {
            _repo.Delete(id);
        }

        public IEnumerable<C.Utilisateur> Get()
        {
            return _repo.Get().Select(e => e.ToClient());
        }


        public C.Utilisateur Get(int id)
        {
            return _repo.Get(id).ToClient();
        }



        public void Update(int id, C.Utilisateur entity)
        {
            _repo.Update(id, entity.ToGlobal());
        }
    }
}