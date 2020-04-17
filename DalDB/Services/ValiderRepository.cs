using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalDB.Services
{
    public class ValiderRepository
    {
        private PateFormeEntities _db = new PateFormeEntities();

        public Models.Valider Create(Models.Valider entity)

        {
          
            entity.id_valider = this._db.insertionValider(entity.Status, entity.Commentaire, entity.id_projet, entity.id_utilisateur);
            return entity;
        }
        public void Delete(int id)
        {
            _db.DeleteValider(id);

        }

        public IEnumerable<Models.Valider> Get()
        {

            return this._db.Valider.Select(dbValue => new Models.Valider()
            {
                id_valider = dbValue.id_valider,
                Status = dbValue.Status,
                Commentaire = dbValue.Commentaire,
                id_projet= dbValue.id_projet,
                id_utilisateur = dbValue.id_utilisateur


            });
        }

        public Models.Valider Get(int id)
        {
            Valider dbValue = this._db.Valider.Find(id);
            return new Models.Valider()
            {
                id_valider = dbValue.id_valider,
                Status = dbValue.Status,
                Commentaire = dbValue.Commentaire,
                id_projet = dbValue.id_projet,
                id_utilisateur = dbValue.id_utilisateur
            };

        }

        public void Update(int id, Models.Valider entity)
        {
            _db.updateValider(id, entity.Status, entity.Commentaire, entity.id_projet, entity.id_utilisateur);
        }

    }
}
