using MediaTek86.controleur;
using MediaTek86.modele;
using System;
using System.Windows.Forms;

namespace MediaTek86.vue
{
    /// <summary>
    /// Interface qui gère l'ajout et la modification des absences.
    /// </summary>
    public partial class FrmAMAbsences : Form
    {
        /// <summary>
        /// Instance de la classe Controle.
        /// </summary>
        private Controle controle;

        /// <summary>
        /// Objet pour gérer la liste des motifs.
        /// </summary>
        BindingSource bdgMotifs = new BindingSource();

        /// <summary>
        /// Booleen qui définit si on est en cours de modification d'une absence. Initialisé à false.
        /// </summary>
        private bool modificationAbsence = false;

        /// <summary>
        /// Instance de la classe Personnel qui représente le membre du personnel pour lequel on veut ajouter ou modifier une absence.
        /// </summary>
        private Personnel personnelAbsence;

        /// <summary>
        /// Instance de la classe Absence qui représente l'absence du'on veut modifier.
        /// </summary>
        private Absence absenceAModifier;

        /// <summary>
        /// Encapsulation du champ 'personnelAbsence'. Permet l'utilisation du 'getter' et 'setter'.
        /// </summary>
        public Personnel PersonnelAbsence { get => personnelAbsence; set => personnelAbsence = value; }
        /// <summary>
        /// Encapsulation du champ 'absenceAModifier'. Permet l'utilisation du 'getter' et 'setter'.
        /// </summary>
        public Absence AbsenceAModifier { get => absenceAModifier; set => absenceAModifier = value; }

        /// <summary>
        /// Constructeur de la classe. Appelle la méthode RemplirMotifs pour remplir la combobox des motifs.
        /// </summary>
        public FrmAMAbsences(Controle controle)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            this.controle = controle;
            RemplirMotifs();
        }

        /// <summary>
        /// Méthode qui remplit la combobox des motifs et sélectionne la première entrée.
        /// </summary>
        public void RemplirMotifs()
        {
            bdgMotifs.DataSource = controle.GetLesMotifs();
            cboMotif.DataSource = bdgMotifs;
            if (cboMotif.Items.Count > 0)
            {
                cboMotif.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Méthode qui réinitialise les champs de la vue.
        /// </summary>
        public void InitialiserLesChamps()
        {
            dtpDebut.Value = DateTime.Now;
            dtpFin.Value = DateTime.Now;
            if (cboMotif.Items.Count > 0)
            {
                cboMotif.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Méthode évenementielle après un clic sur le bouton 'Annuler'.
        /// Appelle la méthode FermerAMAbsences de la classe Controle et envoie un objet de type Personnel en paramètre.
        /// Cet objet représente le membre du personnel duquel on veut rafraîchir la liste des absences.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            controle.FermerAMAbsences(personnelAbsence);
        }

        /// <summary>
        /// Méthode évenementielle après un clic sur le bouton 'Enregistrer' pour enregistrer l'ajout ou la modification d'une absence.
        /// La méthode vérifie si on est en train de modifier ou ajouter une absence et appelle la méthode correspondante du contrôleur.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (!dtpDebut.Value.Equals("") && !dtpFin.Value.Equals("") && cboMotif.SelectedIndex != -1)
            {
                if (dtpDebut.Value < dtpFin.Value) { 
                    Motif motif = (Motif)bdgMotifs.List[bdgMotifs.Position];
                    Absence nouvelleAbsence = new Absence((int)personnelAbsence.IdPersonnel, ((DateTime)dtpDebut.Value).ToString("yyyy-MM-dd"), (int)motif.IdMotif, (string)motif.Libelle, ((DateTime)dtpFin.Value).ToString("yyyy-MM-dd"));
                    if (modificationAbsence)
                    {
                        if ((MessageBox.Show("Souhaitez-vous confirmer la modification?", "Confirmation de modification", MessageBoxButtons.YesNo)) == DialogResult.Yes)
                        {
                            modificationAbsence = false;
                            controle.UpdateAbsence(absenceAModifier, nouvelleAbsence, personnelAbsence);
                        }
                        else
                        {
                            controle.FermerAMAbsences(personnelAbsence);
                        }
                    }
                    else
                    {
                        controle.AddAbsence(nouvelleAbsence, personnelAbsence);
                    }
                }
                else
                {
                    MessageBox.Show("La date de fin de l'absence ne peut être inférieure à la date de début.", "Information");
                }
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }

        /// <summary>
        /// Méthode qui recupère un objet de type Absence qui représente l'absence à modifier, ainsi qu'un objet de type Personnel qui représete le membre du personnel pour lequel on souhaite modifier une absence.
        /// Récupère les propriétés de l'objet  de type Absence pour les afficher dans les champs correspondants.
        /// </summary>
        /// <param name="absence">Objet de type Absence qui représente l'absence qu'on souhaite modifier.</param>
        /// <param name="personnel">Objet de type Personnel qui représente le membre du personnel pour lequel on souhaite modifier une absence.</param>
        public void ModifierAbsence (Absence absence, Personnel personnel)
        {
            if (!(absence is null))
            {
                modificationAbsence = true;
                absenceAModifier = absence;
                personnelAbsence = personnel;
                dtpDebut.Value =DateTime.Parse(absence.DateDebut);
                dtpFin.Value = DateTime.Parse(absence.DateFin);
                cboMotif.SelectedIndex = cboMotif.FindStringExact(absence.Motif);
            }
        }
    }
}
