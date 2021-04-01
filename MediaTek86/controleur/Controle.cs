/** 
 * Application MediaTek86
 * Carl Fremault
 * Avril 2021
 */
using MediaTek86.dal;
using MediaTek86.modele;
using MediaTek86.vue;
using System.Collections.Generic;

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
        /// Instance de la vue FrmAuthentification
        /// </summary>
        FrmAuthentification frmAuthentification;

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
            frmAuthentification = new FrmAuthentification(this);
            frmAuthentification.ShowDialog();
        }

        /// <summary>
        /// Méthode qui appelle la méthode VerifierAuthentification de la classe AccesDonnees et lui envoie le nom d'utilisateur
        /// et le mot de passe saisis par l'utilisateur.
        /// Ouvre l'application si la méthode VerifierAuthentification de la classe AccesDonnees retourne 'vrai'.
        /// </summary>
        /// <param name="utilisateur">Le nom d'utilisateur saisi par l'utilisateur dans la vue FrmAuthentification.</param>
        /// <param name="motdepasse">Le mot de passe saisi par l'utilisateur dans la vue FrmAuthentification.</param>
        /// <returns>Un booléen qui est 'vrai si la méthode VerifierAuthentification de la classe AccesDonnees retourne 'vrai', 'faux' si le retour est 'faux'.</returns>
        public bool VerifierAuthentification(string utilisateur, string motdepasse)
        {
            if (AccesDonnees.VerifierAuthentification(utilisateur, motdepasse))
            {
                frmAuthentification.Hide();
                frmPersonnel.ShowDialog();
                return true;
            }
            else
            {
                return false;
            }
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
        /// <param name="personnelAbsence">Objet de type Personnel qui représente le membre du personnel dont les absences sont affichées.</param>
        public void FermerAMAbsences(Personnel personnelAbsence)
        {
            frmAMAbsences.InitialiserLesChamps();
            frmAbsences.RemplirListeAbsences(personnelAbsence);
            frmAMAbsences.Hide();
        }

        /// <summary>
        /// Méthode qui ouvre la vue FrmAMAbsences et lui envoie l'instance de la classe Personnel qui représente le membre du personnel pour lequel on souhaite ajouter une absence.
        /// </summary>
        /// <param name="personnelAbsence">Objet de type Personnel qui représente le membre du personnel pour lequel on souhaite ajouter une absence.</param>
        public void AjouterAbsence(Personnel personnelAbsence)
        {
            frmAMAbsences.Text = "Ajouter absence";
            frmAMAbsences.PersonnelAbsence = personnelAbsence;
            frmAMAbsences.ShowDialog();
        }

        /// <summary>
        /// Méthode qui appelle la méthode ModifierAbsence de la vue FrmAMAbsences en lui envoyant l'absence à modifier et le personnel concerné.
        /// Ouvre ensuite la vue FrmAMAbsences.
        /// </summary>
        /// <param name="absence">Objet de type Absence qui représente l'absence à modifier.</param>
        /// <param name="personnel">Objet de type Personnel qui représente le membre du personnel dont on modifie une absence.</param>
        public void ModifierAbsence(Absence absence, Personnel personnel)
        {
            frmAMAbsences.Text = "Modifier absence";
            frmAMAbsences.ModifierAbsence(absence, personnel);
            frmAMAbsences.ShowDialog();
        }

        /// <summary>
        /// Méthode qui appelle la méthode AddAbsence de la classe AccesDonnees pour l'ajout d'une nouvelle absence.
        /// Appelle ensuite la méthode FermerAMAbsences pour fermer la vue.
        /// </summary>
        /// <param name="absence">Instance de la classe Absence qui représente la nouvelle absence.</param>
        /// <param name="personnelAbsence">Instance de la classe Personnel qui représente le membre du personnel pour lequel on veut ajouter une absence. La variable et utilisé ensuite
        /// comme paramètre dans la méthode FermerAMAbsences afin de mettre à jour l'affichage des absences de ce membre du personnel.</param>
        public void AddAbsence(Absence absence, Personnel personnelAbsence)
        {
            AccesDonnees.AddAbsence(absence);
            FermerAMAbsences(personnelAbsence);
        }

        /// <summary>
        /// Méthode qui appelle la méthode DelAbsence de la classe AccesDonnees pour la suppression d'une absence.
        /// </summary>
        /// <param name="absence">Instance de la classe Absence qui représente l'absence à supprimer.</param>
        /// <param name="personnelAbsence">Instance de la classe Personnel qui représente le membre du personnel pour lequel on veut supprimer une absence.</param>
        public void DelAbsence(Absence absence, Personnel personnelAbsence)
        {
            AccesDonnees.DelAbsence(absence, personnelAbsence);
        }

        /// <summary>
        /// Méthode qui appelle la méthode UpdateAbsence de la classe AccesDonnees pour modifier une absence.
        /// Deux instances de type Absence sont envoyées en paramètre: 
        /// - l'ancienne absence à modifier, car on a besoin de connaître l'ancienne date de début afin de retrouver l'absence à modifier dans la base de données.
        /// - l'absence modifié.
        /// Ferme ensuite la vue FrmAMAbsences.
        /// </summary>
        /// <param name="absenceAModifier">Objet de type Absence qui représente l'absence initiale à modifier.</param>
        /// <param name="nouvelleAbsence">Objet de type Absence qui représente l'absence modifiée.</param>
        /// <param name="personnel">Objet de type Personnel qui représente le membre du personnel dont on modifie une absence.</param>
        public void UpdateAbsence(Absence absenceAModifier, Absence nouvelleAbsence, Personnel personnel)
        {
            AccesDonnees.UpdateAbsence(absenceAModifier, nouvelleAbsence);
            FermerAMAbsences(personnel);
        }
    }
}
