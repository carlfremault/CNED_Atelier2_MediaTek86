namespace MediaTek86.modele
{
    /// <summary>
    /// Classe métier qui represente la table 'motif' de la base de données.
    /// </summary>
    public class Motif
    {
        /// <summary>
        /// idMotif de la table 'motif'
        /// </summary>
        private int idMotif;
        /// <summary>
        /// libellé de la table 'motif'
        /// </summary>
        private string libelle;

        /// <summary>
        /// Constructeur, valorise les propriétés.
        /// </summary>
        /// <param name="idMotif">idMotif du Motif.</param>
        /// <param name="libelle">Libellé du Motif.</param>
        public Motif(int idMotif, string libelle)
        {
            this.idMotif = idMotif;
            this.libelle = libelle;
        }

        /// <summary>
        /// Encapsulation du champ idMotif. Permet l'utilisation du 'getter' en lien avec le DataGridView.
        /// </summary>
        public int IdMotif { get => idMotif; }
        /// <summary>
        /// Encapsulation du champ libelle. Permet l'utilisation du 'getter' en lien avec le DataGridView.
        /// </summary>
        public string Libelle { get => libelle; }

        /// <summary>
        /// Redéfinition de la méthode ToString qui retourne la propriété 'libelle' de la classe pour insertion dans la combobox.
        /// </summary>
        /// <returns>Le libellé du motif.</returns>
        public override string ToString()
        {
            return libelle;
        }
    }
}
