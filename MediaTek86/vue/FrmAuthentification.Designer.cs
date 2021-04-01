
namespace MediaTek86.vue
{
    partial class FrmAuthentification
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUtilisateur = new System.Windows.Forms.TextBox();
            this.txtMotdepasse = new System.Windows.Forms.TextBox();
            this.btnConnecter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Utililsateur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mot de passe";
            // 
            // txtUtilisateur
            // 
            this.txtUtilisateur.Location = new System.Drawing.Point(130, 16);
            this.txtUtilisateur.Name = "txtUtilisateur";
            this.txtUtilisateur.Size = new System.Drawing.Size(224, 26);
            this.txtUtilisateur.TabIndex = 2;
            // 
            // txtMotdepasse
            // 
            this.txtMotdepasse.Location = new System.Drawing.Point(130, 53);
            this.txtMotdepasse.Name = "txtMotdepasse";
            this.txtMotdepasse.PasswordChar = '*';
            this.txtMotdepasse.Size = new System.Drawing.Size(224, 26);
            this.txtMotdepasse.TabIndex = 3;
            // 
            // btnConnecter
            // 
            this.btnConnecter.Location = new System.Drawing.Point(16, 95);
            this.btnConnecter.Name = "btnConnecter";
            this.btnConnecter.Size = new System.Drawing.Size(338, 45);
            this.btnConnecter.TabIndex = 4;
            this.btnConnecter.Text = "Connecter";
            this.btnConnecter.UseVisualStyleBackColor = true;
            this.btnConnecter.Click += new System.EventHandler(this.btnConnecter_Click);
            // 
            // FrmAuthentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 158);
            this.Controls.Add(this.btnConnecter);
            this.Controls.Add(this.txtMotdepasse);
            this.Controls.Add(this.txtUtilisateur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAuthentification";
            this.Text = "Authentification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUtilisateur;
        private System.Windows.Forms.TextBox txtMotdepasse;
        private System.Windows.Forms.Button btnConnecter;
    }
}

