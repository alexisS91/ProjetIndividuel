using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalDB.Services
{
    public class DroitRepository
    {
        private PateFormeEntities _db = new PateFormeEntities();

        public Models.Droit Create(Models.Droit entity)
        {
            entity.id_droit = this._db.insertionDroit(entity.Nom_droit);
            return entity;
        }
        public void Delete(int id)
        {
            _db.DeleteDroit(id);

        }

        public IEnumerable<Models.Droit> Get()
        {

            return this._db.Droit.Select(dbValue => new Models.Droit()
            {
                id_droit = dbValue.id_droit,
                Nom_droit = dbValue.Nom_droit

            });
        }

        public Models.Droit Get(int id)
        {
            Droit dbValue = this._db.Droit.Find(id);
            return new Models.Droit()
            {
                id_droit = dbValue.id_droit,
                Nom_droit = dbValue.Nom_droit
            };

        }

        public void Update(int id, Models.Droit entity)
        {
            _db.updateDroit(id, entity.Nom_droit);
        }
    }
}
