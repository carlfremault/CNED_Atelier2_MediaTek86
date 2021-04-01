namespace MediaTek86.modele
{
    /// <summary>
    /// Classe métier qui represente la table 'absence' de la base de données.
    /// </summary>
    public class Absence
    {
        /// <summary>
        /// idPersonnel de la table 'absence'
        /// </summary>
        private int idPersonnel;
        /// <summary>
        /// dateDebut de la table 'absence'
        /// </summary>
        private string dateDebut;
        /// <summary>
        /// idmotif de la table 'absence'
        /// </summary>
        private int  idMotif;
        /// <summary>
        /// libelle motif de la table 'motif'
        /// </summary>
        private string motif;
        /// <summary>
        /// dateFin de la table 'absence'
        /// </summary>
        private string dateFin;

        /// <summary>
        /// Constructeur, valorise les propriétés
        /// </summary>
        /// <param name="idPersonnel">idPersonnel du membre du personnel.</param>
        /// <param name="dateDebut">La date de début de l'absence.</param>
        /// <param name="idMotif">idMotif de l'absence.</param>
        /// <param name="motif">Libellé motif de l'absence.</param>
        /// <param name="dateFin">La date de fin de l'absence.</param>
        public Absence(int idPersonnel, string dateDebut, int idMotif, string motif, string dateFin)
        {
            this.idPersonnel = idPersonnel;
            this.dateDebut = dateDebut;
            this.idMotif = idMotif;
            this.motif = motif;
            this.dateFin = dateFin;
        }

        /// <summary>
        /// Encapsulation du champ idPersonnel. Permet l'utilisation du 'getter' et 'setter' en lien avec le DataGridView.
        /// </summary>
        public int IdPersonnel { get => idPersonnel; set => idPersonnel = value;  }
        /// <summary>
        /// Encapsulation du champ dateDebut. Permet l'utilisation du 'getter' et 'setter' en lien avec le DataGridView.
        /// </summary>
        public string DateDebut { get => dateDebut; set => dateDebut = value;  }
        /// <summary>
        /// Encapsulation du champ motif. Permet l'utilisation du 'getter' et 'setter' en lien avec le DataGridView.
        /// </summary>
        public int IdMotif { get => idMotif; set => idMotif = value; }
        /// <summary>
        /// Encapsulation du champ dateFin. Permet l'utilisation du 'getter' et 'setter' en lien avec le DataGridView.
        /// </summary>
        public string DateFin { get => dateFin; set => dateFin = value; }
        /// <summary>
        /// Encapsulation du champ motif. Permet l'utilisation du 'getter' et 'setter' en lien avec le DataGridView.
        /// </summary>
        public string Motif { get => motif; set => motif = value; }
    }
}
