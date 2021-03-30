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
        /// <param name="idPersonnel"></param>
        /// <param name="dateDebut"></param>
        /// <param name="motif"></param>
        /// <param name="dateFin"></param>
        public Absence(int idPersonnel, string dateDebut, string motif, string dateFin)
        {
            this.idPersonnel = idPersonnel;
            this.dateDebut = dateDebut;
            this.motif = motif;
            this.dateFin = dateFin;
        }

        public int IdPersonnel { get => idPersonnel; }
        public string DateDebut { get => dateDebut; }
        public string Motif { get => motif; }
        public string DateFin { get => dateFin; }
    }
}
