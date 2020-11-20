namespace Gestion_Pilote
{
    partial class Form1
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
            this.Id = new System.Windows.Forms.TextBox();
            this.Nom = new System.Windows.Forms.TextBox();
            this.CodePostal = new System.Windows.Forms.TextBox();
            this.Ville = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Vider = new System.Windows.Forms.Button();
            this.Ajouter = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DateNaissance = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.Suprimer = new System.Windows.Forms.Button();
            this.Consulter = new System.Windows.Forms.Button();
            this.SyncroniserListe = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GridId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridCodePostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridVille = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridDateNaissance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Id
            // 
            this.Id.Location = new System.Drawing.Point(58, 30);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(100, 20);
            this.Id.TabIndex = 0;
            // 
            // Nom
            // 
            this.Nom.Location = new System.Drawing.Point(109, 16);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(181, 20);
            this.Nom.TabIndex = 1;
            // 
            // CodePostal
            // 
            this.CodePostal.Location = new System.Drawing.Point(109, 77);
            this.CodePostal.Name = "CodePostal";
            this.CodePostal.Size = new System.Drawing.Size(181, 20);
            this.CodePostal.TabIndex = 2;
            // 
            // Ville
            // 
            this.Ville.Location = new System.Drawing.Point(109, 142);
            this.Ville.Name = "Ville";
            this.Ville.Size = new System.Drawing.Size(181, 20);
            this.Ville.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Vider);
            this.panel1.Controls.Add(this.Ajouter);
            this.panel1.Controls.Add(this.Modifier);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.DateNaissance);
            this.panel1.Controls.Add(this.Ville);
            this.panel1.Controls.Add(this.Nom);
            this.panel1.Controls.Add(this.CodePostal);
            this.panel1.Location = new System.Drawing.Point(12, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 310);
            this.panel1.TabIndex = 5;
            // 
            // Vider
            // 
            this.Vider.Location = new System.Drawing.Point(27, 263);
            this.Vider.Name = "Vider";
            this.Vider.Size = new System.Drawing.Size(75, 23);
            this.Vider.TabIndex = 10;
            this.Vider.Text = "Vider";
            this.Vider.UseVisualStyleBackColor = true;
            this.Vider.Click += new System.EventHandler(this.Vider_Click);
            // 
            // Ajouter
            // 
            this.Ajouter.Location = new System.Drawing.Point(122, 263);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(75, 23);
            this.Ajouter.TabIndex = 11;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // Modifier
            // 
            this.Modifier.Location = new System.Drawing.Point(215, 263);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(75, 23);
            this.Modifier.TabIndex = 12;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = true;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Code Postal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ville";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Date Naissance";
            // 
            // DateNaissance
            // 
            this.DateNaissance.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateNaissance.Location = new System.Drawing.Point(109, 199);
            this.DateNaissance.Name = "DateNaissance";
            this.DateNaissance.Size = new System.Drawing.Size(181, 20);
            this.DateNaissance.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Id";
            // 
            // Suprimer
            // 
            this.Suprimer.Location = new System.Drawing.Point(186, 30);
            this.Suprimer.Name = "Suprimer";
            this.Suprimer.Size = new System.Drawing.Size(75, 23);
            this.Suprimer.TabIndex = 7;
            this.Suprimer.Text = "Suprimer";
            this.Suprimer.UseVisualStyleBackColor = true;
            this.Suprimer.Click += new System.EventHandler(this.Suprimer_Click);
            // 
            // Consulter
            // 
            this.Consulter.Location = new System.Drawing.Point(288, 30);
            this.Consulter.Name = "Consulter";
            this.Consulter.Size = new System.Drawing.Size(75, 23);
            this.Consulter.TabIndex = 8;
            this.Consulter.Text = "Consulter";
            this.Consulter.UseVisualStyleBackColor = true;
            this.Consulter.Click += new System.EventHandler(this.Consulter_Click);
            // 
            // SyncroniserListe
            // 
            this.SyncroniserListe.Location = new System.Drawing.Point(403, 30);
            this.SyncroniserListe.Name = "SyncroniserListe";
            this.SyncroniserListe.Size = new System.Drawing.Size(545, 23);
            this.SyncroniserListe.TabIndex = 9;
            this.SyncroniserListe.Text = "Liste Pilote";
            this.SyncroniserListe.UseVisualStyleBackColor = true;
            this.SyncroniserListe.Click += new System.EventHandler(this.SyncroniserListe_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GridId,
            this.GridNom,
            this.GridCodePostal,
            this.GridVille,
            this.GridDateNaissance});
            this.dataGridView1.Location = new System.Drawing.Point(403, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 310);
            this.dataGridView1.TabIndex = 10;
            // 
            // GridId
            // 
            this.GridId.HeaderText = "Id";
            this.GridId.Name = "GridId";
            this.GridId.ReadOnly = true;
            // 
            // GridNom
            // 
            this.GridNom.HeaderText = "Nom";
            this.GridNom.Name = "GridNom";
            this.GridNom.ReadOnly = true;
            // 
            // GridCodePostal
            // 
            this.GridCodePostal.HeaderText = "Code Postal";
            this.GridCodePostal.Name = "GridCodePostal";
            this.GridCodePostal.ReadOnly = true;
            // 
            // GridVille
            // 
            this.GridVille.HeaderText = "Ville";
            this.GridVille.Name = "GridVille";
            this.GridVille.ReadOnly = true;
            // 
            // GridDateNaissance
            // 
            this.GridDateNaissance.HeaderText = "Date Naissance";
            this.GridDateNaissance.Name = "GridDateNaissance";
            this.GridDateNaissance.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SyncroniserListe);
            this.Controls.Add(this.Consulter);
            this.Controls.Add(this.Suprimer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Id);
            this.Name = "Form1";
            this.Text = "Gestion Pilote";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.TextBox Nom;
        private System.Windows.Forms.TextBox CodePostal;
        private System.Windows.Forms.TextBox Ville;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Vider;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DateNaissance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Suprimer;
        private System.Windows.Forms.Button Consulter;
        private System.Windows.Forms.Button SyncroniserListe;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridId;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridCodePostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridVille;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridDateNaissance;
    }
}

