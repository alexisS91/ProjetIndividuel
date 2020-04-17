using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalDB.Models
{
    public class Projet
    {
        public int id_projet { get; set; }
        public string Project { get; set; }
        public int PlafondFinance { get; set; }
        public string NumeroCompte { get; set; }
        public string UrlVideo { get; set; }
        public int id_employee { get; set; }
    }
}
