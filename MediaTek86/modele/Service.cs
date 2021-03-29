using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.modele
{
    /// <summary>
    /// Classe métier qui represente la table 'service' de la base de données.
    /// </summary>
    public class Service
    {
        private int idService;
        private string nom;

        /// <summary>
        /// Constructeur, valorise les propriétés.
        /// </summary>
        /// <param name="idService"></param>
        /// <param name="nom"></param>
        public Service(int idService, string nom)
        {
            this.idService = idService;
            this.nom = nom;
        }

        public int IdService { get => idService; }
        public string Nom { get => nom; }

        /// <summary>
        /// Méthode qui retourne la propriété 'nom' de la classe pour insertion dans la combobox.
        /// </summary>
        /// <returns>Le nom du service.</returns>
        public override string ToString()
        {
            return nom;
        }
    }
}
