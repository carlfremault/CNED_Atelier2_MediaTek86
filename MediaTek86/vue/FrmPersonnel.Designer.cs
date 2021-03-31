
namespace MediaTek86.vue
{
    partial class FrmPersonnel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAjoutPersonnel = new System.Windows.Forms.Button();
            this.btnModifPersonnel = new System.Windows.Forms.Button();
            this.btnSuppPersonnel = new System.Windows.Forms.Button();
            this.btnAffichAbsences = new System.Windows.Forms.Button();
            this.dgvPersonnel = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAjoutPersonnel
            // 
            this.btnAjoutPersonnel.Location = new System.Drawing.Point(12, 357);
            this.btnAjoutPersonnel.Name = "btnAjoutPersonnel";
            this.btnAjoutPersonnel.Size = new System.Drawing.Size(200, 45);
            this.btnAjoutPersonnel.TabIndex = 0;
            this.btnAjoutPersonnel.Text = "Ajouter personnel";
            this.btnAjoutPersonnel.UseVisualStyleBackColor = true;
            this.btnAjoutPersonnel.Click += new System.EventHandler(this.btnAjoutPersonnel_Click);
            // 
            // btnModifPersonnel
            // 
            this.btnModifPersonnel.Location = new System.Drawing.Point(218, 357);
            this.btnModifPersonnel.Name = "btnModifPersonnel";
            this.btnModifPersonnel.Size = new System.Drawing.Size(200, 45);
            this.btnModifPersonnel.TabIndex = 1;
            this.btnModifPersonnel.Text = "Modifier personnel";
            this.btnModifPersonnel.UseVisualStyleBackColor = true;
            this.btnModifPersonnel.Click += new System.EventHandler(this.btnModifPersonnel_Click);
            // 
            // btnSuppPersonnel
            // 
            this.btnSuppPersonnel.Location = new System.Drawing.Point(424, 357);
            this.btnSuppPersonnel.Name = "btnSuppPersonnel";
            this.btnSuppPersonnel.Size = new System.Drawing.Size(200, 45);
            this.btnSuppPersonnel.TabIndex = 2;
            this.btnSuppPersonnel.Text = "Supprimer personnel";
            this.btnSuppPersonnel.UseVisualStyleBackColor = true;
            this.btnSuppPersonnel.Click += new System.EventHandler(this.btnSuppPersonnel_Click);
            // 
            // btnAffichAbsences
            // 
            this.btnAffichAbsences.Location = new System.Drawing.Point(630, 357);
            this.btnAffichAbsences.Name = "btnAffichAbsences";
            this.btnAffichAbsences.Size = new System.Drawing.Size(200, 45);
            this.btnAffichAbsences.TabIndex = 3;
            this.btnAffichAbsences.Text = "Afficher absences";
            this.btnAffichAbsences.UseVisualStyleBackColor = true;
            this.btnAffichAbsences.Click += new System.EventHandler(this.btnAffichAbsences_Click);
            // 
            // dgvPersonnel
            // 
            this.dgvPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonnel.Location = new System.Drawing.Point(13, 13);
            this.dgvPersonnel.Name = "dgvPersonnel";
            this.dgvPersonnel.RowHeadersWidth = 62;
            this.dgvPersonnel.RowTemplate.Height = 28;
            this.dgvPersonnel.Size = new System.Drawing.Size(817, 338);
            this.dgvPersonnel.TabIndex = 4;
            // 
            // FrmPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 414);
            this.Controls.Add(this.dgvPersonnel);
            this.Controls.Add(this.btnAffichAbsences);
            this.Controls.Add(this.btnSuppPersonnel);
            this.Controls.Add(this.btnModifPersonnel);
            this.Controls.Add(this.btnAjoutPersonnel);
            this.Name = "FrmPersonnel";
            this.Text = "MediaTek86 - Personnel";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAjoutPersonnel;
        private System.Windows.Forms.Button btnModifPersonnel;
        private System.Windows.Forms.Button btnSuppPersonnel;
        private System.Windows.Forms.Button btnAffichAbsences;
        private System.Windows.Forms.DataGridView dgvPersonnel;
    }
}