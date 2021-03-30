using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.modele
{
    /// <summary>
    /// Classe métier qui represente la table 'personnel' de la base de données.
    /// </summary>
    public class Personnel
    {
        /// <summary>
        /// idPersonnel de la table 'personnel'
        /// </summary>
        private int idPersonnel;
        /// <summary>
        /// idService de la table 'personnel'
        /// </summary>
        private int idService;
        /// <summary>
        /// libellé service de la table 'service'
        /// </summary>
        private string service;
        /// <summary>
        /// nom de la table 'personnel'
        /// </summary>
        private string nom;
        /// <summary>
        /// prenom de la table 'personnel'
        /// </summary>
        private string prenom;
        /// <summary>
        /// tel de la table 'personnel'
        /// </summary>
        private string tel;
        /// <summary>
        /// mail de la table 'personnel'
        /// </summary>
        private string mail;

        /// <summary>
        /// Constructeur, valorise les propriétés.
        /// </summary>
        /// <param name="idPersonnel"></param>
        /// <param name="idService"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="service"></param>
        /// <param name="tel"></param>
        /// <param name="mail"></param>
        public Personnel(int idPersonnel, int idService, string nom, string prenom, string service, string tel, string mail)
        {
            this.idPersonnel = idPersonnel;
            this.idService = idService;
            this.nom = nom;
            this.prenom = prenom;
            this.service = service;
            this.tel = tel;
            this.mail = mail;
        }

        public int IdPersonnel { get => idPersonnel; }
        public int IdService { get => idService; }
        public string Nom { get => nom; }
        public string Prenom { get => prenom; }
        public string Service { get => service; }
        public string Tel { get => tel; }
        public string Mail { get => mail; }
        
    }
}
