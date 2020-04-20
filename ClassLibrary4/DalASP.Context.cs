﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class PateFormeEntities : DbContext
    {
        public PateFormeEntities()
            : base("name=PateFormeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Droit> Droit { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Financer> Financer { get; set; }
        public virtual DbSet<Palier> Palier { get; set; }
        public virtual DbSet<Projet> Projet { get; set; }
        public virtual DbSet<Société> Société { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Utilisateur> Utilisateur { get; set; }
        public virtual DbSet<Valider> Valider { get; set; }
    
        public virtual int DeleteDroit(Nullable<int> id_droit)
        {
            var id_droitParameter = id_droit.HasValue ?
                new ObjectParameter("id_droit", id_droit) :
                new ObjectParameter("id_droit", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteDroit", id_droitParameter);
        }
    
        public virtual int DeleteEmployee(Nullable<int> id_employee)
        {
            var id_employeeParameter = id_employee.HasValue ?
                new ObjectParameter("id_employee", id_employee) :
                new ObjectParameter("id_employee", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteEmployee", id_employeeParameter);
        }
    
        public virtual int DeleteFinancer(Nullable<int> id_finance)
        {
            var id_financeParameter = id_finance.HasValue ?
                new ObjectParameter("id_finance", id_finance) :
                new ObjectParameter("id_finance", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteFinancer", id_financeParameter);
        }
    
        public virtual int DeletePalier(Nullable<int> id_palier)
        {
            var id_palierParameter = id_palier.HasValue ?
                new ObjectParameter("id_palier", id_palier) :
                new ObjectParameter("id_palier", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeletePalier", id_palierParameter);
        }
    
        public virtual int DeleteProjet(Nullable<int> id_projet)
        {
            var id_projetParameter = id_projet.HasValue ?
                new ObjectParameter("id_projet", id_projet) :
                new ObjectParameter("id_projet", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteProjet", id_projetParameter);
        }
    
        public virtual int DeleteSociété(Nullable<int> id_numeroTVA)
        {
            var id_numeroTVAParameter = id_numeroTVA.HasValue ?
                new ObjectParameter("id_numeroTVA", id_numeroTVA) :
                new ObjectParameter("id_numeroTVA", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteSociété", id_numeroTVAParameter);
        }
    
        public virtual int DeleteUtilisateur(Nullable<int> id_utilisateur)
        {
            var id_utilisateurParameter = id_utilisateur.HasValue ?
                new ObjectParameter("id_utilisateur", id_utilisateur) :
                new ObjectParameter("id_utilisateur", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteUtilisateur", id_utilisateurParameter);
        }
    
        public virtual int DeleteValider(Nullable<int> id_valider)
        {
            var id_validerParameter = id_valider.HasValue ?
                new ObjectParameter("id_valider", id_valider) :
                new ObjectParameter("id_valider", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteValider", id_validerParameter);
        }
    
        public virtual int insertionAvoir(Nullable<int> id_droit, Nullable<int> id_utilisateur)
        {
            var id_droitParameter = id_droit.HasValue ?
                new ObjectParameter("id_droit", id_droit) :
                new ObjectParameter("id_droit", typeof(int));
    
            var id_utilisateurParameter = id_utilisateur.HasValue ?
                new ObjectParameter("id_utilisateur", id_utilisateur) :
                new ObjectParameter("id_utilisateur", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insertionAvoir", id_droitParameter, id_utilisateurParameter);
        }
    
        public virtual int insertionDroit(string nom_droit)
        {
            var nom_droitParameter = nom_droit != null ?
                new ObjectParameter("Nom_droit", nom_droit) :
                new ObjectParameter("Nom_droit", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insertionDroit", nom_droitParameter);
        }
    
        public virtual int insertionEmployee(Nullable<int> id_utilisateur, Nullable<int> id_numeroTVA, string nom_employee)
        {
            var id_utilisateurParameter = id_utilisateur.HasValue ?
                new ObjectParameter("id_utilisateur", id_utilisateur) :
                new ObjectParameter("id_utilisateur", typeof(int));
    
            var id_numeroTVAParameter = id_numeroTVA.HasValue ?
                new ObjectParameter("id_numeroTVA", id_numeroTVA) :
                new ObjectParameter("id_numeroTVA", typeof(int));
    
            var nom_employeeParameter = nom_employee != null ?
                new ObjectParameter("Nom_employee", nom_employee) :
                new ObjectParameter("Nom_employee", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insertionEmployee", id_utilisateurParameter, id_numeroTVAParameter, nom_employeeParameter);
        }
    
        public virtual int insertionFinancer(Nullable<int> somme, string estRecompense, Nullable<int> id_utilisateur, Nullable<int> id_projet)
        {
            var sommeParameter = somme.HasValue ?
                new ObjectParameter("Somme", somme) :
                new ObjectParameter("Somme", typeof(int));
    
            var estRecompenseParameter = estRecompense != null ?
                new ObjectParameter("EstRecompense", estRecompense) :
                new ObjectParameter("EstRecompense", typeof(string));
    
            var id_utilisateurParameter = id_utilisateur.HasValue ?
                new ObjectParameter("id_utilisateur", id_utilisateur) :
                new ObjectParameter("id_utilisateur", typeof(int));
    
            var id_projetParameter = id_projet.HasValue ?
                new ObjectParameter("id_projet", id_projet) :
                new ObjectParameter("id_projet", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insertionFinancer", sommeParameter, estRecompenseParameter, id_utilisateurParameter, id_projetParameter);
        }
    
        public virtual int insertionPalier(Nullable<int> somme, string recompense, Nullable<int> id_projet)
        {
            var sommeParameter = somme.HasValue ?
                new ObjectParameter("Somme", somme) :
                new ObjectParameter("Somme", typeof(int));
    
            var recompenseParameter = recompense != null ?
                new ObjectParameter("Recompense", recompense) :
                new ObjectParameter("Recompense", typeof(string));
    
            var id_projetParameter = id_projet.HasValue ?
                new ObjectParameter("id_projet", id_projet) :
                new ObjectParameter("id_projet", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insertionPalier", sommeParameter, recompenseParameter, id_projetParameter);
        }
    
        public virtual int insertionProjet(string project, Nullable<int> plafondFinance, string numeroCompte, string urlVid, Nullable<int> id_employee)
        {
            var projectParameter = project != null ?
                new ObjectParameter("Project", project) :
                new ObjectParameter("Project", typeof(string));
    
            var plafondFinanceParameter = plafondFinance.HasValue ?
                new ObjectParameter("PlafondFinance", plafondFinance) :
                new ObjectParameter("PlafondFinance", typeof(int));
    
            var numeroCompteParameter = numeroCompte != null ?
                new ObjectParameter("NumeroCompte", numeroCompte) :
                new ObjectParameter("NumeroCompte", typeof(string));
    
            var urlVidParameter = urlVid != null ?
                new ObjectParameter("UrlVid", urlVid) :
                new ObjectParameter("UrlVid", typeof(string));
    
            var id_employeeParameter = id_employee.HasValue ?
                new ObjectParameter("id_employee", id_employee) :
                new ObjectParameter("id_employee", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insertionProjet", projectParameter, plafondFinanceParameter, numeroCompteParameter, urlVidParameter, id_employeeParameter);
        }
    
        public virtual int insertionSociété(string description, string adresse, string contact)
        {
            var descriptionParameter = description != null ?
                new ObjectParameter("Description", description) :
                new ObjectParameter("Description", typeof(string));
    
            var adresseParameter = adresse != null ?
                new ObjectParameter("Adresse", adresse) :
                new ObjectParameter("Adresse", typeof(string));
    
            var contactParameter = contact != null ?
                new ObjectParameter("Contact", contact) :
                new ObjectParameter("Contact", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insertionSociété", descriptionParameter, adresseParameter, contactParameter);
        }
    
        public virtual int insertionUtilisateur(string nom_utilisateur, string motDePasse, string nom, string prenom)
        {
            var nom_utilisateurParameter = nom_utilisateur != null ?
                new ObjectParameter("Nom_utilisateur", nom_utilisateur) :
                new ObjectParameter("Nom_utilisateur", typeof(string));
    
            var motDePasseParameter = motDePasse != null ?
                new ObjectParameter("MotDePasse", motDePasse) :
                new ObjectParameter("MotDePasse", typeof(string));
    
            var nomParameter = nom != null ?
                new ObjectParameter("Nom", nom) :
                new ObjectParameter("Nom", typeof(string));
    
            var prenomParameter = prenom != null ?
                new ObjectParameter("Prenom", prenom) :
                new ObjectParameter("Prenom", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insertionUtilisateur", nom_utilisateurParameter, motDePasseParameter, nomParameter, prenomParameter);
        }
    
        public virtual int insertionValider(Nullable<bool> status, string commentaire, Nullable<int> id_projet, Nullable<int> id_utilisateur)
        {
            var statusParameter = status.HasValue ?
                new ObjectParameter("Status", status) :
                new ObjectParameter("Status", typeof(bool));
    
            var commentaireParameter = commentaire != null ?
                new ObjectParameter("Commentaire", commentaire) :
                new ObjectParameter("Commentaire", typeof(string));
    
            var id_projetParameter = id_projet.HasValue ?
                new ObjectParameter("id_projet", id_projet) :
                new ObjectParameter("id_projet", typeof(int));
    
            var id_utilisateurParameter = id_utilisateur.HasValue ?
                new ObjectParameter("id_utilisateur", id_utilisateur) :
                new ObjectParameter("id_utilisateur", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insertionValider", statusParameter, commentaireParameter, id_projetParameter, id_utilisateurParameter);
        }
    
        public virtual ObjectResult<selectAvoir_Result> selectAvoir()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<selectAvoir_Result>("selectAvoir");
        }
    
        public virtual ObjectResult<selectDoit_Result> selectDoit()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<selectDoit_Result>("selectDoit");
        }
    
        public virtual ObjectResult<selectEmployee_Result> selectEmployee()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<selectEmployee_Result>("selectEmployee");
        }
    
        public virtual ObjectResult<selectFinancer_Result> selectFinancer()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<selectFinancer_Result>("selectFinancer");
        }
    
        public virtual ObjectResult<selectPalier_Result> selectPalier()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<selectPalier_Result>("selectPalier");
        }
    
        public virtual ObjectResult<selectProjet_Result> selectProjet()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<selectProjet_Result>("selectProjet");
        }
    
        public virtual ObjectResult<selectSociété_Result> selectSociété()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<selectSociété_Result>("selectSociété");
        }
    
        public virtual ObjectResult<selectUtilisateur_Result> selectUtilisateur()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<selectUtilisateur_Result>("selectUtilisateur");
        }
    
        public virtual ObjectResult<selectValider_Result> selectValider()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<selectValider_Result>("selectValider");
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int updateDroit(Nullable<int> id_droit, string nom_droit)
        {
            var id_droitParameter = id_droit.HasValue ?
                new ObjectParameter("id_droit", id_droit) :
                new ObjectParameter("id_droit", typeof(int));
    
            var nom_droitParameter = nom_droit != null ?
                new ObjectParameter("Nom_droit", nom_droit) :
                new ObjectParameter("Nom_droit", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("updateDroit", id_droitParameter, nom_droitParameter);
        }
    
        public virtual int updateEmployee(Nullable<int> id_employee, Nullable<int> id_utilisateur, Nullable<int> id_numeroTVA, string nom_employee)
        {
            var id_employeeParameter = id_employee.HasValue ?
                new ObjectParameter("id_employee", id_employee) :
                new ObjectParameter("id_employee", typeof(int));
    
            var id_utilisateurParameter = id_utilisateur.HasValue ?
                new ObjectParameter("id_utilisateur", id_utilisateur) :
                new ObjectParameter("id_utilisateur", typeof(int));
    
            var id_numeroTVAParameter = id_numeroTVA.HasValue ?
                new ObjectParameter("id_numeroTVA", id_numeroTVA) :
                new ObjectParameter("id_numeroTVA", typeof(int));
    
            var nom_employeeParameter = nom_employee != null ?
                new ObjectParameter("Nom_employee", nom_employee) :
                new ObjectParameter("Nom_employee", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("updateEmployee", id_employeeParameter, id_utilisateurParameter, id_numeroTVAParameter, nom_employeeParameter);
        }
    
        public virtual int updateFinancer(Nullable<int> id_finance, Nullable<int> somme, string estRecompense, Nullable<int> id_utilisateur, Nullable<int> id_projet)
        {
            var id_financeParameter = id_finance.HasValue ?
                new ObjectParameter("id_finance", id_finance) :
                new ObjectParameter("id_finance", typeof(int));
    
            var sommeParameter = somme.HasValue ?
                new ObjectParameter("Somme", somme) :
                new ObjectParameter("Somme", typeof(int));
    
            var estRecompenseParameter = estRecompense != null ?
                new ObjectParameter("EstRecompense", estRecompense) :
                new ObjectParameter("EstRecompense", typeof(string));
    
            var id_utilisateurParameter = id_utilisateur.HasValue ?
                new ObjectParameter("id_utilisateur", id_utilisateur) :
                new ObjectParameter("id_utilisateur", typeof(int));
    
            var id_projetParameter = id_projet.HasValue ?
                new ObjectParameter("id_projet", id_projet) :
                new ObjectParameter("id_projet", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("updateFinancer", id_financeParameter, sommeParameter, estRecompenseParameter, id_utilisateurParameter, id_projetParameter);
        }
    
        public virtual int updatePalier(Nullable<int> id_palier, Nullable<int> somme, string recompense, Nullable<int> id_projet)
        {
            var id_palierParameter = id_palier.HasValue ?
                new ObjectParameter("id_palier", id_palier) :
                new ObjectParameter("id_palier", typeof(int));
    
            var sommeParameter = somme.HasValue ?
                new ObjectParameter("Somme", somme) :
                new ObjectParameter("Somme", typeof(int));
    
            var recompenseParameter = recompense != null ?
                new ObjectParameter("Recompense", recompense) :
                new ObjectParameter("Recompense", typeof(string));
    
            var id_projetParameter = id_projet.HasValue ?
                new ObjectParameter("id_projet", id_projet) :
                new ObjectParameter("id_projet", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("updatePalier", id_palierParameter, sommeParameter, recompenseParameter, id_projetParameter);
        }
    
        public virtual int updateProjet(Nullable<int> id_projet, string project, Nullable<int> plafondFinance, string numeroCompt, string urlVideo, Nullable<int> id_employee)
        {
            var id_projetParameter = id_projet.HasValue ?
                new ObjectParameter("id_projet", id_projet) :
                new ObjectParameter("id_projet", typeof(int));
    
            var projectParameter = project != null ?
                new ObjectParameter("Project", project) :
                new ObjectParameter("Project", typeof(string));
    
            var plafondFinanceParameter = plafondFinance.HasValue ?
                new ObjectParameter("PlafondFinance", plafondFinance) :
                new ObjectParameter("PlafondFinance", typeof(int));
    
            var numeroComptParameter = numeroCompt != null ?
                new ObjectParameter("NumeroCompt", numeroCompt) :
                new ObjectParameter("NumeroCompt", typeof(string));
    
            var urlVideoParameter = urlVideo != null ?
                new ObjectParameter("UrlVideo", urlVideo) :
                new ObjectParameter("UrlVideo", typeof(string));
    
            var id_employeeParameter = id_employee.HasValue ?
                new ObjectParameter("id_employee", id_employee) :
                new ObjectParameter("id_employee", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("updateProjet", id_projetParameter, projectParameter, plafondFinanceParameter, numeroComptParameter, urlVideoParameter, id_employeeParameter);
        }
    
        public virtual int updateSociété(Nullable<int> id_numeroTVA, string description, string adresse, string contact)
        {
            var id_numeroTVAParameter = id_numeroTVA.HasValue ?
                new ObjectParameter("id_numeroTVA", id_numeroTVA) :
                new ObjectParameter("id_numeroTVA", typeof(int));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("Description", description) :
                new ObjectParameter("Description", typeof(string));
    
            var adresseParameter = adresse != null ?
                new ObjectParameter("Adresse", adresse) :
                new ObjectParameter("Adresse", typeof(string));
    
            var contactParameter = contact != null ?
                new ObjectParameter("Contact", contact) :
                new ObjectParameter("Contact", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("updateSociété", id_numeroTVAParameter, descriptionParameter, adresseParameter, contactParameter);
        }
    
        public virtual int updateUtilisateur(Nullable<int> id_utilisateur, string nom_utilisateur, string motDePasse, string nom, string prenom)
        {
            var id_utilisateurParameter = id_utilisateur.HasValue ?
                new ObjectParameter("id_utilisateur", id_utilisateur) :
                new ObjectParameter("id_utilisateur", typeof(int));
    
            var nom_utilisateurParameter = nom_utilisateur != null ?
                new ObjectParameter("Nom_utilisateur", nom_utilisateur) :
                new ObjectParameter("Nom_utilisateur", typeof(string));
    
            var motDePasseParameter = motDePasse != null ?
                new ObjectParameter("MotDePasse", motDePasse) :
                new ObjectParameter("MotDePasse", typeof(string));
    
            var nomParameter = nom != null ?
                new ObjectParameter("Nom", nom) :
                new ObjectParameter("Nom", typeof(string));
    
            var prenomParameter = prenom != null ?
                new ObjectParameter("Prenom", prenom) :
                new ObjectParameter("Prenom", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("updateUtilisateur", id_utilisateurParameter, nom_utilisateurParameter, motDePasseParameter, nomParameter, prenomParameter);
        }
    
        public virtual int updateValider(Nullable<int> id_valider, Nullable<bool> status, string commentaire, Nullable<int> id_projet, Nullable<int> id_utilisateur)
        {
            var id_validerParameter = id_valider.HasValue ?
                new ObjectParameter("id_valider", id_valider) :
                new ObjectParameter("id_valider", typeof(int));
    
            var statusParameter = status.HasValue ?
                new ObjectParameter("Status", status) :
                new ObjectParameter("Status", typeof(bool));
    
            var commentaireParameter = commentaire != null ?
                new ObjectParameter("Commentaire", commentaire) :
                new ObjectParameter("Commentaire", typeof(string));
    
            var id_projetParameter = id_projet.HasValue ?
                new ObjectParameter("id_projet", id_projet) :
                new ObjectParameter("id_projet", typeof(int));
    
            var id_utilisateurParameter = id_utilisateur.HasValue ?
                new ObjectParameter("id_utilisateur", id_utilisateur) :
                new ObjectParameter("id_utilisateur", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("updateValider", id_validerParameter, statusParameter, commentaireParameter, id_projetParameter, id_utilisateurParameter);
        }
    }
}
