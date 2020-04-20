using DalDB.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApIASp.Mapper;
using C = WebApIASp.Models;
namespace WebApIASp.Services
{
    public class PalierService
    {
        private PalierRepository _repo = new PalierRepository();

        public void Create(C.Palier entity)
        {
            _repo.Create(entity.ToGlobal());
        }

        public void Delete(int id)
        {
            _repo.delete(id);
        }

        public IEnumerable<C.Palier> Get()
        {
            return _repo.Get().Select(e => e.ToClient());
        }

        public C.Palier Get(int id)
        {
            return _repo.Get(id).ToClient();
        }

        public void Update(int id, C.Palier entity)
        {
            _repo.update(id, entity.ToGlobal());
        }
    }
}