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
    }
}
