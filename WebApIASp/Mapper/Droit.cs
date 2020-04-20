using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using G = DalDB.Models;
using C = WebApIASp.Models;

namespace WebApIASp.Mapper
{
    public static class Droit
    {
       
            public static G.Droit ToGlobal(this C.Droit droit)
            {
                return new G.Droit
                {
                    id_droit = droit.id_droit,
                    Nom_droit = droit.Nom_droit

                };
            }

            public static C.Droit ToClient(this G.Droit droit)
            {
                return new C.Droit
                {
                    id_droit = droit.id_droit,
                    Nom_droit = droit.Nom_droit
                };
            }
        
    }
}