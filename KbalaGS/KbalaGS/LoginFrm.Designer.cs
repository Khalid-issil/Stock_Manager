namespace KbalaGS
{
    partial class LoginFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnQuitterlgf = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtNomUtilisateur = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtMotedepasse = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnConnecter = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 4);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(333, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 312);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 313);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(330, 3);
            this.panel4.TabIndex = 3;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // btnQuitterlgf
            // 
            this.btnQuitterlgf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuitterlgf.FlatAppearance.BorderSize = 0;
            this.btnQuitterlgf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitterlgf.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitterlgf.ForeColor = System.Drawing.Color.White;
            this.btnQuitterlgf.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitterlgf.Image")));
            this.btnQuitterlgf.Location = new System.Drawing.Point(291, 4);
            this.btnQuitterlgf.Name = "btnQuitterlgf";
            this.btnQuitterlgf.Size = new System.Drawing.Size(41, 35);
            this.btnQuitterlgf.TabIndex = 33;
            this.btnQuitterlgf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuitterlgf.UseVisualStyleBackColor = true;
            this.btnQuitterlgf.Click += new System.EventHandler(this.btnQuitterlgf_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FloralWhite;
            this.label1.Location = new System.Drawing.Point(91, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 37);
            this.label1.TabIndex = 34;
            this.label1.Text = "Connexion";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(69, 141);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(255, 1);
            this.panel5.TabIndex = 36;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // txtNomUtilisateur
            // 
            this.txtNomUtilisateur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.txtNomUtilisateur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomUtilisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomUtilisateur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtNomUtilisateur.Location = new System.Drawing.Point(69, 116);
            this.txtNomUtilisateur.Multiline = true;
            this.txtNomUtilisateur.Name = "txtNomUtilisateur";
            this.txtNomUtilisateur.Size = new System.Drawing.Size(231, 26);
            this.txtNomUtilisateur.TabIndex = 35;
            this.txtNomUtilisateur.Text = "Nom D\'utilisateur";
            this.txtNomUtilisateur.TextChanged += new System.EventHandler(this.txtNomUtilisateur_TextChanged);
            this.txtNomUtilisateur.Enter += new System.EventHandler(this.txtNomUtilisateur_Enter);
            this.txtNomUtilisateur.Leave += new System.EventHandler(this.txtNomUtilisateur_Leave);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(69, 192);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(255, 1);
            this.panel6.TabIndex = 38;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // txtMotedepasse
            // 
            this.txtMotedepasse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.txtMotedepasse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMotedepasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotedepasse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMotedepasse.Location = new System.Drawing.Point(69, 167);
            this.txtMotedepasse.Multiline = true;
            this.txtMotedepasse.Name = "txtMotedepasse";
            this.txtMotedepasse.Size = new System.Drawing.Size(231, 26);
            this.txtMotedepasse.TabIndex = 37;
            this.txtMotedepasse.Text = "Mot de Passe";
            this.txtMotedepasse.TextChanged += new System.EventHandler(this.txtMotedepasse_TextChanged);
            this.txtMotedepasse.Enter += new System.EventHandler(this.txtMotedepasse_Enter);
            this.txtMotedepasse.Leave += new System.EventHandler(this.txtMotedepasse_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.pictureBox1.Size = new System.Drawing.Size(41, 35);
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(22, 158);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.pictureBox2.Size = new System.Drawing.Size(41, 35);
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnConnecter
            // 
            this.btnConnecter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnConnecter.FlatAppearance.BorderSize = 0;
            this.btnConnecter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnConnecter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnecter.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnecter.ForeColor = System.Drawing.Color.White;
            this.btnConnecter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConnecter.Location = new System.Drawing.Point(22, 220);
            this.btnConnecter.Name = "btnConnecter";
            this.btnConnecter.Size = new System.Drawing.Size(302, 45);
            this.btnConnecter.TabIndex = 42;
            this.btnConnecter.Text = "Connecter";
            this.btnConnecter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConnecter.UseVisualStyleBackColor = false;
            this.btnConnecter.Click += new System.EventHandler(this.btnConnecter_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 312);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // LoginFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(336, 316);
            this.Controls.Add(this.btnConnecter);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.txtMotedepasse);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txtNomUtilisateur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQuitterlgf);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginFrm";
            this.Load += new System.EventHandler(this.LoginFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnQuitterlgf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtNomUtilisateur;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtMotedepasse;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnConnecter;
        private System.Windows.Forms.Panel panel2;
    }
}