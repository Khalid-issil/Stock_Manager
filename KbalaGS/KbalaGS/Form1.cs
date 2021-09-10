using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KbalaGS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ADO d = new ADO();
        private void Form1_Load(object sender, EventArgs e)
        {
            btnMaxim.Visible = false;
            this.WindowState = FormWindowState.Normal;
            panel1.Size=new Size(209, 548);
            panelParametre.Visible = false;

            // Desactiver Tous Les Button
            Descativer();
            //Ouverture De Connection
            d.Connecter();

        }

         // Methode desactiver Tous Les Button
         private void Descativer()
        {
            btnClient.Enabled = false;
            btnProduit.Enabled = false;
            btnCommande.Enabled = false;
            btnCategorie.Enabled = false;
            BtnUtilisateur.Enabled = false;
            panelmenu.Enabled = false;
            btnDeconnecter.Enabled = false;
        }
        // Button Client 
        private void btnClient_Click(object sender, EventArgs e)
        {
            panelmenu.Top = btnClient.Top;
            FrmClient form = new FrmClient();
            form.ShowDialog();
        }


        // Button Produit 
        private void btnProduit_Click(object sender, EventArgs e)
        {
            panelmenu.Top = btnProduit.Top;
            FrmProduit form = new FrmProduit();
            form.ShowDialog();
        }

        private void btnCategorie_Click(object sender, EventArgs e)
        {
            panelmenu.Top = btnCategorie.Top;
            FrmCategorie form = new FrmCategorie();
            form.ShowDialog();
        }

        //Button Commande
        private void btnCommande_Click(object sender, EventArgs e)
        {
            panelmenu.Top = btnCommande.Top;
            FrmCommande form = new FrmCommande();
            form.ShowDialog();
        }

        //Button Utlisateur
        private void BtnUtilisateur_Click(object sender, EventArgs e)
        {
            panelmenu.Top = BtnUtilisateur.Top;
            FrmUtilisateurs form = new FrmUtilisateurs();
            form.ShowDialog();
        }

        //Button Show Menu Toggle
        private void btnShowMenu_Click(object sender, EventArgs e)
        {
            if(panel1.Width==209)
            {
                panel1.Size = new Size(65, 548);
            }
            else
            {
                panel1.Size = new Size(209, 548);
            }

        }

        // Button Deconnecter
        private void btnConnecter_Click(object sender, EventArgs e)
        {
            
        }

        //Button Minimaze
        private void btnMinim_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //button Normale Mize
        private void btnNormale_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnNormale.Visible = false;
            btnMaxim.Visible = true;
        }

        //Button Fermer
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
            d.Deconnecter();
        }

        //Button Maxmize
        private void btnMaxim_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnNormale.Visible = true;
            btnMaxim.Visible = false;
        }
        // Button Parametre
        private void btnParametre_Click_1(object sender, EventArgs e)
        {
            panelParametre.Visible = !panelParametre.Visible;
            panelParametre.Size = new Size(233, 106);
        }

        private void btnShowLoginForm_Click_1(object sender, EventArgs e)
        {
            panelParametre.Height = 0;
            LoginFrm frm = new LoginFrm(this);
            frm.ShowDialog();
            panelParametre.Visible = false;
        }

        private void btnDeconnecter_Click(object sender, EventArgs e)
        {
            Descativer();
        }
    }
    
}
