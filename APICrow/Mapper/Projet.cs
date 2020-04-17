using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using G = DalDB.Models;
using C =APICrow.Models;


namespace APICrow.Mapper
{
    public static class Projet
    {
        public static G.Projet ToGlobal(this C.Projet projet)
        {
            return new G.Projet
            {
                 id_projet = projet.id_projet,
                 Project = projet.Project,
                 PlafondFinance= projet.PlafondFinance,
                 NumeroCompte= projet.NumeroCompte,
                 UrlVideo = projet.UrlVideo,
                 id_employee = projet.id_employee
             };
        }

        public static C.Projet ToClient(this G.Projet projet)
        {
            return new C.Projet
            {
                id_projet = projet.id_projet,
                Project = projet.Project,
                PlafondFinance = projet.PlafondFinance,
                NumeroCompte = projet.NumeroCompte,
                UrlVideo = projet.UrlVideo,
                id_employee = projet.id_employee
            };
        }
    }
}
