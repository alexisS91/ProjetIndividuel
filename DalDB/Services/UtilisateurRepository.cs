using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalDB.Services
{
    public class UtilisateurRepository
    {
        private PateFormeEntities _db = new PateFormeEntities();

        public Models.Utilisateur Create(Models.Utilisateur entity)
        {
            entity.id_utilisateur = this._db.insertionUtilisateur(entity.Nom_utilisateur, entity.MotDePasse, entity.Nom, entity.Prenom);
            return entity;
        }

        public void Delete(int id)
        {
            this._db.DeleteUtilisateur(id);
           
        }

        public IEnumerable<Models.Utilisateur> Get()
        {

            return this._db.Utilisateur.Select(dbValue => new Models.Utilisateur()
            {
                id_utilisateur = dbValue.id_utilisateur,
                Nom_utilisateur = dbValue.Nom_utilisateur,
                MotDePasse = dbValue.MotDePasse,
                Nom = dbValue.Nom,
                Prenom = dbValue.Prenom,
                
            });
        }

        public Models.Utilisateur Get(int id)
        {
            Utilisateur dbValue = this._db.Utilisateur.Find(id);
            return new Models.Utilisateur()
            {
                id_utilisateur = dbValue.id_utilisateur,
                Nom_utilisateur = dbValue.Nom_utilisateur,
                MotDePasse = dbValue.MotDePasse,
                Nom = dbValue.Nom,
                Prenom = dbValue.Prenom
                
            };

        }

     
        public void Update(int id, Models.Utilisateur entity)
        {
            this._db.updateUtilisateur(id, entity.Nom_utilisateur, entity.MotDePasse, entity.Nom, entity.Prenom);
        }
    }
}
