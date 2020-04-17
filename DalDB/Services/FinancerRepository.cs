using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalDB.Services
{
    public class FinancerRepository
    {
            private PateFormeEntities _db = new PateFormeEntities();

            public Models.Financer Create(Models.Financer entity)
            {
                
                entity.id_finance = this._db.insertionFinancer(entity.Somme, entity.EstRecompense, entity.id_utilisateur, entity.id_projet);
                return entity;
            }
        public void delete(int id)
        {
            _db.DeleteFinancer(id);
        }


        public IEnumerable<Models.Financer> Get()
        {

            return this._db.Financer.Select(dbValue => new Models.Financer()
            {
                id_finance = dbValue.id_finance,
                Somme = dbValue.Somme,
                EstRecompense = dbValue.EstRecompense,
                id_utilisateur = dbValue.id_utilisateur,
                id_projet = dbValue.id_projet
            });
        }

        public Models.Financer Get(int id)
        {
            Financer dbValue = this._db.Financer.Find(id);
            return new Models.Financer()
            {
                id_finance = dbValue.id_finance,
                Somme = dbValue.Somme,
                EstRecompense = dbValue.EstRecompense,
                id_utilisateur = dbValue.id_utilisateur,
                id_projet = dbValue.id_projet
            };

        }

        public void update(int id, Models.Financer entity)
        {
            _db.updateFinancer(id, entity.Somme, entity.EstRecompense, entity.id_utilisateur, entity.id_projet);
        }
    }
}
