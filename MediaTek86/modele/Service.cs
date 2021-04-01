namespace MediaTek86.modele
{
    /// <summary>
    /// Classe métier qui represente la table 'service' de la base de données.
    /// </summary>
    public class Service
    {
        /// <summary>
        /// idService de la table 'service'
        /// </summary>
        private int idService;
        /// <summary>
        /// nom de la table 'service'
        /// </summary>
        private string nom;

        /// <summary>
        /// Constructeur, valorise les propriétés.
        /// </summary>
        /// <param name="idService">idService du service.</param>
        /// <param name="nom">Nom du service.</param>
        public Service(int idService, string nom)
        {
            this.idService = idService;
            this.nom = nom;
        }

        /// <summary>
        /// Encapsulation du champ idService. Permet l'utilisation du 'getter' en lien avec le DataGridView.
        /// </summary>
        public int IdService { get => idService; }
        /// <summary>
        /// Encapsulation du champ nom. Permet l'utilisation du 'getter' en lien avec le DataGridView.
        /// </summary>
        public string Nom { get => nom; }

        /// <summary>
        /// Redéfinition de la méthode ToString qui retourne la propriété 'nom' de la classe pour insertion dans la combobox.
        /// </summary>
        /// <returns>Le nom du service.</returns>
        public override string ToString()
        {
            return nom;
        }
    }
}
