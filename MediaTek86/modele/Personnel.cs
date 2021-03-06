/** 
 * Application MediaTek86
 * Carl Fremault
 * Avril 2021
 */
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
        /// <param name="idPersonnel">idPersonnel du membre du personnel.</param>
        /// <param name="idService">idService du membre du personnel.</param>
        /// <param name="nom">Nom du membre du personnel.</param>
        /// <param name="prenom">Prénom du membre du personnel.</param>
        /// <param name="service">Service du membre du personnel.</param>
        /// <param name="tel">Téléphone du membre du personnel.</param>
        /// <param name="mail">Adresse mail du membre du personnel.</param>
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

        /// <summary>
        /// Encapsulation du champ idPersonnel. Permet l'utilisation du 'getter' et 'setter' en lien avec le DataGridView.
        /// </summary>
        public int IdPersonnel { get => idPersonnel; set => idPersonnel = value; }
        /// <summary>
        /// Encapsulation du champ idService. Permet l'utilisation du 'getter' et 'setter' en lien avec le DataGridView.
        /// </summary>
        public int IdService { get => idService; set => idService = value; }
        /// <summary>
        /// Encapsulation du champ nom. Permet l'utilisation du 'getter' et 'setter' en lien avec le DataGridView.
        /// </summary>
        public string Nom { get => nom; set => nom = value; }
        /// <summary>
        /// Encapsulation du champ prenom. Permet l'utilisation du 'getter' et 'setter' en lien avec le DataGridView.
        /// </summary>
        public string Prenom { get => prenom; set => prenom = value; }
        /// <summary>
        /// Encapsulation du champ service. Permet l'utilisation du 'getter' et 'setter' en lien avec le DataGridView.
        /// </summary>
        public string Service { get => service; set => service = value; }
        /// <summary>
        /// Encapsulation du champ tel. Permet l'utilisation du 'getter' et 'setter' en lien avec le DataGridView.
        /// </summary>
        public string Tel { get => tel; set => tel = value; }
        /// <summary>
        /// Encapsulation du champ mail. Permet l'utilisation du 'getter' et 'setter' en lien avec le DataGridView.
        /// </summary>
        public string Mail { get => mail; set => mail = value; }
    }
}
