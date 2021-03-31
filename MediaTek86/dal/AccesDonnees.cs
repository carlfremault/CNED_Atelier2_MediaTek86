using MediaTek86.connexion;
using MediaTek86.modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.dal
{
    /// <summary>
    /// Classe qui gère les requêtes SQL pour la base de données.
    /// </summary>
    public class AccesDonnees
    {
        /// <summary>
        /// Chaine qui contient les paramètre nécessaires pour se connecter à la base de données.
        /// </summary>
        private static string connectionString = "server=localhost;user id=mediatek86; password=motdepasse; database=mediatek86; Sslmode=none";

        /// <summary>
        /// Méthode qui crée une requête SQL puis l'envoie à la classe ConnexionBDD pour récupérer une liste d'objets du type Personnel, correspondant aux membres du personnel enregistrés dans la base de données.
        /// </summary>
        /// <returns>Une liste d'objets du type Personnel.</returns>
        public static List<Personnel> GetLePersonnel()
        {
            List<Personnel> lePersonnel = new List<Personnel>();
            string req = "select p.idpersonnel as idpersonnel, p.idservice as idservice, p.nom as nom, p.prenom as prenom, s.nom as service, p.tel as tel, p.mail as mail ";
            req += "from personnel p join service s on p.idservice = s.idservice order by nom, prenom;";
            ConnexionBDD curseur = ConnexionBDD.GetInstance(connectionString);
            curseur.ReqSelect(req, null);
            while (curseur.Read())
            {
                lePersonnel.Add(new Personnel((int)curseur.Field("idpersonnel"), (int)curseur.Field("idservice"), (string)curseur.Field("nom"), (string)curseur.Field("prenom"), (string)curseur.Field("service"), (string)curseur.Field("tel"), (string)curseur.Field("mail")));
            }
            curseur.Close();
            return lePersonnel;
        }

        /// <summary>
        /// Méthode qui crée une requête SQL puis l'envoie à la classe ConnexionBDD pour récupérer une liste d'objets du type Service, correspondant aux différents services enregistrés dans la base de données.
        /// </summary>
        /// <returns>Une liste d'objets du type Service.</returns>
        public static List<Service> GetLesServices()
        {
            List<Service> lesServices = new List<Service>();
            string req = "select * from service order by idservice";
            ConnexionBDD curseur = ConnexionBDD.GetInstance(connectionString);
            curseur.ReqSelect(req, null);
            while(curseur.Read())
            {
                Service service = new Service((int)curseur.Field("idservice"), (string)curseur.Field("nom"));
                lesServices.Add(service);
            }
            curseur.Close();
            return lesServices;
        }

        /// <summary>
        /// Méthode qui crée une requête SQL puis l'envoie à la classe ConnexionBDD pour récupérer une liste d'objets du type Absence, correspondant aux différents absences enregistrés dans la base de données pour un membre du personnel.
        /// </summary>
        /// <param name="personnel">Objet du type Personnel qui représente le membre du personnel dont on veut afficher les absences.</param>
        /// <returns>La liste d'absences du membre du personnel passé en entrée.</returns>
        public static List<Absence> GetLesAbsences(Personnel personnel)
        {
            List<Absence> lesAbsences = new List<Absence>();
            string req = "select a.datedebut, a.idmotif as 'idmotif', m.libelle as 'motif', a.datefin from absence a join motif m on a.idmotif = m.idmotif ";
            req+= "where idpersonnel = @idpersonnel order by datedebut desc;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", personnel.IdPersonnel);
            ConnexionBDD curseur = ConnexionBDD.GetInstance(connectionString);
            curseur.ReqSelect(req, parameters);
            while(curseur.Read())
            {
                string dateDebut = ((DateTime)curseur.Field("datedebut")).ToString("dd/MM/yyyy");
                string dateFin = ((DateTime)curseur.Field("datefin")).ToString("dd/MM/yyyy");
                Absence absence = new Absence((int)personnel.IdPersonnel, dateDebut, (int)curseur.Field("idmotif"), (string)curseur.Field("motif"), dateFin);                lesAbsences.Add(absence);
            }
            curseur.Close();
            return lesAbsences;
        }

        /// <summary>
        /// Méthode qui crée une requête SQL puis l'envoie à la classe ConnexionBDD pour récupérer une liste d'objets du type Motif, correspondant aux différents motifs d'absence enregistrés dans la base de données.
        /// </summary>
        /// <returns>Une liste d'objets du type Motif.</returns>
        public static List<Motif> GetLesMotifs ()
        {
            List<Motif> lesMotifs = new List<Motif>();
            string req = "select * from motif order by idmotif";
            ConnexionBDD curseur = ConnexionBDD.GetInstance(connectionString);
            curseur.ReqSelect(req, null);
            while (curseur.Read())
            {
                Motif motif = new Motif((int)curseur.Field("idmotif"), (string)curseur.Field("libelle"));
                lesMotifs.Add(motif);
            }
            curseur.Close();
            return lesMotifs;
        }

        /// <summary>
        /// Méthode qui crée une requête SQL puis l'envoie à la classe ConnexionBDD pour ajouter un nouveau membre du personnel dans la base de données.
        /// </summary>
        /// <param name="personnel">Objet de type Personnel, correspondant au nouveau membre du personnel.</param>
        public static void AddPersonnel(Personnel personnel)
        {
            string req = "insert into personnel(idpersonnel, idservice, nom, prenom, tel, mail) ";
            req += "values(@idpersonnel, @idservice, @nom, @prenom, @tel, @mail);";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", personnel.IdPersonnel);
            parameters.Add("@idservice", personnel.IdService);
            parameters.Add("@nom", personnel.Nom);
            parameters.Add("@prenom", personnel.Prenom);
            parameters.Add("@tel", personnel.Tel);
            parameters.Add("@mail", personnel.Mail);
            ConnexionBDD connection = ConnexionBDD.GetInstance(connectionString);
            connection.ReqUpdate(req, parameters);
            connection.Close();
        }

        /// <summary>
        /// Méthode qui crée une requête SQL puis l'envoie à la classe ConnexionBDD pour supprimer un membre du personnel de la base de données.
        /// </summary>
        /// <param name="personnel">Objet de type Personnel, correspondant au membre du personnel à supprimer.</param>
        public static void DelPersonnel(Personnel personnel)
        {
            string req = "delete from personnel where idpersonnel = @idpersonnel";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", personnel.IdPersonnel);
            ConnexionBDD connection = ConnexionBDD.GetInstance(connectionString);
            connection.ReqUpdate(req, parameters);
            connection.Close();
        }

        /// <summary>
        /// Méthode qui crée une requête SQL puis l'envoie à la classe ConnexionBDD pour modifier un membre du personnel présent dans la base de données.
        /// </summary>
        /// <param name="personnel">Objet de type Personnel, correspondant au membre du personnel à modifier.</param>
        public static void UpdatePersonnel(Personnel personnel)
        {
            string req = "update personnel set idservice = @idservice, nom = @nom, prenom = @prenom, tel = @tel, mail = @mail ";
            req += "where idpersonnel = @idpersonnel;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", personnel.IdPersonnel);
            parameters.Add("@idservice", personnel.IdService);
            parameters.Add("@nom", personnel.Nom);
            parameters.Add("@prenom", personnel.Prenom);
            parameters.Add("@tel", personnel.Tel);
            parameters.Add("@mail", personnel.Mail);
            ConnexionBDD connection = ConnexionBDD.GetInstance(connectionString);
            connection.ReqUpdate(req, parameters);
            connection.Close();
        }

        /// <summary>
        /// Méthode qui crée une requête SQL puis l'envoie à la classe ConnexionBDD pour ajouter une nouvelle absence dans la base de données.
        /// </summary>
        /// <param name="absence">Objet de type Absence, correspondant à la nouvelle absence.</param>
        public static void AddAbsence(Absence absence)
        {            
            string req = "insert into absence(idpersonnel, datedebut, idmotif, datefin) ";
            req += "values(@idpersonnel, @datedebut, @idmotif, @datefin);";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", absence.IdPersonnel);
            parameters.Add("@datedebut", absence.DateDebut);
            parameters.Add("@idmotif", absence.IdMotif);
            parameters.Add("@datefin", absence.DateFin);
            ConnexionBDD connection = ConnexionBDD.GetInstance(connectionString);
            connection.ReqUpdate(req, parameters);
            connection.Close();
        }

        /// <summary>
        /// Méthode qui crée une requête SQL puis l'envoie à la classe ConnexionBDD pour supprimer une absence de la base de données.
        /// </summary>
        /// <param name="absence">Objet de type absence, correspondant à l'absence qu'on veut supprimer.</param>
        /// <param name="personnelAbsence">Objet de type Personnel qui représente le membre du personnel pour lequel on veut supprimer l'absence.</param>
        public static void DelAbsence(Absence absence, Personnel personnelAbsence) 
        {
            string dateDebut = DateTime.Parse(absence.DateDebut).ToString("yyyy-MM-dd");
            string req = "delete from absence where idpersonnel = @idpersonnel and DATE(datedebut) = @datedebut;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", personnelAbsence.IdPersonnel);
            parameters.Add("@datedebut", dateDebut);
            ConnexionBDD connection = ConnexionBDD.GetInstance(connectionString);
            connection.ReqUpdate(req, parameters);
            connection.Close();
        }
    }
}
