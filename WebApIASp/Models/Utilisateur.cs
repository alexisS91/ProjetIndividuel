﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApIASp.Models
{
    public class Utilisateur
    {
        public int id_utilisateur { get; set; }
        public string Nom_utilisateur { get; set; }
        public string MotDePasse { set; get; }
        public string Nom { set; get; }
        public string Prenom { set; get; }
    }
}