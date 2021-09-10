namespace KbalaGS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelmenu = new System.Windows.Forms.Panel();
            this.btnAsk = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShowMenu = new System.Windows.Forms.Button();
            this.BtnUtilisateur = new System.Windows.Forms.Button();
            this.btnCommande = new System.Windows.Forms.Button();
            this.btnCategorie = new System.Windows.Forms.Button();
            this.btnProduit = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.panelParametre = new System.Windows.Forms.Panel();
            this.btnDeconnecter = new System.Windows.Forms.Button();
            this.btnShowLoginForm = new System.Windows.Forms.Button();
            this.btnMaxim = new System.Windows.Forms.Button();
            this.btnMinim = new System.Windows.Forms.Button();
            this.btnNormale = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnParametre = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelParametre.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(209, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(828, 10);
            this.panelTop.TabIndex = 12;
            // 
            // panelmenu
            // 
            this.panelmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panelmenu.Location = new System.Drawing.Point(1, 86);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(10, 54);
            this.panelmenu.TabIndex = 6;
            // 
            // btnAsk
            // 
            this.btnAsk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAsk.FlatAppearance.BorderSize = 0;
            this.btnAsk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsk.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsk.ForeColor = System.Drawing.Color.White;
            this.btnAsk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsk.Location = new System.Drawing.Point(0, 495);
            this.btnAsk.Name = "btnAsk";
            this.btnAsk.Size = new System.Drawing.Size(52, 53);
            this.btnAsk.TabIndex = 13;
            this.btnAsk.Text = "?";
            this.btnAsk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAsk.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.btnShowMenu);
            this.panel1.Controls.Add(this.BtnUtilisateur);
            this.panel1.Controls.Add(this.btnCommande);
            this.panel1.Controls.Add(this.btnCategorie);
            this.panel1.Controls.Add(this.btnProduit);
            this.panel1.Controls.Add(this.btnAsk);
            this.panel1.Controls.Add(this.panelmenu);
            this.panel1.Controls.Add(this.btnClient);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 548);
            this.panel1.TabIndex = 1;
            // 
            // btnShowMenu
            // 
            this.btnShowMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowMenu.FlatAppearance.BorderSize = 0;
            this.btnShowMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowMenu.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowMenu.ForeColor = System.Drawing.Color.White;
            this.btnShowMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnShowMenu.Image")));
            this.btnShowMenu.Location = new System.Drawing.Point(169, 12);
            this.btnShowMenu.Name = "btnShowMenu";
            this.btnShowMenu.Size = new System.Drawing.Size(34, 31);
            this.btnShowMenu.TabIndex = 16;
            this.btnShowMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowMenu.UseVisualStyleBackColor = true;
            this.btnShowMenu.Click += new System.EventHandler(this.btnShowMenu_Click);
            // 
            // BtnUtilisateur
            // 
            this.BtnUtilisateur.FlatAppearance.BorderSize = 0;
            this.BtnUtilisateur.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.BtnUtilisateur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUtilisateur.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUtilisateur.ForeColor = System.Drawing.Color.White;
            this.BtnUtilisateur.Image = ((System.Drawing.Image)(resources.GetObject("BtnUtilisateur.Image")));
            this.BtnUtilisateur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUtilisateur.Location = new System.Drawing.Point(9, 418);
            this.BtnUtilisateur.Name = "BtnUtilisateur";
            this.BtnUtilisateur.Size = new System.Drawing.Size(197, 54);
            this.BtnUtilisateur.TabIndex = 17;
            this.BtnUtilisateur.Text = " Utilisateur";
            this.BtnUtilisateur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnUtilisateur.UseVisualStyleBackColor = true;
            this.BtnUtilisateur.Click += new System.EventHandler(this.BtnUtilisateur_Click);
            // 
            // btnCommande
            // 
            this.btnCommande.FlatAppearance.BorderSize = 0;
            this.btnCommande.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnCommande.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommande.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommande.ForeColor = System.Drawing.Color.White;
            this.btnCommande.Image = ((System.Drawing.Image)(resources.GetObject("btnCommande.Image")));
            this.btnCommande.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCommande.Location = new System.Drawing.Point(9, 335);
            this.btnCommande.Name = "btnCommande";
            this.btnCommande.Size = new System.Drawing.Size(197, 54);
            this.btnCommande.TabIndex = 16;
            this.btnCommande.Text = "   Commande";
            this.btnCommande.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCommande.UseVisualStyleBackColor = true;
            this.btnCommande.Click += new System.EventHandler(this.btnCommande_Click);
            // 
            // btnCategorie
            // 
            this.btnCategorie.FlatAppearance.BorderSize = 0;
            this.btnCategorie.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnCategorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategorie.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorie.ForeColor = System.Drawing.Color.White;
            this.btnCategorie.Image = ((System.Drawing.Image)(resources.GetObject("btnCategorie.Image")));
            this.btnCategorie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategorie.Location = new System.Drawing.Point(9, 252);
            this.btnCategorie.Name = "btnCategorie";
            this.btnCategorie.Size = new System.Drawing.Size(197, 54);
            this.btnCategorie.TabIndex = 15;
            this.btnCategorie.Text = "    Categorie";
            this.btnCategorie.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCategorie.UseVisualStyleBackColor = true;
            this.btnCategorie.Click += new System.EventHandler(this.btnCategorie_Click);
            // 
            // btnProduit
            // 
            this.btnProduit.FlatAppearance.BorderSize = 0;
            this.btnProduit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnProduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduit.ForeColor = System.Drawing.Color.White;
            this.btnProduit.Image = ((System.Drawing.Image)(resources.GetObject("btnProduit.Image")));
            this.btnProduit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduit.Location = new System.Drawing.Point(9, 169);
            this.btnProduit.Name = "btnProduit";
            this.btnProduit.Size = new System.Drawing.Size(197, 54);
            this.btnProduit.TabIndex = 14;
            this.btnProduit.Text = "    Produit";
            this.btnProduit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProduit.UseVisualStyleBackColor = true;
            this.btnProduit.Click += new System.EventHandler(this.btnProduit_Click);
            // 
            // btnClient
            // 
            this.btnClient.FlatAppearance.BorderSize = 0;
            this.btnClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClient.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClient.ForeColor = System.Drawing.Color.White;
            this.btnClient.Image = ((System.Drawing.Image)(resources.GetObject("btnClient.Image")));
            this.btnClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClient.Location = new System.Drawing.Point(9, 86);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(197, 54);
            this.btnClient.TabIndex = 12;
            this.btnClient.Text = "    Client";
            this.btnClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // panelParametre
            // 
            this.panelParametre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panelParametre.Controls.Add(this.btnDeconnecter);
            this.panelParametre.Controls.Add(this.btnShowLoginForm);
            this.panelParametre.Location = new System.Drawing.Point(253, 10);
            this.panelParametre.Name = "panelParametre";
            this.panelParametre.Size = new System.Drawing.Size(233, 104);
            this.panelParametre.TabIndex = 37;
            // 
            // btnDeconnecter
            // 
            this.btnDeconnecter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnDeconnecter.FlatAppearance.BorderSize = 2;
            this.btnDeconnecter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnDeconnecter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeconnecter.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeconnecter.ForeColor = System.Drawing.Color.White;
            this.btnDeconnecter.Image = ((System.Drawing.Image)(resources.GetObject("btnDeconnecter.Image")));
            this.btnDeconnecter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeconnecter.Location = new System.Drawing.Point(3, 54);
            this.btnDeconnecter.Name = "btnDeconnecter";
            this.btnDeconnecter.Size = new System.Drawing.Size(226, 46);
            this.btnDeconnecter.TabIndex = 19;
            this.btnDeconnecter.Text = "    Deconnecter";
            this.btnDeconnecter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeconnecter.UseVisualStyleBackColor = true;
            this.btnDeconnecter.Click += new System.EventHandler(this.btnDeconnecter_Click);
            // 
            // btnShowLoginForm
            // 
            this.btnShowLoginForm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnShowLoginForm.FlatAppearance.BorderSize = 2;
            this.btnShowLoginForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnShowLoginForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowLoginForm.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowLoginForm.ForeColor = System.Drawing.Color.White;
            this.btnShowLoginForm.Image = ((System.Drawing.Image)(resources.GetObject("btnShowLoginForm.Image")));
            this.btnShowLoginForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowLoginForm.Location = new System.Drawing.Point(3, 2);
            this.btnShowLoginForm.Name = "btnShowLoginForm";
            this.btnShowLoginForm.Size = new System.Drawing.Size(226, 46);
            this.btnShowLoginForm.TabIndex = 18;
            this.btnShowLoginForm.Text = "    Connecter";
            this.btnShowLoginForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowLoginForm.UseVisualStyleBackColor = true;
            this.btnShowLoginForm.Click += new System.EventHandler(this.btnShowLoginForm_Click_1);
            // 
            // btnMaxim
            // 
            this.btnMaxim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaxim.FlatAppearance.BorderSize = 0;
            this.btnMaxim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaxim.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaxim.ForeColor = System.Drawing.Color.White;
            this.btnMaxim.Image = ((System.Drawing.Image)(resources.GetObject("btnMaxim.Image")));
            this.btnMaxim.Location = new System.Drawing.Point(946, 12);
            this.btnMaxim.Name = "btnMaxim";
            this.btnMaxim.Size = new System.Drawing.Size(41, 35);
            this.btnMaxim.TabIndex = 41;
            this.btnMaxim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMaxim.UseVisualStyleBackColor = true;
            this.btnMaxim.Click += new System.EventHandler(this.btnMaxim_Click_1);
            // 
            // btnMinim
            // 
            this.btnMinim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinim.FlatAppearance.BorderSize = 0;
            this.btnMinim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinim.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinim.ForeColor = System.Drawing.Color.White;
            this.btnMinim.Image = ((System.Drawing.Image)(resources.GetObject("btnMinim.Image")));
            this.btnMinim.Location = new System.Drawing.Point(899, 11);
            this.btnMinim.Name = "btnMinim";
            this.btnMinim.Size = new System.Drawing.Size(41, 35);
            this.btnMinim.TabIndex = 40;
            this.btnMinim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMinim.UseVisualStyleBackColor = true;
            this.btnMinim.Click += new System.EventHandler(this.btnMinim_Click_1);
            // 
            // btnNormale
            // 
            this.btnNormale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNormale.FlatAppearance.BorderSize = 0;
            this.btnNormale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNormale.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNormale.ForeColor = System.Drawing.Color.White;
            this.btnNormale.Image = ((System.Drawing.Image)(resources.GetObject("btnNormale.Image")));
            this.btnNormale.Location = new System.Drawing.Point(946, 11);
            this.btnNormale.Name = "btnNormale";
            this.btnNormale.Size = new System.Drawing.Size(41, 35);
            this.btnNormale.TabIndex = 39;
            this.btnNormale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNormale.UseVisualStyleBackColor = true;
            this.btnNormale.Click += new System.EventHandler(this.btnNormale_Click_1);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Maroon;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(993, 11);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(41, 35);
            this.btnClose.TabIndex = 38;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // btnParametre
            // 
            this.btnParametre.FlatAppearance.BorderSize = 0;
            this.btnParametre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParametre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParametre.ForeColor = System.Drawing.Color.White;
            this.btnParametre.Image = ((System.Drawing.Image)(resources.GetObject("btnParametre.Image")));
            this.btnParametre.Location = new System.Drawing.Point(211, 13);
            this.btnParametre.Name = "btnParametre";
            this.btnParametre.Size = new System.Drawing.Size(41, 35);
            this.btnParametre.TabIndex = 36;
            this.btnParametre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnParametre.UseVisualStyleBackColor = true;
            this.btnParametre.Click += new System.EventHandler(this.btnParametre_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 548);
            this.Controls.Add(this.panelParametre);
            this.Controls.Add(this.btnMaxim);
            this.Controls.Add(this.btnMinim);
            this.Controls.Add(this.btnNormale);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnParametre);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panelParametre.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnAsk;
        private System.Windows.Forms.Button btnShowMenu;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnClient;
        public System.Windows.Forms.Panel panelmenu;
        public System.Windows.Forms.Button btnProduit;
        public System.Windows.Forms.Button btnCategorie;
        public System.Windows.Forms.Button btnCommande;
        public System.Windows.Forms.Button BtnUtilisateur;
        private System.Windows.Forms.Panel panelParametre;
        public System.Windows.Forms.Button btnDeconnecter;
        private System.Windows.Forms.Button btnShowLoginForm;
        private System.Windows.Forms.Button btnMaxim;
        private System.Windows.Forms.Button btnMinim;
        private System.Windows.Forms.Button btnNormale;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnParametre;
    }
}

