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
        /// Instance de la vue FrmAbsences.
        /// </summary>
        FrmAbsences frmAbsences;

        /// <summary>
        /// Instance de la vue FrmAMAbsances
        /// </summary>
        FrmAMAbsences frmAMAbsences;

        /// <summary>
        /// Constructeur de la classe.
        /// Crée des instances des vues FrmPersonnel, FrmAMPersonnel, FrmAbsences et FrmAMAbsences.
        /// </summary>
        public Controle()
        {
            frmPersonnel = new FrmPersonnel(this);
            frmAMPersonnel = new FrmAMPersonnel(this);
            frmAbsences = new FrmAbsences(this);
            frmAMAbsences = new FrmAMAbsences(this);
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
        /// <returns>Une liste d'objets du type Service qui représentent les services enrégistrés dans la base de données.</returns>
        public List<Service> GetLesServices()
        {
            return AccesDonnees.GetLesServices();
        }

        /// <summary>
        /// Méthode qui appelle la méthode GetLesAbsences de la classe AccesDonnees et retourne une liste d'absences d'un membre du personnel.
        /// </summary>
        /// <param name="personnel">Objet du type Personnel qui représente le membre du personnel dont on veut afficher les absences.</param>
        /// <returns></returns>
        public List<Absence> GetLesAbsences(Personnel personnel)
        {
            return AccesDonnees.GetLesAbsences(personnel);
        }

        /// <summary>
        /// Méthode qui appelle la méthode GetLesMotifs de la classe AccesDonnees et retourne une liste d'objets du type Motif.
        /// </summary>
        /// <returns>Une liste d'objets du type Motif qui représentent les motifs d'absence enrégistrés dans la base de données.</returns>
        public List<Motif> GetLesMotifs()
        {
            return AccesDonnees.GetLesMotifs();
        }

        /// <summary>
        /// Méthode qui ouvre la vue FrmAMPersonnel.
        /// </summary>
        public void AjouterPersonnel()
        {
            frmAMPersonnel.Text = "MediaTek86 - Ajouter personnel";
            frmAMPersonnel.ShowDialog();
        }

        /// <summary>
        /// Méthode qui appelle la méthode ModifierPersonnel de la vue FrmAmPersonnel pour lui envoyer le personnel sélectionné et ouvrir la vue.
        /// </summary>
        /// <param name="personnel"></param>
        public void ModifierPersonnel(Personnel personnel)
        {
            frmAMPersonnel.Text = "MediaTek86 - Modifier personnel";
            frmAMPersonnel.ModifierPersonnel(personnel);
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
        /// Méthode qui appelle la méthode RemplirAbsences de la classe FrmAbsences pour afficher la liste des absences d'un membre du personnel.
        /// Ouvre ensuite la vue FrmAbsences.
        /// </summary>
        /// <param name="personnel">Objet du type Personnel qui représente le membre du personnel dont on veut afficher les absences.</param>
        public void AfficherAbsences(Personnel personnel)
        {
            frmAbsences.RemplirListeAbsences(personnel);
            frmAbsences.Text = "MediaTek86 - Absences " + personnel.Prenom + " " + personnel.Nom;
            frmAbsences.ShowDialog();
        }

        /// <summary>
        /// Méthode qui ferme la vue FrmAbsences.
        /// </summary>
        public void FermerAbsences()
        {
            frmAbsences.Hide();

        }

        /// <summary>
        /// Méthode qui ferme la vue FrmAMAbsences et rafraîchit les absences affichées dans la vue FrmAbsences.
        /// </summary>
        /// <param name="personnelAbsence"></param>
        public void FermerAMAbsences(Personnel personnelAbsence)
        {
            frmAbsences.RemplirListeAbsences(personnelAbsence);
            frmAMAbsences.InitialiserLesChamps();
            frmAMAbsences.Hide();
            
        }

        public void AjouterAbsence(Personnel personnelAbsence)
        {
            frmAMAbsences.Text = "Ajouter absence";
            frmAMAbsences.PersonnelAbsence = personnelAbsence;
            frmAMAbsences.ShowDialog();

        }

        /// <summary>
        /// Méthode qui appelle la méthode AddPersonnel de la classe AccesDonnees pour l'ajout d'un nouveau membre du personnel.
        /// Appelle ensuite la méthode FermerAMPersonnel pour fermer la vue.
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
        /// <param name="personnel">Instance de la classe Personnel qui représente le membre du personnel à supprimer.</param>
        public void DelPersonnel(Personnel personnel)
        {
            AccesDonnees.DelPersonnel(personnel);
        }

        /// <summary>
        /// Méthode qui appelle la méthode UpdatePersonnel de la classe AccesDonnees pour modifier un membre du personnel.
        /// Appelle ensuite la méthode FermerAMPersonnel pour fermer la vue.
        /// </summary>
        /// <param name="personnel">Instance de la classe Personnel qui représente le membre du personnel à modifier.</param>
        public void UpdatePersonnel(Personnel personnel)
        {
            AccesDonnees.UpdatePersonnel(personnel);
            FermerAMPersonnel();
        }

        public void AddAbsence(Absence absence, Personnel personnelAbsence)
        {
            AccesDonnees.AddAbsence(absence);
            FermerAMAbsences(personnelAbsence);
        }
    }
}
