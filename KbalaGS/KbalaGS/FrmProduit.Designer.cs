namespace KbalaGS
{
    partial class FrmProduit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduit));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnMaxim = new System.Windows.Forms.Button();
            this.btnMinim = new System.Windows.Forms.Button();
            this.btnNormale = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnAfficherPhoto = new System.Windows.Forms.Button();
            this.lbltitre = new System.Windows.Forms.Label();
            this.cmbCategorie = new System.Windows.Forms.ComboBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.datainfo = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Categorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomProduit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantité = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrixProduit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datainfo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel6.Location = new System.Drawing.Point(528, 250);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(212, 2);
            this.panel6.TabIndex = 48;
            // 
            // txtRecherche
            // 
            this.txtRecherche.BackColor = System.Drawing.SystemColors.Control;
            this.txtRecherche.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecherche.ForeColor = System.Drawing.Color.DimGray;
            this.txtRecherche.Location = new System.Drawing.Point(528, 216);
            this.txtRecherche.Multiline = true;
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(204, 36);
            this.txtRecherche.TabIndex = 47;
            this.txtRecherche.Text = "Nom De Produit";
            this.txtRecherche.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRecherche.TextChanged += new System.EventHandler(this.txtRecherche_TextChanged);
            this.txtRecherche.Enter += new System.EventHandler(this.txtRecherche_Enter);
            this.txtRecherche.Leave += new System.EventHandler(this.txtRecherche_Leave);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel4.Location = new System.Drawing.Point(24, 182);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(968, 3);
            this.panel4.TabIndex = 46;
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnAjouter.FlatAppearance.BorderSize = 0;
            this.btnAjouter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Image = ((System.Drawing.Image)(resources.GetObject("btnAjouter.Image")));
            this.btnAjouter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjouter.Location = new System.Drawing.Point(24, 122);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(204, 54);
            this.btnAjouter.TabIndex = 45;
            this.btnAjouter.Text = "     Ajouter";
            this.btnAjouter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnModifier.FlatAppearance.BorderSize = 0;
            this.btnModifier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.ForeColor = System.Drawing.Color.White;
            this.btnModifier.Image = ((System.Drawing.Image)(resources.GetObject("btnModifier.Image")));
            this.btnModifier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifier.Location = new System.Drawing.Point(276, 122);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(204, 54);
            this.btnModifier.TabIndex = 44;
            this.btnModifier.Text = "    Modifier";
            this.btnModifier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnSupprimer.FlatAppearance.BorderSize = 0;
            this.btnSupprimer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimer.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnSupprimer.Image = ((System.Drawing.Image)(resources.GetObject("btnSupprimer.Image")));
            this.btnSupprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupprimer.Location = new System.Drawing.Point(528, 122);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(204, 54);
            this.btnSupprimer.TabIndex = 43;
            this.btnSupprimer.Text = "    Supprimer";
            this.btnSupprimer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnMaxim
            // 
            this.btnMaxim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaxim.FlatAppearance.BorderSize = 0;
            this.btnMaxim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaxim.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaxim.ForeColor = System.Drawing.Color.White;
            this.btnMaxim.Image = ((System.Drawing.Image)(resources.GetObject("btnMaxim.Image")));
            this.btnMaxim.Location = new System.Drawing.Point(950, 6);
            this.btnMaxim.Name = "btnMaxim";
            this.btnMaxim.Size = new System.Drawing.Size(41, 35);
            this.btnMaxim.TabIndex = 54;
            this.btnMaxim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMaxim.UseVisualStyleBackColor = true;
            this.btnMaxim.Click += new System.EventHandler(this.btnMaxim_Click);
            // 
            // btnMinim
            // 
            this.btnMinim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinim.FlatAppearance.BorderSize = 0;
            this.btnMinim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinim.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinim.ForeColor = System.Drawing.Color.White;
            this.btnMinim.Image = ((System.Drawing.Image)(resources.GetObject("btnMinim.Image")));
            this.btnMinim.Location = new System.Drawing.Point(905, 5);
            this.btnMinim.Name = "btnMinim";
            this.btnMinim.Size = new System.Drawing.Size(41, 35);
            this.btnMinim.TabIndex = 53;
            this.btnMinim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMinim.UseVisualStyleBackColor = true;
            this.btnMinim.Click += new System.EventHandler(this.btnMinim_Click);
            // 
            // btnNormale
            // 
            this.btnNormale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNormale.FlatAppearance.BorderSize = 0;
            this.btnNormale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNormale.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNormale.ForeColor = System.Drawing.Color.White;
            this.btnNormale.Image = ((System.Drawing.Image)(resources.GetObject("btnNormale.Image")));
            this.btnNormale.Location = new System.Drawing.Point(950, 6);
            this.btnNormale.Name = "btnNormale";
            this.btnNormale.Size = new System.Drawing.Size(41, 35);
            this.btnNormale.TabIndex = 52;
            this.btnNormale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNormale.UseVisualStyleBackColor = true;
            this.btnNormale.Click += new System.EventHandler(this.btnNormale_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(990, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(41, 35);
            this.btnClose.TabIndex = 51;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(4, 700);
            this.panel1.TabIndex = 55;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(4, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1033, 4);
            this.panel2.TabIndex = 56;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1033, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(4, 696);
            this.panel3.TabIndex = 57;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(4, 696);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1029, 4);
            this.panel5.TabIndex = 58;
            // 
            // btnAfficherPhoto
            // 
            this.btnAfficherPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAfficherPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnAfficherPhoto.FlatAppearance.BorderSize = 0;
            this.btnAfficherPhoto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnAfficherPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAfficherPhoto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfficherPhoto.ForeColor = System.Drawing.Color.White;
            this.btnAfficherPhoto.Image = ((System.Drawing.Image)(resources.GetObject("btnAfficherPhoto.Image")));
            this.btnAfficherPhoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAfficherPhoto.Location = new System.Drawing.Point(780, 122);
            this.btnAfficherPhoto.Name = "btnAfficherPhoto";
            this.btnAfficherPhoto.Size = new System.Drawing.Size(211, 54);
            this.btnAfficherPhoto.TabIndex = 59;
            this.btnAfficherPhoto.Text = "    Image Produit";
            this.btnAfficherPhoto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAfficherPhoto.UseVisualStyleBackColor = false;
            this.btnAfficherPhoto.Click += new System.EventHandler(this.btnAfficherPhoto_Click);
            // 
            // lbltitre
            // 
            this.lbltitre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltitre.AutoSize = true;
            this.lbltitre.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.lbltitre.Location = new System.Drawing.Point(252, 19);
            this.lbltitre.Name = "lbltitre";
            this.lbltitre.Size = new System.Drawing.Size(453, 56);
            this.lbltitre.TabIndex = 61;
            this.lbltitre.Text = "Gestion De Produit";
            // 
            // cmbCategorie
            // 
            this.cmbCategorie.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategorie.FormattingEnabled = true;
            this.cmbCategorie.Location = new System.Drawing.Point(250, 212);
            this.cmbCategorie.Name = "cmbCategorie";
            this.cmbCategorie.Size = new System.Drawing.Size(204, 40);
            this.cmbCategorie.TabIndex = 62;
            this.cmbCategorie.Text = "Categorie:";
            this.cmbCategorie.SelectedIndexChanged += new System.EventHandler(this.cmbCategorie_SelectedIndexChanged);
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.Controls.Add(this.datainfo);
            this.panel7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.Location = new System.Drawing.Point(4, 301);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1026, 396);
            this.panel7.TabIndex = 63;
            // 
            // datainfo
            // 
            this.datainfo.AllowUserToAddRows = false;
            this.datainfo.AllowUserToDeleteRows = false;
            this.datainfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datainfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datainfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datainfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.Categorie,
            this.NomProduit,
            this.Quantité,
            this.PrixProduit});
            this.datainfo.Location = new System.Drawing.Point(5, 3);
            this.datainfo.Name = "datainfo";
            this.datainfo.ReadOnly = true;
            this.datainfo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.datainfo.Size = new System.Drawing.Size(1016, 386);
            this.datainfo.TabIndex = 51;
            this.datainfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datainfo_CellClick);
            // 
            // Select
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle6.NullValue = false;
            this.Select.DefaultCellStyle = dataGridViewCellStyle6;
            this.Select.HeaderText = "Select";
            this.Select.Name = "Select";
            this.Select.ReadOnly = true;
            // 
            // Categorie
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.Categorie.DefaultCellStyle = dataGridViewCellStyle7;
            this.Categorie.HeaderText = "Categorie";
            this.Categorie.Name = "Categorie";
            this.Categorie.ReadOnly = true;
            // 
            // NomProduit
            // 
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.NomProduit.DefaultCellStyle = dataGridViewCellStyle8;
            this.NomProduit.HeaderText = "Nom De Produit";
            this.NomProduit.Name = "NomProduit";
            this.NomProduit.ReadOnly = true;
            // 
            // Quantité
            // 
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.Quantité.DefaultCellStyle = dataGridViewCellStyle9;
            this.Quantité.HeaderText = "Quantité Produit";
            this.Quantité.Name = "Quantité";
            this.Quantité.ReadOnly = true;
            // 
            // PrixProduit
            // 
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.PrixProduit.DefaultCellStyle = dataGridViewCellStyle10;
            this.PrixProduit.HeaderText = "Prix De Produit";
            this.PrixProduit.Name = "PrixProduit";
            this.PrixProduit.ReadOnly = true;
            // 
            // FrmProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 700);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.cmbCategorie);
            this.Controls.Add(this.lbltitre);
            this.Controls.Add(this.btnAfficherPhoto);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMaxim);
            this.Controls.Add(this.btnMinim);
            this.Controls.Add(this.btnNormale);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupprimer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProduit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProduit";
            this.Load += new System.EventHandler(this.FrmProduit_Load);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datainfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Button btnAjouter;
        public System.Windows.Forms.Button btnModifier;
        public System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnMaxim;
        private System.Windows.Forms.Button btnMinim;
        private System.Windows.Forms.Button btnNormale;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.Button btnAfficherPhoto;
        private System.Windows.Forms.Label lbltitre;
        private System.Windows.Forms.ComboBox cmbCategorie;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView datainfo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomProduit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantité;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrixProduit;
    }
}