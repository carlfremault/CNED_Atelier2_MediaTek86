
namespace MediaTek86.vue
{
    partial class FrmAbsences
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
            this.dgvAbsences = new System.Windows.Forms.DataGridView();
            this.btnAjoutAbsence = new System.Windows.Forms.Button();
            this.btnModifAbsence = new System.Windows.Forms.Button();
            this.btnSuppAbsence = new System.Windows.Forms.Button();
            this.btnRetourPersonnel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAbsences
            // 
            this.dgvAbsences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsences.Location = new System.Drawing.Point(12, 12);
            this.dgvAbsences.Name = "dgvAbsences";
            this.dgvAbsences.RowHeadersWidth = 62;
            this.dgvAbsences.RowTemplate.Height = 28;
            this.dgvAbsences.Size = new System.Drawing.Size(819, 337);
            this.dgvAbsences.TabIndex = 0;
            // 
            // btnAjoutAbsence
            // 
            this.btnAjoutAbsence.Location = new System.Drawing.Point(13, 355);
            this.btnAjoutAbsence.Name = "btnAjoutAbsence";
            this.btnAjoutAbsence.Size = new System.Drawing.Size(200, 45);
            this.btnAjoutAbsence.TabIndex = 1;
            this.btnAjoutAbsence.Text = "Ajouter absence";
            this.btnAjoutAbsence.UseVisualStyleBackColor = true;
            // 
            // btnModifAbsence
            // 
            this.btnModifAbsence.Location = new System.Drawing.Point(219, 355);
            this.btnModifAbsence.Name = "btnModifAbsence";
            this.btnModifAbsence.Size = new System.Drawing.Size(200, 45);
            this.btnModifAbsence.TabIndex = 2;
            this.btnModifAbsence.Text = "Modifier absence";
            this.btnModifAbsence.UseVisualStyleBackColor = true;
            // 
            // btnSuppAbsence
            // 
            this.btnSuppAbsence.Location = new System.Drawing.Point(425, 355);
            this.btnSuppAbsence.Name = "btnSuppAbsence";
            this.btnSuppAbsence.Size = new System.Drawing.Size(200, 45);
            this.btnSuppAbsence.TabIndex = 3;
            this.btnSuppAbsence.Text = "Supprimer absence";
            this.btnSuppAbsence.UseVisualStyleBackColor = true;
            // 
            // btnRetourPersonnel
            // 
            this.btnRetourPersonnel.Location = new System.Drawing.Point(631, 355);
            this.btnRetourPersonnel.Name = "btnRetourPersonnel";
            this.btnRetourPersonnel.Size = new System.Drawing.Size(200, 45);
            this.btnRetourPersonnel.TabIndex = 4;
            this.btnRetourPersonnel.Text = "Retour liste personnel";
            this.btnRetourPersonnel.UseVisualStyleBackColor = true;
            this.btnRetourPersonnel.Click += new System.EventHandler(this.btnRetourPersonnel_Click);
            // 
            // FrmAbsences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 414);
            this.Controls.Add(this.btnRetourPersonnel);
            this.Controls.Add(this.btnSuppAbsence);
            this.Controls.Add(this.btnModifAbsence);
            this.Controls.Add(this.btnAjoutAbsence);
            this.Controls.Add(this.dgvAbsences);
            this.Name = "FrmAbsences";
            this.Text = "MediaTek86 - Absences";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAbsences;
        private System.Windows.Forms.Button btnAjoutAbsence;
        private System.Windows.Forms.Button btnModifAbsence;
        private System.Windows.Forms.Button btnSuppAbsence;
        private System.Windows.Forms.Button btnRetourPersonnel;
    }
}