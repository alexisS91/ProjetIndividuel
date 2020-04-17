
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsomationEF
{
    class Program
    {
        static void Main(string[] args)
        {
            #region TableEmployee

            //APICrow.Services.EmployeeService employee = new APICrow.Services.EmployeeService();
            //APICrow.Models.Employee emp = new APICrow.Models.Employee();
            //emp.id_employee = 10;
            //emp.id_utilisateur = 1;
            //emp.id_numeroTVA = 2222222;
            //emp.Nom_employee = "Alexis";

            //employee.Update(2, emp);


            //var liste = employee.Get();
            //foreach (var item in liste)
            //{
            //    Console.WriteLine(item.Nom_employee);
            //}

            //Console.ReadLine();

            #endregion
            #region TableProjet

            //APICrow.Services.ProjetService projet = new APICrow.Services.ProjetService();

            //var liste = projet.Get();
            //foreach (var item in liste)
            //{
            //    Console.WriteLine(item.Project);
            //}


            //projet.Delete(4);

            //APICrow.Models.Projet pro = new APICrow.Models.Projet();
            //pro.id_projet = 5;
            //pro.Project = "claude";
            //pro.PlafondFinance = 1000;
            //pro.NumeroCompte = "teleklee25ere";
            //pro.UrlVideo = "claude";
            //pro.id_employee = 2;

            //projet.Update(5, pro);

            //Console.ReadLine();
            #endregion
            #region TableSociété

            APICrow.Services.SociétéService société = new APICrow.Services.SociétéService();

            //APICrow.Models.Société pro = new APICrow.Models.Société();

            //pro.id_numeroTVA = 2222222;
            //pro.Description = "Asbl ";
            //pro.Adresse = "Rue moulin";
            //pro.Contact = "Asbl@gmail.com";

            // société.Update(999999999, pro);

            //société.Delete(999999999);

            #endregion
            #region TableUtilisateur

            //APICrow.Services.UtilisateurService utilisateur  = new APICrow.Services.UtilisateurService();

            //APICrow.Models.Utilisateur pro = new APICrow.Models.Utilisateur();

            //pro.id_utilisateur = 2;
            //pro.Nom_utilisateur = "Louis";
            //pro.MotDePasse = "tg2065";
            //pro.Nom = "Vincent";
            //pro.Prenom = "toto";

            //utilisateur.Update(2, pro);

            //utilisateur.Delete(5);

            #endregion
            #region TableFinancer



            //APICrow.Services.FinancrerService financrer = new APICrow.Services.FinancrerService();

            //APICrow.Models.Financer pro = new APICrow.Models.Financer();

            //pro.id_finance = 4;
            //pro.Somme = 25;
            //pro.EstRecompense = "nom";
            //pro.id_utilisateur = 1;
            //pro.id_projet = 1;

            //financrer.Update(4, pro);

            //financrer.Delete(4);

            #endregion
            #region TablePalier
            //APICrow.Services.PalierService palier = new APICrow.Services.PalierService();

            //APICrow.Models.Palier pro = new APICrow.Models.Palier();

            //pro.id_palier = 2;
            //pro.Somme = 200;
            //pro.Recompense = "1panier";
            //pro.id_projet = 2;

            //palier.Update(2, pro);
            // palier.Delete(2);
            #endregion
            #region TableValider
            //APICrow.Services.ValiderService valider = new APICrow.Services.ValiderService();
            //APICrow.Models.Valider pro = new APICrow.Models.Valider();
            //pro.id_valider = 2;
            //pro.Status = true;
            //pro.Commentaire = null;
            //pro.id_projet = 1;
            //pro.id_utilisateur = 1;

            //valider.Update(2, pro);
            //valider.Delete(6);
            #endregion
            #region TableDroit
            //APICrow.Services.DroitService droit = new APICrow.Services.DroitService();
            //APICrow.Models.Droit pro = new APICrow.Models.Droit();
            ////pro.id_droit = 3;
            //pro.Nom_droit = "admin";

            //droit.Update(3, pro);
            //droit.Delete(3);
            #endregion

            APICrow.Services.DroitService droit = new APICrow.Services.DroitService();
            APICrow.Models.Droit pro = new APICrow.Models.Droit();
            Console.ReadLine();


        }
    }
}
