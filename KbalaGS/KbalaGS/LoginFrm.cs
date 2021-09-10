using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace KbalaGS
{
    public partial class LoginFrm : Form
    {
        ADO d = new ADO();
        Form1 frmMenu;
        public LoginFrm(Form1 frmMenu)
        {
            InitializeComponent();
            this.frmMenu = frmMenu;
        } 
        private void btnQuitterlgf_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNomUtilisateur_Enter(object sender, EventArgs e)
        {
            if(txtNomUtilisateur.Text== "Nom D'utilisateur")
            {
                txtNomUtilisateur.Text = "";
                txtNomUtilisateur.ForeColor = Color.FloralWhite;
            }
        }

        private void txtNomUtilisateur_Leave(object sender, EventArgs e)
        {
            if (txtNomUtilisateur.Text == "")
            {
                txtNomUtilisateur.Text = "Nom D'utilisateur";
                txtNomUtilisateur.ForeColor = Color.Silver;
            }
        }

        private void txtMotedepasse_Leave(object sender, EventArgs e)
        {
            if (txtMotedepasse.Text == "")
            {
                txtMotedepasse.Text = "Mot de Passe";
                txtMotedepasse.ForeColor = Color.Silver;
                txtMotedepasse.UseSystemPasswordChar = true;
            }
        }

        private void txtMotedepasse_Enter(object sender, EventArgs e)
        {
            if (txtMotedepasse.Text == "Mot de Passe")
            {
                txtMotedepasse.Text = "";
                txtMotedepasse.ForeColor = Color.Silver;
                txtMotedepasse.UseSystemPasswordChar = false;
                txtMotedepasse.PasswordChar = '*';
            }
        }

        // Methode de Rempler les champs
        private bool Rempler()
        {
             bool test = true;
            Regex reg = new Regex(@"^\w{4,20}@[a-z]{5,7}\.[a-z]{2,4}$");
            if(txtNomUtilisateur.Text== "Nom D'utilisateur")
            {
                MessageBox.Show("Veuillez Entrer Votre Nom dutilisateur");
                test = false;
            }
            if(txtMotedepasse.Text == "Mot de Passe")
            {
                MessageBox.Show("Veuillez Entrer Votre Nom Mot de passe");
                test = false;
             
            }
            if(!reg.IsMatch(txtNomUtilisateur.Text))
            {
                MessageBox.Show("Desole Veuillez Tapez Votre Adresse Email Comme Nom dutilisateur");
                test = false;
              
            }

            return test;
        }
        private void btnConnecter_Click(object sender, EventArgs e)
        {
            if(Rempler()==true)
            {
                ADO.cmd = new SqlCommand("select count(*) from Utilisateur where Nom_Utilisateur like @email ", ADO.cnx);
                ADO.cmd.Parameters.AddWithValue("@email", txtNomUtilisateur.Text);
                int Resultat = Convert.ToInt32(ADO.cmd.ExecuteScalar());
                if(Resultat==0)
                {
                    MessageBox.Show("Desole Aucun Compte A Ce Nom Dutilisateur " + txtNomUtilisateur.Text);
                }
                else
                {
                    ADO.cmd = new SqlCommand("select Mot_De_Passe,Type_Utilisateur from Utilisateur where Nom_Utilisateur like @email", ADO.cnx);
                    ADO.cmd.Parameters.AddWithValue("@email", txtNomUtilisateur.Text);
                    SqlDataReader rd = ADO.cmd.ExecuteReader();
                    while(rd.Read())
                    {
                        if(rd[0].ToString().ToLower().CompareTo(txtMotedepasse.Text.ToLower())==0)
                        {
                            MessageBox.Show("Bien Venu");
                            btnQuitterlgf_Click(sender, e);
                            if(rd[1].ToString().ToLower().CompareTo("admin")==0)
                            {
                                ActiverAdmin();
                            }
                            else
                            {
                                ActiverUser();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Desole Le Mote de Passe Est Incorrect ");
                        }
                    }
                    rd.Close();
                        
                }
            }

        }

        private void LoginFrm_Load(object sender, EventArgs e)
        {
          
        }
        // Methode dactiver Tous le button Pour Ladmin
        private void ActiverAdmin()
        {
            frmMenu.btnClient.Enabled = true;
            frmMenu.btnProduit.Enabled = true;
            frmMenu.btnCommande.Enabled = true;
            frmMenu.btnCategorie.Enabled = true;
            frmMenu.BtnUtilisateur.Enabled = true;
            frmMenu.panelmenu.Enabled = true;
            frmMenu.btnDeconnecter.Enabled = true;
        }
        // Methode dactiver Tous le button Pour Lutilisateur
        private void ActiverUser()
        {
            frmMenu.btnClient.Enabled = true;
            frmMenu.btnProduit.Enabled = true;
            frmMenu.btnCommande.Enabled = true;
            frmMenu.btnCategorie.Enabled = true;
            frmMenu.BtnUtilisateur.Enabled = false;
            frmMenu.panelmenu.Enabled = true;
            frmMenu.btnDeconnecter.Enabled = true;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtMotedepasse_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtNomUtilisateur_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
