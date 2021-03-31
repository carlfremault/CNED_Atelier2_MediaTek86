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
        /// Constructeur de la classe.
        /// </summary>
        public FrmAbsences(Controle controle)
        {
            InitializeComponent();
            this.controle = controle;
        }

        /// <summary>
        /// Méthode qui remplit la liste des absences d'un membre du personnel.
        /// </summary>
        /// <param name="personnel">Le membre du personnel dont on veut afficher les absences.</param>
        public void RemplirListeAbsences(Personnel personnel)
        {
            List<Absence> lesAbsences = controle.GetLesAbsences(personnel);
            bdgAbsences.DataSource = lesAbsences;
            dgvAbsences.DataSource = bdgAbsences;
            dgvAbsences.Columns["idpersonnel"].Visible = false;
            dgvAbsences.Columns["datedebut"].HeaderText = "Date début";
            dgvAbsences.Columns["datefin"].HeaderText = "Date fin";
            dgvAbsences.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnRetourPersonnel_Click(object sender, EventArgs e)
        {
            controle.FermerAbsences();
        }
    }
}
