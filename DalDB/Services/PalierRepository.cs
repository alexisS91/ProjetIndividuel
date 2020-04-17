using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalDB.Services
{
    public class PalierRepository
    {
        private PateFormeEntities _db = new PateFormeEntities();

        public Models.Palier Create(Models.Palier entity)
        {

            entity.id_palier = this._db.insertionPalier(entity.Somme, entity.Recompense,entity.id_projet);
            return entity;
        }
        public void delete(int id)
        {
            _db.DeletePalier(id);
        }


        public IEnumerable<Models.Palier> Get()
        {

            return this._db.Palier.Select(dbValue => new Models.Palier()
            {
                id_palier = dbValue.id_palier,
                Somme = dbValue.Somme,
                Recompense = dbValue.Recompense,
                id_projet = dbValue.id_projet
            });
        }

        public Models.Palier Get(int id)
        {
            Palier dbValue = this._db.Palier.Find(id);
            return new Models.Palier()
            {
                id_palier = dbValue.id_palier,
                Somme = dbValue.Somme,
                Recompense = dbValue.Recompense,
                id_projet = dbValue.id_projet
            };

        }

        public void update(int id, Models.Palier entity)
        {
            _db.updatePalier(id, entity.Somme, entity.Recompense, entity.id_projet);
        }
    }
}
