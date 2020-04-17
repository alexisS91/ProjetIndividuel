using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalDB.Services
{
    public class EmployeeRepository 
    {
        private PateFormeEntities _db = new PateFormeEntities();

        public Models.Employee Create(Models.Employee entity)
        {
            entity.id_employee = this._db.insertionEmployee(entity.id_utilisateur, entity.id_numeroTVA, entity.Nom_employee);
            return entity;
        }
        public void Delete(int id)
        {
            _db.DeleteEmployee(id);
        
        }

        public IEnumerable<Models.Employee> Get()
        {

            return this._db.Employee.Select(dbValue => new Models.Employee()
            {
                id_employee = dbValue.id_employee,
                id_utilisateur = dbValue.id_utilisateur,
                id_numeroTVA = dbValue.id_numeroTVA,
                Nom_employee = dbValue.Nom_employee
                
            });
        }

        public Models.Employee Get(int id)
        {
            Employee dbValue = this._db.Employee.Find(id);
            return new Models.Employee()
            {
                id_employee = dbValue.id_employee,
                id_utilisateur = dbValue.id_utilisateur,
                id_numeroTVA = dbValue.id_numeroTVA,
                Nom_employee = dbValue.Nom_employee
            };

        }

        public void Update(int id, Models.Employee entity)
        {
            _db.updateEmployee(id, entity.id_utilisateur, entity.id_numeroTVA, entity.Nom_employee);
        }

    }
}
