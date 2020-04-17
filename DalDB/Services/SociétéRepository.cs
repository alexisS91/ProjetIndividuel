using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalDB.Services
{
    public class SociétéRepository
    {
        private PateFormeEntities _db = new PateFormeEntities();
        public Models.Société Create(Models.Société entity)
        {
            entity.id_numeroTVA = this._db.insertionSociété(entity.Description, entity.Adresse, entity.Contact);
            return entity;
        }
        public void Delete(int id)
        {
            _db.DeleteSociété(id);

        }

        public IEnumerable<Models.Société> Get()
        {

            return this._db.Société.Select(dbValue => new Models.Société()
            {
                id_numeroTVA = dbValue.id_numeroTVA,
                Description = dbValue.Description,
                Adresse = dbValue.Adresse,
                Contact = dbValue.Contact

            });
        }

        public Models.Société Get(int id)
        {
            Société dbValue = this._db.Société.Find(id);
            return new Models.Société()
            {
                id_numeroTVA = dbValue.id_numeroTVA,
                Description = dbValue.Description,
                Adresse = dbValue.Adresse,
                Contact = dbValue.Contact
            };

        }

        public void Update(int id, Models.Société entity)
        {
            _db.updateSociété(id, entity.Description, entity.Adresse, entity.Contact);
        }
    }
}
