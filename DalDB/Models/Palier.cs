﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalDB.Models
{
    public class Palier
    {
        public int id_palier { get; set; }
        public int Somme { get; set; }
        public string Recompense { get; set; }
        public int id_projet { get; set; }
    }
}
