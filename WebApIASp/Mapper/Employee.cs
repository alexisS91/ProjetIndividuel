using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using G = DalDB.Models;
using C = WebApIASp.Models;

namespace WebApIASp.Mapper
{
    public static class Employee
    {
        public static G.Employee ToGlobal(this C.Employee employee)
        {
            return new G.Employee
            {
                id_employee = employee.id_employee,
                id_utilisateur = employee.id_utilisateur,
                id_numeroTVA = employee.id_numeroTVA,
                Nom_employee = employee.Nom_employee

            };
        }

        public static C.Employee ToClient(this G.Employee employee)
        {
            return new C.Employee
            {
                id_employee = employee.id_employee,
                id_utilisateur = employee.id_utilisateur,
                id_numeroTVA = employee.id_numeroTVA,
                Nom_employee = employee.Nom_employee
            };
        }
    }
}