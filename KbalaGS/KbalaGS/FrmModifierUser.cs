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
    public partial class FrmModifierUser : Form
    {
        private string Username;
        private string Password;
        private string Type_Compte;
        private DataGridView data;
        public FrmModifierUser(string Username,string Password,string Type,DataGridView datainfo)
        {
            InitializeComponent();
            this.Username = Username;
            this.Password = Password;
            this.Type_Compte = Type;
            this.data = datainfo;
        }

        private void FrmModifierUser_Load(object sender, EventArgs e)
        {
            rdbUser.Checked = true;
            txtNomUtilisateur.Text = Username;
            txtPassword.Text = this.Password;
            if(Type_Compte.ToLower().CompareTo("admin")==0)
            {
                rdbAdmin.Checked = true;
            }
            else
            {
                rdbUser.Checked = true;
            }
        }

        private void rdbUser_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAdmin.Checked == true)
            {
                rdbAdmin.Checked = false;
                rdbUser.Checked = true;
            }
        }

        private void rdbAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbUser.Checked == true)
            {
                rdbUser.Checked = false;
                rdbAdmin.Checked = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"^\w{4,20}@[a-z]{5,7}\.[a-z]{2,4}$");
            if (!reg.IsMatch(txtNomUtilisateur.Text))
            {
                MessageBox.Show("Desole Veuillez Tapez Votre Adresse Email Comme Nom dutilisateur", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ADO.cmd = new SqlCommand("select count(*) from Utilisateur where Nom_Utilisateur like @nom", ADO.cnx);
            ADO.cmd.Parameters.AddWithValue("@nom", txtNomUtilisateur.Text);
            int Nombre = Convert.ToInt32(ADO.cmd.ExecuteScalar());
            if(Nombre==0)
            {
                string type;
                if (rdbAdmin.Checked == true)
                {
                    type = "admin";
                }
                else
                {
                    type = "user";
                }
                ADO.cmd = new SqlCommand("Update Utilisateur set Nom_Utilisateur = @nom,Mot_De_Passe = @pass ,Type_Utilisateur=@type where Nom_Utilisateur like @lastnom", ADO.cnx);
                ADO.cmd.Parameters.AddWithValue("@nom", txtNomUtilisateur.Text);
                ADO.cmd.Parameters.AddWithValue("@pass", txtPassword.Text);
                ADO.cmd.Parameters.AddWithValue("@type", type);
                ADO.cmd.Parameters.AddWithValue("@lastnom", this.Username);
                ADO.cmd.ExecuteNonQuery();
                MessageBox.Show("Les Info De Ce Compte Bien Modifier !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ADO.cmd = new SqlCommand("select * from Utilisateur", ADO.cnx);
                SqlDataReader rd = ADO.cmd.ExecuteReader();
                data.Rows.Clear();
                while (rd.Read())
                {
                    data.Rows.Add(rd[0], rd[1], rd[2]);
                }
                rd.Close();
                this.Close();
            }
            else
            {
                MessageBox.Show("Desole Ce Nom D'utilisateur exist deja Vueillez Saisie Une Autre Nom", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void txtNomUtilisateur_Enter(object sender, EventArgs e)
        {
            if(txtNomUtilisateur.Text==this.Username)
            {
                txtNomUtilisateur.Text = "";
            }
        }

        private void txtNomUtilisateur_Leave(object sender, EventArgs e)
        {
            if(txtNomUtilisateur.Text=="")
            {
                txtNomUtilisateur.Text = this.Username;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if(txtPassword.Text==this.Password)
            {
                txtPassword.Text = "";
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text =="")
            {
                txtPassword.Text = this.Password;
            }
        }
    }
}
