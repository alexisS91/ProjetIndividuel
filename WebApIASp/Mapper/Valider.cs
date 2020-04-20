using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using G = DalDB.Models;
using C = WebApIASp.Models;

namespace WebApIASp.Mapper
{
    public static class Valider
    {
        public static G.Valider ToGlobal(this C.Valider valider)
        {
            return new G.Valider
            {
                id_valider = valider.id_valider,
                Status = valider.Status,
                Commentaire = valider.Commentaire,
                id_projet = valider.id_projet,
                id_utilisateur = valider.id_utilisateur


            };
        }

        public static C.Valider ToClient(this G.Valider valider)
        {
            return new C.Valider
            {
                id_valider = valider.id_valider,
                Status = valider.Status,
                Commentaire = valider.Commentaire,
                id_projet = valider.id_projet,
                id_utilisateur = valider.id_utilisateur
            };
        }
    }
}