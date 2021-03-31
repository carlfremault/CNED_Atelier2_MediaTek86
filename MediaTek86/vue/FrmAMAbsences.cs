using MediaTek86.controleur;
using MediaTek86.modele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        /// Encapsulation du champ 'personnelAbsence'. Permet l'utilisation du 'getter' et 'setter'.
        /// </summary>
        public Personnel PersonnelAbsence { get => personnelAbsence; set => personnelAbsence = value; }

        /// <summary>
        /// Constructeur de la classe.
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
        /// Appelle la méthode FermerAMAbsences de la classe Controle.
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
                Motif motif = (Motif)bdgMotifs.List[bdgMotifs.Position];
                if (modificationAbsence)
                {
                    // à remplir si modification
                }
                else
                {
                    Absence absence = new Absence((int)personnelAbsence.IdPersonnel, ((DateTime)dtpDebut.Value).ToString("yyyy-MM-dd"), (int)motif.IdMotif, (string)motif.Libelle, ((DateTime)dtpFin.Value).ToString("yyyy-MM-dd"));
                    controle.AddAbsence(absence, personnelAbsence);
                }
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }
    }
}
