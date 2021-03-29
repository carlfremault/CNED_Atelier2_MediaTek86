using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.modele
{
    /// <summary>
    /// Classe métier qui represente la table 'motif' de la base de données.
    /// </summary>
    public class Motif
    {
        private int idMotif;
        private string libelle;

        /// <summary>
        /// Constructeur, valorise les propriétés.
        /// </summary>
        /// <param name="idMotif"></param>
        /// <param name="libelle"></param>
        public Motif(int idMotif, string libelle)
        {
            this.idMotif = idMotif;
            this.libelle = libelle;
        }

        public int IdMotif { get => idMotif; }
        public string Libelle { get => libelle; }

        /// <summary>
        /// Méthode qui retourne la propriété 'libelle' de la classe pour insertion dans la combobox.
        /// </summary>
        /// <returns>Le libellé du motif.</returns>
        public override string ToString()
        {
            return libelle;
        }
    }
}
