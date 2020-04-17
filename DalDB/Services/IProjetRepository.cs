using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalDB.Services
{
    interface IProjetRepository : IRepository<Models.Projet, int>
    {
        IEnumerable<Projet> GetByCreator(int id_employee);
    }
}
