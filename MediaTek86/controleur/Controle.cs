using MediaTek86.dal;
using MediaTek86.modele;
using MediaTek86.vue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.controleur
{
    /// <summary>
    /// Classe qui gère l'interaction entre les différentes vues et les modèles.
    /// </summary>
    public class Controle
    {
        /// <summary>
        /// Instance de la vue FrmPersonnel.
        /// </summary>
        FrmPersonnel frmPersonnel;
        /// <summary>
        /// Instance de la vue FrmAMPersonnel.
        /// </summary>
        FrmAMPersonnel frmAMPersonnel;

        /// <summary>
        /// Constructeur de la classe.
        /// Crée des instances des vues FrmPersonnel et FrmAMPersonnel.
        /// </summary>
        public Controle()
        {
            frmPersonnel = new FrmPersonnel(this);
            frmAMPersonnel = new FrmAMPersonnel(this);
            frmPersonnel.ShowDialog();
        }

        /// <summary>
        /// Méthode qui appelle la méthode GetLePersonnel de la classe AccesDonnees et retourne une liste d'objets du type Personnel.
        /// </summary>
        /// <returns>Une liste d'objets du type Personnel.</returns>
        public List<Personnel> GetLePersonnel()
        {
            return AccesDonnees.GetLePersonnel();
        }

        /// <summary>
        /// Méthode qui appelle la méthode GetLesServices de la classe AccesDonnees et retourne une liste d'objets du type Service.
        /// </summary>
        /// <returns>Une liste d'objets du type Service.</returns>
        public List<Service> GetLesServices()
        {
            return AccesDonnees.GetLesServices();
        }

        /// <summary>
        /// Méthode qui ouvre la vue FrmAMPersonnel.
        /// </summary>
        public void AjouterPersonnel()
        {
            frmAMPersonnel.Text = "Ajouter personnel";
            frmAMPersonnel.ShowDialog();
        }

        /// <summary>
        /// Méthode qui ferme la vue FrmAMPersonnel et rafraîchit la liste du personnel.
        /// </summary>
        public void FermerAMPersonnel()
        {
            frmAMPersonnel.ViderLesChamps();
            frmAMPersonnel.Hide();
            frmPersonnel.RemplirListePersonnel();
        }

        /// <summary>
        /// Méthode qui appelle la méthode AddPersonnel de la classe AccesDonnees pour l'ajout d'un nouveau membre du personnel.
        /// </summary>
        /// <param name="personnel">Instance de la classe Personnel qui représente le nouveau membre du personnel.</param>
        public void AddPersonnel(Personnel personnel)
        {
            AccesDonnees.AddPersonnel(personnel);
            FermerAMPersonnel();
        }

        /// <summary>
        /// Méthode qui appelle la méthode DelPersonnel de la classe AccesDonnees pour la suppression d'un membre du personnel.
        /// </summary>
        /// <param name="personnel">Instance de la classe Personnel qui représent le membre du personnel à supprimer.</param>
        public void DelPersonnel(Personnel personnel)
        {
            AccesDonnees.DelPersonnel(personnel);
        }
    }
}
