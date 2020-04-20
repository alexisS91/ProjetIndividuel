using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using G = DalDB.Models;
using C = WebApIASp.Models;

namespace WebApIASp.Mapper
{
    public static class Financer
    {
        public static G.Financer ToGlobal(this C.Financer financer)
        {
            return new G.Financer
            {
                id_finance = financer.id_finance,
                Somme = financer.Somme,
                EstRecompense = financer.EstRecompense,
                id_utilisateur = financer.id_utilisateur,
                id_projet = financer.id_projet
            };
        }

        public static C.Financer ToClient(this G.Financer financer)
        {
            return new C.Financer
            {
                id_finance = financer.id_finance,
                Somme = financer.Somme,
                EstRecompense = financer.EstRecompense,
                id_utilisateur = financer.id_utilisateur,
                id_projet = financer.id_projet
            };
        }
    }
}