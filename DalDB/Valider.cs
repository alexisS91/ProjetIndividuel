//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DalDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Valider
    {
        public int id_valider { get; set; }
        public bool Status { get; set; }
        public string Commentaire { get; set; }
        public int id_projet { get; set; }
        public int id_utilisateur { get; set; }
    
        public virtual Projet Projet { get; set; }
        public virtual Utilisateur Utilisateur { get; set; }
    }
}
