using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace KbalaGS
{
    public partial class FrmAjouterClient : Form
    {
        DataGridView data;
        public FrmAjouterClient(DataGridView datainfo)
        {
            InitializeComponent();
            data = datainfo;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {

        }

        // Leave And Enter In Tsxt Box

        private void Enter(TextBox txt,string chaine)
        {
            if(txt.Text==chaine)
            {
                txt.Text = "";
            }
        }
        private void Leave(TextBox txt, string chaine)
        {
            if (txt.Text == "")
            {
                txt.Text = chaine;
            }
        }
        private void txtNom_Enter(object sender, EventArgs e)
        {
            Enter(txtNom, "Nom de Client");
        }

        private void txtNom_Leave(object sender, EventArgs e)
        {
            Leave(txtNom, "Nom de Client");
        }

        private void txtPrenom_Enter(object sender, EventArgs e)
        {
            Enter(txtPrenom, "Prenom de Client");
        }

        private void txtPrenom_Leave(object sender, EventArgs e)
        {
            Leave(txtPrenom, "Prenom de Client");
        }

        private void txtAdresse_Leave(object sender, EventArgs e)
        {
            Leave(txtAdresse, "Adresse Client");
        }

        private void txtAdresse_Enter(object sender, EventArgs e)
        {
            Enter(txtAdresse, "Adresse Client");
        }

        private void txtTel_Leave(object sender, EventArgs e)
        {
            Leave(txtTel, "Telephone Client");
        }

        private void txtTel_Enter(object sender, EventArgs e)
        {
            Enter(txtTel, "Telephone Client");
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            Leave(txtEmail, "Email Client");
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            Enter(txtEmail, "Email Client");
        }

        private void txtVille_Enter(object sender, EventArgs e)
        {
            Enter(txtVille, "Ville Client");
        }

        private void txtVille_Leave(object sender, EventArgs e)
        {
            Leave(txtVille, "Ville Client");
        }

        private void txtPays_Leave(object sender, EventArgs e)
        {
            Leave(txtPays, "Pays Client");
        }

        private void txtPays_Enter(object sender, EventArgs e)
        {
            Enter(txtPays, "Pays Client");
        }


        // Methode Vider
        private void Vider()
        {
            txtNom.Text = "Nom de Client";
            txtPrenom.Text = "Prenom de Client";
            txtAdresse.Text = "Adresse Client";
            txtEmail.Text = "Email Client";
            txtVille.Text = "Ville Client";
            txtPays.Text = "Pays Client";
            txtTel.Text = "Telephone Client";
            txtcin.Text = "CIN Client";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Vider();
        }


        private void btnadd_Click(object sender, EventArgs e)
        {
           if(txtNom.Text== "Nom de Client")
            {
                MessageBox.Show("Desole Vuiellez Saisie Le Nom de Client", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
           else if(txtPrenom.Text== "Prenom de Client")
            {
                MessageBox.Show("Desole Vuiellez Saisie Le Prenom de Client", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            else if (txtcin.Text == "CIN Client")
            {
                MessageBox.Show("Desole Vuiellez Saisie Le CIN de Client", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            else if (txtEmail.Text == "Email Client")
            {
                MessageBox.Show("Desole Vuiellez Saisie L'email de Client", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            else if (txtTel.Text == "Telephone Client")
            {
                MessageBox.Show("Desole Vuiellez Saisie Le Telephone  de Client", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            else if (txtPays.Text == "Pays Client")
            {
                MessageBox.Show("Desole Vuiellez Saisie Le Pays  de Client", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            else if (txtVille.Text == "Ville Client")
            {
                MessageBox.Show("Desole Vuiellez Saisie Le Ville  de Client", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
           else
            {
                int test;
                ADO.cmd = new SqlCommand("InsertClient", ADO.cnx);
                ADO.cmd.CommandType = CommandType.StoredProcedure;
                ADO.cmd.Parameters.AddWithValue("@nom", txtNom.Text);
                ADO.cmd.Parameters.AddWithValue("@prenom", txtPrenom.Text);
                ADO.cmd.Parameters.AddWithValue("@adresse", txtAdresse.Text);
                ADO.cmd.Parameters.AddWithValue("@tel", txtTel.Text);
                ADO.cmd.Parameters.AddWithValue("@pays", txtPays.Text);
                ADO.cmd.Parameters.AddWithValue("@ville", txtVille.Text);
                ADO.cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                ADO.cmd.Parameters.AddWithValue("@cin", txtcin.Text);
                ADO.cmd.Parameters.Add("@status", SqlDbType.Int).Direction = ParameterDirection.Output;
                ADO.cmd.ExecuteNonQuery();
                test = int.Parse(ADO.cmd.Parameters["@status"].Value.ToString());
                if(test==-1)
                {
                    MessageBox.Show("Desole Ce Client Est Exeste Deja", "information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if(test==1)
                {
                    MessageBox.Show("Le Client Bien Ajouter Dans La Liste Des Clients", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    data.Rows.Clear();
                    ADO.cmd = new SqlCommand("AfficherTousLesClient", ADO.cnx);
                    ADO.cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader rd = ADO.cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        data.Rows.Add(false,rd[0].ToString(), rd[1].ToString(), rd[2].ToString(), rd[3].ToString(), rd[4].ToString(), rd[5].ToString(), rd[6].ToString(), rd[7].ToString());
                    }
                    rd.Close();
                    this.Close();
                }
            }
        }
         
        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void FrmAjouterClient_Load(object sender, EventArgs e)
        {
        }

        private void txtcin_Leave(object sender, EventArgs e)
        {
            if (txtcin.Text == "")
            {
                txtcin.Text = "CIN Client";
            }
        }

        private void txtcin_Enter(object sender, EventArgs e)
        {
            if(txtcin.Text== "CIN Client")
            {
                txtcin.Text = "";
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
