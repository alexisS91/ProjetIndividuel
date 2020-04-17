using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using G = DalDB.Models;
using C = APICrow.Models;

namespace APICrow.Mapper
{
    public static class Utilisateur
    {
        public static G.Utilisateur ToGlobal(this C.Utilisateur utilisateur)
        {
            return new G.Utilisateur
            {
                id_utilisateur = utilisateur.id_utilisateur,
                Nom_utilisateur = utilisateur.Nom_utilisateur,
                MotDePasse = utilisateur.MotDePasse,
                Nom = utilisateur.Nom,
                Prenom = utilisateur.Prenom
                
            };
        }

        public static C.Utilisateur ToClient(this G.Utilisateur utilisateur)
        {
            return new C.Utilisateur
            {
                id_utilisateur = utilisateur.id_utilisateur,
                Nom_utilisateur = utilisateur.Nom_utilisateur,
                MotDePasse = utilisateur.MotDePasse,
                Nom = utilisateur.Nom,
                Prenom = utilisateur.Prenom
            };
        }
    }
}