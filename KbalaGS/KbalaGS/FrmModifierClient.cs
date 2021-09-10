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
    public partial class FrmModifierClient : Form
    {
        private string cin;
        private DataGridView data;
        private string nom;
        private string prenom;
        private string adresse;
        private string tel;
        private string pays;
        private string ville;
        private string email;

        public FrmModifierClient(string cin,DataGridView datainfo)
        {
            InitializeComponent();
            this.cin = cin;
            this.data = datainfo;
        }
      
        private void Enter(TextBox txt, string chaine)
        {
            if (txt.Text == chaine)
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


  
        private void FrmModifierClient_Load(object sender, EventArgs e)
        {
            ADO.cmd = new SqlCommand("AfficheDetaislClient", ADO.cnx);
            ADO.cmd.CommandType = CommandType.StoredProcedure;
            ADO.cmd.Parameters.AddWithValue("@cin", this.cin);
            SqlDataReader rd = ADO.cmd.ExecuteReader();
            if(rd.Read())
            {
                txtcin.Text = rd[0].ToString();
                txtNom.Text = rd[1].ToString();
                nom= rd[1].ToString();
                txtPrenom.Text = rd[2].ToString();
                prenom= rd[2].ToString();
                txtAdresse.Text = rd[3].ToString();
                adresse = rd[3].ToString();
                txtTel.Text = rd[4].ToString();
                tel = rd[4].ToString();
                txtPays.Text = rd[5].ToString();
                pays = rd[5].ToString();
                txtVille.Text = rd[6].ToString();
                ville = rd[6].ToString();
                txtEmail.Text = rd[7].ToString();
                email= rd[7].ToString();
            }
            rd.Close();
        }




        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {

           
                int test;
                ADO.cmd = new SqlCommand("ModifierClient", ADO.cnx);
                ADO.cmd.CommandType = CommandType.StoredProcedure;
                ADO.cmd.Parameters.AddWithValue("@lastcin",cin);
                ADO.cmd.Parameters.AddWithValue("@cin", txtcin.Text);
                ADO.cmd.Parameters.AddWithValue("@nom", txtNom.Text);
                ADO.cmd.Parameters.AddWithValue("@prenom", txtPrenom.Text);
                ADO.cmd.Parameters.AddWithValue("@adresse", txtAdresse.Text);
                ADO.cmd.Parameters.AddWithValue("@tel", txtTel.Text);
                ADO.cmd.Parameters.AddWithValue("@pays", txtPays.Text);
                ADO.cmd.Parameters.AddWithValue("@ville", txtVille.Text);
                ADO.cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                ADO.cmd.Parameters.Add("@status", SqlDbType.Int).Direction = ParameterDirection.Output;
                ADO.cmd.ExecuteNonQuery();
                test = Convert.ToInt32(ADO.cmd.Parameters["@status"].Value);
                if (test == 1)
                {
                    MessageBox.Show("Le Client Bien Modifier", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    data.Rows.Clear();
                    ADO.cmd = new SqlCommand("AfficherTousLesClient", ADO.cnx);
                    ADO.cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader dr = ADO.cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        data.Rows.Add(false, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
                    }
                    dr.Close();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Le Client Non Modifier", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            







        }

        private void txtNom_Leave(object sender, EventArgs e)
        {
            Leave(txtNom,nom);
        }

        private void txtNom_Enter(object sender, EventArgs e)
        {
            Enter(txtNom, nom);
        }

        private void txtPrenom_Leave(object sender, EventArgs e)
        {
            Leave(txtPrenom, prenom);
        }

        private void txtPrenom_Enter(object sender, EventArgs e)
        {
            Enter(txtPrenom, prenom);
        }

        private void txtAdresse_Leave(object sender, EventArgs e)
        {
            Leave(txtAdresse, adresse);
        }

        private void txtAdresse_Enter(object sender, EventArgs e)
        {
            Enter(txtAdresse, adresse);
        }

        private void txtTel_Leave(object sender, EventArgs e)
        {
            Leave(txtTel, tel);
        }

        private void txtTel_Enter(object sender, EventArgs e)
        {
            Enter(txtTel, tel);
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            Leave(txtEmail, email);
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            Enter(txtEmail, email);
        }

        private void txtVille_Leave(object sender, EventArgs e)
        {
            Leave(txtVille,ville);
        }

        private void txtVille_Enter(object sender, EventArgs e)
        {
            Enter(txtVille, ville);
        }

        private void txtPays_Leave(object sender, EventArgs e)
        {
            Leave(txtPays, pays);
        }

        private void txtPays_Enter(object sender, EventArgs e)
        {
            Enter(txtPays, pays);
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtcin_Enter(object sender, EventArgs e)
        {
            if(txtcin.Text==cin)
            {
                txtcin.Text = "";
            }
        }

        private void txtcin_Leave(object sender, EventArgs e)
        {
            if (txtcin.Text == "")
            {
                txtcin.Text = cin;
            }
        }
    }
}
