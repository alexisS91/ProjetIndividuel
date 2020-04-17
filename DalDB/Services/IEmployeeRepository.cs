using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalDB.Services
{
    interface IEmployeeRepository : IRepository<Models.Employee, int>
    {
    }
}
