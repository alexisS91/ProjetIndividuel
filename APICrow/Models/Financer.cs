using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APICrow.Models
{
    public class Financer
    {
        public int id_finance { get; set; }
        public int Somme { get; set; }
        public string EstRecompense { get; set; }
        public int id_utilisateur { get; set; }
        public int id_projet { get; set; }
    }
}