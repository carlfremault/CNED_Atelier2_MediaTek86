using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaTek86.connexion
{
    /// <summary>
    /// Classe qui gère la connexion avec la base de données et execute les requêtes SQL.
    /// </summary>
    public class ConnexionBDD
    {
        /// <summary>
        /// Objet qui contient la connexion à la base de données.
        /// </summary>
        private MySqlConnection connection;
        /// <summary>
        /// Objet qui execute les requêtes SQL.
        /// </summary>
        private MySqlCommand command;
        /// <summary>
        /// Objet qui contient le résultat d'une requête SQL 'SELECT'.
        /// </summary>
        private MySqlDataReader reader;

        /// <summary>
        /// Instance unique de la classe.
        /// </summary>
        private static ConnexionBDD instance = null;

        /// <summary>
        /// Constructeur privé de la classe. Crée une connexion à la base de données et ouvre cette connexion.
        /// </summary>
        /// <param name="chaineConnexion">Chaine qui contient les paramètre nécessaires pour se connecter à la base de données.</param>
        private ConnexionBDD(string chaineConnexion)
        {
            try
            {
                connection = new MySqlConnection(chaineConnexion);
                connection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Application.Exit();
            }
        }

        /// <summary>
        /// Méthode qui retourne l'unique instance de la classe. Vérifie si l'instance a déjà été crée, et appelle le constructeur si besoin.
        /// </summary>
        /// <param name="chaineConnexion">Chaine qui contient les paramètre nécessaires pour se connecter à la base de données.</param>
        /// <returns>Instance unique de la classe.</returns>
        public static ConnexionBDD GetInstance(string chaineConnexion)
        {
            if (ConnexionBDD.instance is null)
            {
                ConnexionBDD.instance = new ConnexionBDD(chaineConnexion);
            }
            return ConnexionBDD.instance;
        }

        /// <summary>
        /// Méthode qui gère les requêtes SQL autres que 'select'.
        /// </summary>
        /// <param name="chaineRequete">Chaîne requête SQL (autre que 'select').</param>
        /// <param name="parameters">Dictionnaire qui contient les paramètres.</param>
        public void ReqUpdate(string chaineRequete, Dictionary<string, object> parameters)
        {
            try
            {
                command = new MySqlCommand(chaineRequete, connection);
                if (!(parameters is null))
                {
                    foreach (KeyValuePair<string, object> parameter in parameters)
                    {
                        command.Parameters.Add(new MySqlParameter(parameter.Key, parameter.Value));
                    }
                }
                command.Prepare();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// Méthode qui gère les requêtes SQL 'select'.
        /// </summary>
        /// <param name="chaineRequete">Châine requête SQL 'select'.</param>
        /// <param name="parameters">Dictionnaire qui contient les paramètres.</param>
        public void ReqSelect(string chaineRequete, Dictionary<string, object> parameters)
        {
            try
            {
                command = new MySqlCommand(chaineRequete, connection);
                if (!(parameters is null))
                {
                    foreach(KeyValuePair<string, object> parameter in parameters)
                    {
                        command.Parameters.Add(new MySqlParameter(parameter.Key, parameter.Value));
                    }
                }
                command.Prepare();
                reader = command.ExecuteReader();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// Méthode qui lit la ligne suivant du curseur.
        /// </summary>
        /// <returns>La ligne suivant du curseur, ou 'false' si la fin est atteinte.</returns>
        public Boolean Read()
        {
            if(reader is null)
            {
                return false;
            }
            try
            {
                return reader.Read();
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Méthode qui retourne le contenu d'un champ du curseur.
        /// </summary>
        /// <param name="champ">Le nom du champ.</param>
        /// <returns>Le contenu du champ.</returns>
        public object Field(string champ)
        {
            if(reader is null)
            {
                return null;
            }
            try
            {
                return reader[champ];
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Méthode qui ferme le curseur.
        /// </summary>
        public void Close()
        {
            if (!(reader is null))
            {
                reader.Close();
            }
        }
    }
}
