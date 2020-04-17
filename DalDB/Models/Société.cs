using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalDB.Models
{
    public class Société
    {
        public int id_numeroTVA { get; set; }
        public string Description { get; set; }
        public string  Adresse { get; set; }
        public string Contact { get; set; }

    }
}
