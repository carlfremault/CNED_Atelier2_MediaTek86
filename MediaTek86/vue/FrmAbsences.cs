using MediaTek86.controleur;
using MediaTek86.modele;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MediaTek86.vue
{
    /// <summary>
    /// Interface qui gère l'affichage des absences.
    /// </summary>
    public partial class FrmAbsences : Form
    {
        /// <summary>
        /// Instance de la classe Controle.
        /// </summary>
        private Controle controle;

        /// <summary>
        /// Objet pour gérer la liste des absences.
        /// </summary>
        BindingSource bdgAbsences = new BindingSource();

        /// <summary>
        /// Instance de la classe Personnel qui représente le membre du personnel pour lequel on veut afficher, ajouter ou modifier les absences.
        /// </summary>
        private Personnel personnelAbsence;

        /// <summary>
        /// Constructeur de la classe.
        /// </summary>
        public FrmAbsences(Controle controle)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            this.controle = controle;
        }

        /// <summary>
        /// Méthode qui remplit la liste des absences d'un membre du personnel.
        /// </summary>
        /// <param name="personnel">Le membre du personnel dont on veut afficher les absences.</param>
        public void RemplirListeAbsences(Personnel personnel)
        {
            personnelAbsence = personnel;
            List<Absence> lesAbsences = controle.GetLesAbsences(personnel);
            bdgAbsences.DataSource = lesAbsences;
            dgvAbsences.DataSource = bdgAbsences;
            dgvAbsences.Columns["idpersonnel"].Visible = false;
            dgvAbsences.Columns["idmotif"].Visible = false;
            dgvAbsences.Columns["datedebut"].HeaderText = "Date début";
            dgvAbsences.Columns["datefin"].HeaderText = "Date fin";
            dgvAbsences.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        /// <summary>
        /// Méthode évenementielle après un clic sur le bouton 'Retour liste personnel'.
        /// Appelle la méthode FermerAbences du contrôleur pour fermer la vue des absences.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRetourPersonnel_Click(object sender, EventArgs e)
        {
            controle.FermerAbsences();
        }

        /// <summary>
        /// Méthode évenementielle après un clic sur le bouton 'Ajouter absence'.
        /// Appelle la méthode AjouterAbsence de la classe Controle et lui envoie on objet de type Personnel, correspondant au
        /// membre du personnel pour lequel on veut ajouter une absence, en paramètre.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjoutAbsence_Click(object sender, EventArgs e)
        {
            controle.AjouterAbsence(personnelAbsence);
        }

        /// <summary>
        /// Méthode évenementielle après un clic sur le bouton 'Supprimer absence'.
        /// Vérifie si une absence a été sélectionnée.
        /// Demande confirmation de suppression.
        /// Après confirmation, appelle la méthode DelAbsence du contrôleur en lui envoyant l'absence à supprimer ainsi que
        /// un objet de type Personnel qui représente le membre du personnel pour lequel on veut supprimer l'absence, et rafraîchit ensuite la liste des absences.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSuppAbsence_Click(object sender, EventArgs e)
        {
            if (dgvAbsences.SelectedRows.Count > 0)
            {
                Absence absence = (Absence)bdgAbsences.List[bdgAbsences.Position];
                if (MessageBox.Show("Confirmez-vous la suppression de l'absence de la liste?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controle.DelAbsence(absence, personnelAbsence);
                    RemplirListeAbsences(personnelAbsence);
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une absence.", "Information");
            }
        }

        /// <summary>
        /// Méthode évenementielle après un clic sur le bouton 'Modifier absence'.
        /// Vérifie si une absence a été sélectionnée. 
        /// Après confirmation, appelle la méthode ModifierAbsence du contrôleur en lui envoyant l'absence à modifier ainsi que
        /// un objet de type Personnel qui représente le membre du personnel pour lequel on veut modifier l'absence.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifAbsence_Click(object sender, EventArgs e)
        {
            if (dgvAbsences.SelectedRows.Count > 0)
            {
                Absence absence = (Absence)bdgAbsences.List[bdgAbsences.Position];
                controle.ModifierAbsence(absence, personnelAbsence);
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une absence.", "Information");
            }
        }
    }
}
