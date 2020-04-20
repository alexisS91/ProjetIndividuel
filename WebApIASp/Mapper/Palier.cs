using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using G = DalDB.Models;
using C = WebApIASp.Models;

namespace WebApIASp.Mapper
{
    public static class Palier
    {
        public static G.Palier ToGlobal(this C.Palier palier)
        {
            return new G.Palier
            {
                id_palier = palier.id_palier,
                Somme = palier.Somme,
                Recompense = palier.Recompense,
                id_projet = palier.id_projet
            };
        }

        public static C.Palier ToClient(this G.Palier palier)
        {
            return new C.Palier
            {
                id_palier = palier.id_palier,
                Somme = palier.Somme,
                Recompense = palier.Recompense,
                id_projet = palier.id_projet
            };
        }
    }
}