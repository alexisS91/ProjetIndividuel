using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APICrow.Models
{
    public class Employee
    {
        public int id_employee { get; set; }
        public int id_utilisateur { get; set; }
        public int id_numeroTVA { get; set; }
        public string Nom_employee { get; set; }
    }
}