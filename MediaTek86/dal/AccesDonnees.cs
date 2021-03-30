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
        /// Méthode qui interpelle la classe ConnexionBDD pour récupérer une liste d'objets du type Personnel, correspondant aux membres du personnel enregistrés dans la base de données.
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
                Personnel personnel = new Personnel((int)curseur.Field("idpersonnel"), (int)curseur.Field("idservice"), (string)curseur.Field("nom"), (string)curseur.Field("prenom"), (string)curseur.Field("service"), (string)curseur.Field("tel"), (string)curseur.Field("mail"));
                lePersonnel.Add(personnel);
            }
            curseur.Close();
            return lePersonnel;
        }

        /// <summary>
        /// Méthode qui interpelle la classe ConnexionBDD pour récupérer une liste d'objets du type Service, correspondant aux différents services enregistrés dans la base de données.
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
        /// Méthode qui interpelle la classe ConnexionBDD pour ajouter un nouveau membre du personnel dans la base de données.
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
        }

    }
}
