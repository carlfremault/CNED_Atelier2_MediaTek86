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
        /// Constructeur de la classe.
        /// </summary>
        public FrmAMPersonnel(Controle controle)
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
            remplirServices();
        }

        /// <summary>
        /// Méthode qui remplit la combobox des services et sélectionne la première entrée.
        /// </summary>
        public void remplirServices()
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
        /// Méthode évenementielle qui ferme la vue après un clic sur le bouton 'Annuler'.
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
        /// Méthode évenementielle après un clic sur le bouton 'Enregistrer' pour enregistrer l'ajout ou la modification d'un membre du personnel..
        /// La méthode vérifie si on est en train de modifier ou ajouter un membre du personnel et appelle la méthode correspondante du contrôleur.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (!txtNom.Text.Equals("") && !txtPrenom.Text.Equals("") && !txtMail.Text.Equals("") && !txtTel.Text.Equals("") && cboService.SelectedIndex != -1)
            {
                Service leService = (Service)bdgServices.List[bdgServices.Position];
                int idPersonnel = 0;
                if (modification)
                {
                    // à remplir en cas de modification
                }
                Personnel lePersonnel = new Personnel(idPersonnel, leService.IdService, txtNom.Text, txtPrenom.Text, leService.Nom, txtTel.Text, txtMail.Text);
                if (modification)
                {
                    // à remplir en cas de modification
                }
                else
                {
                    controle.AddPersonnel(lePersonnel);
                }
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }
    }
}
