//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibrary4
{
    using System;
    using System.Collections.Generic;
    
    public partial class Palier
    {
        public int id_palier { get; set; }
        public int Somme { get; set; }
        public string Recompense { get; set; }
        public int id_projet { get; set; }
    
        public virtual Projet Projet { get; set; }
    }
}
