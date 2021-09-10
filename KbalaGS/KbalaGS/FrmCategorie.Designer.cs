namespace KbalaGS
{
    partial class FrmCategorie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategorie));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbltitre = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnMinim = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.datainfo = new System.Windows.Forms.DataGridView();
            this.Id_Categorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_Categorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modifier = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Supprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnNormale = new System.Windows.Forms.Button();
            this.btnMaxim = new System.Windows.Forms.Button();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datainfo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitre
            // 
            this.lbltitre.AutoSize = true;
            this.lbltitre.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.lbltitre.Location = new System.Drawing.Point(230, 7);
            this.lbltitre.Name = "lbltitre";
            this.lbltitre.Size = new System.Drawing.Size(528, 56);
            this.lbltitre.TabIndex = 62;
            this.lbltitre.Text = "Gestion De Categorie";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1037, 4);
            this.panel2.TabIndex = 63;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1033, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(4, 620);
            this.panel3.TabIndex = 64;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 620);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1033, 4);
            this.panel5.TabIndex = 65;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(4, 616);
            this.panel1.TabIndex = 66;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel4.Location = new System.Drawing.Point(46, 175);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(968, 3);
            this.panel4.TabIndex = 68;
            // 
            // txtRecherche
            // 
            this.txtRecherche.BackColor = System.Drawing.SystemColors.Control;
            this.txtRecherche.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecherche.ForeColor = System.Drawing.Color.DimGray;
            this.txtRecherche.Location = new System.Drawing.Point(414, 127);
            this.txtRecherche.Multiline = true;
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(255, 36);
            this.txtRecherche.TabIndex = 69;
            this.txtRecherche.Text = "Nom De Categorie";
            this.txtRecherche.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRecherche.TextChanged += new System.EventHandler(this.txtRecherche_TextChanged);
            this.txtRecherche.Enter += new System.EventHandler(this.txtRecherche_Enter);
            this.txtRecherche.Leave += new System.EventHandler(this.txtRecherche_Leave);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel6.Location = new System.Drawing.Point(414, 161);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(255, 2);
            this.panel6.TabIndex = 70;
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
            this.btnAjouter.Location = new System.Drawing.Point(46, 115);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(228, 54);
            this.btnAjouter.TabIndex = 67;
            this.btnAjouter.Text = "         Ajouter";
            this.btnAjouter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
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
            this.btnMinim.TabIndex = 57;
            this.btnMinim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMinim.UseVisualStyleBackColor = true;
            this.btnMinim.Click += new System.EventHandler(this.btnMinim_Click);
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
            this.btnClose.TabIndex = 55;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.Controls.Add(this.datainfo);
            this.panel7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.Location = new System.Drawing.Point(12, 201);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1015, 412);
            this.panel7.TabIndex = 71;
            // 
            // datainfo
            // 
            this.datainfo.AllowUserToAddRows = false;
            this.datainfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datainfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datainfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.datainfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datainfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Categorie,
            this.Nom_Categorie,
            this.Modifier,
            this.Supprimer});
            this.datainfo.Location = new System.Drawing.Point(4, 3);
            this.datainfo.MultiSelect = false;
            this.datainfo.Name = "datainfo";
            this.datainfo.ReadOnly = true;
            this.datainfo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.datainfo.Size = new System.Drawing.Size(1008, 406);
            this.datainfo.TabIndex = 72;
            // 
            // Id_Categorie
            // 
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_Categorie.DefaultCellStyle = dataGridViewCellStyle9;
            this.Id_Categorie.HeaderText = "ID Categorie";
            this.Id_Categorie.Name = "Id_Categorie";
            this.Id_Categorie.ReadOnly = true;
            // 
            // Nom_Categorie
            // 
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nom_Categorie.DefaultCellStyle = dataGridViewCellStyle10;
            this.Nom_Categorie.HeaderText = "Nom Categorie";
            this.Nom_Categorie.Name = "Nom_Categorie";
            this.Nom_Categorie.ReadOnly = true;
            // 
            // Modifier
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            this.Modifier.DefaultCellStyle = dataGridViewCellStyle11;
            this.Modifier.HeaderText = "Modifier";
            this.Modifier.Name = "Modifier";
            this.Modifier.ReadOnly = true;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseColumnTextForButtonValue = true;
            // 
            // Supprimer
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(9)))), ((int)(((byte)(90)))));
            this.Supprimer.DefaultCellStyle = dataGridViewCellStyle12;
            this.Supprimer.HeaderText = "Supprimer";
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.ReadOnly = true;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseColumnTextForButtonValue = true;
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
            this.btnNormale.TabIndex = 56;
            this.btnNormale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNormale.UseVisualStyleBackColor = true;
            this.btnNormale.Click += new System.EventHandler(this.btnNormale_Click);
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
            this.btnMaxim.TabIndex = 58;
            this.btnMaxim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMaxim.UseVisualStyleBackColor = true;
            this.btnMaxim.Click += new System.EventHandler(this.btnMaxim_Click);
            // 
            // FrmCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 624);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbltitre);
            this.Controls.Add(this.btnMaxim);
            this.Controls.Add(this.btnMinim);
            this.Controls.Add(this.btnNormale);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCategorie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCategorie";
            this.Load += new System.EventHandler(this.FrmCategorie_Load);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datainfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMinim;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbltitre;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView datainfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Categorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_Categorie;
        private System.Windows.Forms.DataGridViewButtonColumn Modifier;
        private System.Windows.Forms.DataGridViewButtonColumn Supprimer;
        private System.Windows.Forms.Button btnNormale;
        private System.Windows.Forms.Button btnMaxim;
    }
}