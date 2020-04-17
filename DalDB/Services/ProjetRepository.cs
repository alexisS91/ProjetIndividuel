using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalDB.Services
{
    public class ProjetRepository: IProjetRepository

    {

        private PateFormeEntities _db = new PateFormeEntities();

        public Models.Projet Create(Models.Projet entity)
        {
            entity.id_projet = this._db.insertionProjet(entity.Project, entity.PlafondFinance, entity.NumeroCompte, entity.UrlVideo, entity.id_employee);
            return entity;
        }

        public void Delete(int id)
        {
            _db.DeleteProjet(id);
        }

        public  IEnumerable<Models.Projet> Get()
        {
            
            return this._db.Projet.Select(dbValue => new Models.Projet() {
                id_projet = dbValue.id_projet,
                Project = dbValue.Project,
                PlafondFinance = dbValue.PlafondFinance,
                NumeroCompte = dbValue.NumeroCompte,
                UrlVideo = dbValue.UrlVideo,
                id_employee = dbValue.id_employee
            });
        }

        public Models.Projet Get(int id)
        {
            Projet dbValue = this._db.Projet.Find(id);
            return new Models.Projet()
            {
                id_projet = dbValue.id_projet,
                Project = dbValue.Project,
                PlafondFinance = dbValue.PlafondFinance,
                NumeroCompte = dbValue.NumeroCompte,
                UrlVideo = dbValue.UrlVideo,
                id_employee = dbValue.id_employee
            };

        }

        public IEnumerable<Projet> GetByCreator(int id_employee)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Models.Projet entity)
        {
            _db.updateProjet(id, entity.Project, entity.PlafondFinance, entity.NumeroCompte, entity.UrlVideo, entity.id_employee);
        }
    }
}
