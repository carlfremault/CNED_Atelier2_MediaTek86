﻿using MediaTek86.controleur;
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
    /// Interface qui gère l'affichage du personnel.
    /// </summary>
    public partial class FrmPersonnel : Form
    {
        /// <summary>
        /// Instance de la classe Controle.
        /// </summary>
        private Controle controle;

        /// <summary>
        /// Objet pour gérer la liste du personnel.
        /// </summary>
        BindingSource bdgPersonnel = new BindingSource();

        /// <summary>
        /// Constructeur de la classe qui recupère le controleur.
        /// </summary>
        public FrmPersonnel(Controle controle)
        {
            InitializeComponent();
            this.controle = controle;
            Init();
        }

        /// <summary>
        /// Méthode qui gère l'initialisation de la vue.
        /// </summary>
        public void Init()
        {
            RemplirListePersonnel();
        }

        /// <summary>
        /// Méthode qui remplit la liste du personnel.
        /// </summary>
        public void RemplirListePersonnel()
        {
            List<Personnel> lePersonnel = controle.GetLePersonnel();
            bdgPersonnel.DataSource = lePersonnel;
            dgvPersonnel.DataSource = bdgPersonnel;
            dgvPersonnel.Columns["idpersonnel"].Visible = false;
            dgvPersonnel.Columns["idservice"].Visible = false;
            dgvPersonnel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        /// <summary>
        /// Méthode évenementielle après un clic sur le bouton 'Ajouter personnel'. Appelle la méthode AjouterPersonnel() du contrôleur.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjoutPersonnel_Click(object sender, EventArgs e)
        {
            controle.AjouterPersonnel();
        }

        /// <summary>
        /// Méthode évenementielle après un clic sur le bouton 'Supprimer personnel'.
        /// Vérifie si un membre du personnel a été sélectionné.
        /// Demande confirmation de suppression.
        /// Après confirmation, appelle la méthode DelPersonnel() du contrôleur.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSuppPersonnel_Click(object sender, EventArgs e)
        {
            if(dgvPersonnel.SelectedRows.Count > 0)
            {
                Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                if (MessageBox.Show("Confirmez-vous la suppression de " + personnel.Prenom + " " + personnel.Nom + " de la liste?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controle.DelPersonnel(personnel);
                    RemplirListePersonnel();
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un membre du personnel.", "Information");
            }
        }
    }
}
