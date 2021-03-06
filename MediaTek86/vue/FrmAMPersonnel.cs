/** 
 * Application MediaTek86
 * Carl Fremault
 * Avril 2021
 */
using MediaTek86.controleur;
using MediaTek86.modele;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MediaTek86.vue
{
    /// <summary>
    /// Interface qui gère l'ajout et la modification du personnel.
    /// </summary>
    public partial class FrmAMPersonnel : Form
    {
        /// <summary>
        /// Instance de la classe Controle.
        /// </summary>
        private Controle controle;

        /// <summary>
        /// Objet pour gérer la liste des services.
        /// </summary>
        BindingSource bdgServices = new BindingSource();

        /// <summary>
        /// Booleen qui définit si on est en cours de modification d'un membre du personnel. Initialisé à false.
        /// </summary>
        private Boolean modification = false;

        /// <summary>
        /// Entier qui représente l'idPersonnel du membre du personnel qu'on veut modifier.
        /// </summary>
        private int idPersonnelAModifier;

        /// <summary>
        /// Constructeur de la classe. Appelle la méthode RemplirServices pour remplir la combobox des services.
        /// </summary>
        public FrmAMPersonnel(Controle controle)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            this.controle = controle;
            RemplirServices();
        }

        /// <summary>
        /// Méthode qui remplit la combobox des services et sélectionne la première entrée.
        /// </summary>
        public void RemplirServices()
        {
            List<Service> lesServices = controle.GetLesServices();
            bdgServices.DataSource = lesServices;
            cboService.DataSource = bdgServices;
            if (cboService.Items.Count > 0)
            {
                cboService.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Méthode évenementielle après un clic sur le bouton 'Annuler'.
        /// Appelle la méthode FermerAMPersonnel de la classe Controle.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            controle.FermerAMPersonnel();
        }

        /// <summary>
        /// Méthode qui vide les différents champs de l'interface et sélectionne la première entrée de la combobox des services.
        /// </summary>
        public void ViderLesChamps()
        {
            txtNom.Text = "";
            txtPrenom.Text = "";
            txtMail.Text = "";
            txtTel.Text = "";
            if (cboService.Items.Count > 0)
            {
                cboService.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Méthode évenementielle après un clic sur le bouton 'Enregistrer' pour enregistrer l'ajout ou la modification d'un membre du personnel.
        /// La méthode vérifie si on est en train de modifier ou ajouter un membre du personnel et appelle la méthode correspondante du contrôleur.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (!txtNom.Text.Equals("") && !txtPrenom.Text.Equals("") && !txtMail.Text.Equals("") && !txtTel.Text.Equals("") && cboService.SelectedIndex != -1)
            {
                Service leService = (Service)bdgServices.List[bdgServices.Position];
                if (modification)
                {
                    Personnel personnelAModifier = new Personnel(idPersonnelAModifier, leService.IdService, txtNom.Text, txtPrenom.Text, leService.Nom, txtTel.Text, txtMail.Text);

                    if (MessageBox.Show("Souhaitez-vous confirmer la modification?", "Confirmation de modification", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        controle.UpdatePersonnel(personnelAModifier);
                        modification = false;
                    }
                    else
                    {
                        controle.FermerAMPersonnel();
                    }
                }
                else
                {
                    int idPersonnel = 0;
                    Personnel lePersonnel = new Personnel(idPersonnel, leService.IdService, txtNom.Text, txtPrenom.Text, leService.Nom, txtTel.Text, txtMail.Text);
                    controle.AddPersonnel(lePersonnel);
                }
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }

        /// <summary>
        /// Méthode qui récupère un objet de type Personnel qui représente le membre du personnel à modifier.
        /// Récupère les propriétés de cet objet pour les afficher dans les champs correspondants.
        /// </summary>
        /// <param name="personnel">Objet de type Personnel qui représente le membre du personnel à modifier.</param>
        public void ModifierPersonnel(Personnel personnel)
        {
            if (!(personnel is null))
            {
                modification = true;
                idPersonnelAModifier = personnel.IdPersonnel;
                txtNom.Text = personnel.Nom;
                txtPrenom.Text = personnel.Prenom;
                txtTel.Text = personnel.Tel;
                txtMail.Text = personnel.Mail;
                cboService.SelectedIndex = cboService.FindStringExact(personnel.Service);
            }
        }
    }
}
