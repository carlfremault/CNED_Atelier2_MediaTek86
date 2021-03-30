using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.modele
{
    /// <summary>
    /// Classe métier qui represente la table 'responsable' de la base de données.
    /// </summary>
    public class Responsable
    {
        /// <summary>
        /// login de la table 'responsable'
        /// </summary>
        private string login;
        /// <summary>
        /// pwd de la table 'responsable'
        /// </summary>
        private string pwd;

        /// <summary>
        /// Constructeur, valorise les propriétés.
        /// </summary>
        /// <param name="login">Login du responsable.</param>
        /// <param name="pwd">Mot de passe du responsable (crypté dans la base de données).</param>
        public Responsable(string login, string pwd)
        {
            this.login = login;
            this.pwd = pwd;
        }

        /// <summary>
        /// Encapsulation du champ login. Permet l'utilisation du 'getter' en lien avec le DataGridView.
        /// </summary>
        public string Login { get => login; }
        /// <summary>
        /// Encapsulation du champ pwd. Permet l'utilisation du 'getter' en lien avec le DataGridView.
        /// </summary>
        public string Pwd { get => pwd; }
    }
}
