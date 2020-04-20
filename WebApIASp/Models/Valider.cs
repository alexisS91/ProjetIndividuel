using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApIASp.Models
{
    public class Valider
    {
        public int id_valider { get; set; }
        public bool Status { get; set; }
        public string Commentaire { get; set; }
        public int id_projet { get; set; }
        public int id_utilisateur { get; set; }
    }
}