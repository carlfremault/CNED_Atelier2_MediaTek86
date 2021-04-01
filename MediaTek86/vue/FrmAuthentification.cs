/** 
 * Application MediaTek86
 * Carl Fremault
 * Avril 2021
 */
using MediaTek86.controleur;
using System;
using System.Windows.Forms;

namespace MediaTek86.vue
{
    /// <summary>
    /// Interface qui gère l'authentification à l'application.
    /// </summary>
    public partial class FrmAuthentification : Form
    {
        /// <summary>
        /// Instance de la classe Controle.
        /// </summary>
        Controle controle;

        /// <summary>
        /// Constructeur de la classe.
        /// </summary>
        public FrmAuthentification(Controle controle)
        {
            InitializeComponent();
            this.controle = controle;
        }

        /// <summary>
        /// Méthode évenementielle après un clic sur le bouton 'Connecter'.
        /// Vérifie si tous les champs ont été remplis.
        /// Appelle ensuite la méthode VerifierAuthentification de la classe Controle en lui envoyant l'utilisateur et le mot de passe saisis.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnecter_Click(object sender, EventArgs e)
        {
            if (!txtUtilisateur.Text.Equals("") && !txtMotdepasse.Text.Equals(""))
            {
                if(!controle.VerifierAuthentification(txtUtilisateur.Text, txtMotdepasse.Text))
                {
                    MessageBox.Show("Utilisateur et/ou mot de passe incorrecte.", "Information");
                    txtUtilisateur.Text = "";
                    txtMotdepasse.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }
    }
}
