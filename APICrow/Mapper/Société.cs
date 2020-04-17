using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using G = DalDB.Models;
using C = APICrow.Models;

namespace APICrow.Mapper
{
    public static class Société
    {
        public static G.Société ToGlobal(this C.Société société)
        {
            return new G.Société
            {
                id_numeroTVA = société.id_numeroTVA,
                Description = société.Description,
                Adresse = société.Adresse,
                Contact = société.Contact
                
            };
        }

        public static C.Société ToClient(this G.Société société)
        {
            return new C.Société
            {
                id_numeroTVA = société.id_numeroTVA,
                Description = société.Description,
                Adresse = société.Adresse,
                Contact = société.Contact
            };
        }
    }
}