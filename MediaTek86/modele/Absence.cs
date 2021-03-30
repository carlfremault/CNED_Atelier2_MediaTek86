using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        /// motif de la table 'absence'
        /// </summary>
        private string motif;
        /// <summary>
        /// dateFin de la table 'absence'
        /// </summary>
        private string dateFin;

        /// <summary>
        /// Constructeur, valorise les propriétés.
        /// </summary>
        /// <param name="idPersonnel">idPersonnel du membre du personnel.</param>
        /// <param name="dateDebut">La date de début de l'absence.</param>
        /// <param name="motif">Le motif de l'absence.</param>
        /// <param name="dateFin">La date de fin de l'absence.</param>
        public Absence(int idPersonnel, string dateDebut, string motif, string dateFin)
        {
            this.idPersonnel = idPersonnel;
            this.dateDebut = dateDebut;
            this.motif = motif;
            this.dateFin = dateFin;
        }

        /// <summary>
        /// Encapsulation du champ idPersonnel. Permet l'utilisation du 'getter' en lien avec le DataGridView.
        /// </summary>
        public int IdPersonnel { get => idPersonnel; }
        /// <summary>
        /// Encapsulation du champ dateDebut. Permet l'utilisation du 'getter' en lien avec le DataGridView.
        /// </summary>
        public string DateDebut { get => dateDebut; }
        /// <summary>
        /// Encapsulation du champ motif. Permet l'utilisation du 'getter' en lien avec le DataGridView.
        /// </summary>
        public string Motif { get => motif; }
        /// <summary>
        /// Encapsulation du champ dateFin. Permet l'utilisation du 'getter' en lien avec le DataGridView.
        /// </summary>
        public string DateFin { get => dateFin; }
    }
}
