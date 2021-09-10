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
using System.Text.RegularExpressions;

namespace KbalaGS
{
    public partial class FrmAjouterUser : Form
    {
        private DataGridView data;
        public FrmAjouterUser(DataGridView datainfo)
        {
            InitializeComponent();
            this.data = datainfo;
        }

        private void FrmAjouterUser_Load(object sender, EventArgs e)
        {
            rdbUser.Checked = true;
        }

        private void rdbUser_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbAdmin.Checked==true)
            {
                rdbAdmin.Checked = false;
                rdbUser.Checked = true;
            }
        }

        private void rdbAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbUser.Checked==true)
            {
                rdbUser.Checked = false;
                rdbAdmin.Checked = true;
            }

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"^\w{4,20}@[a-z]{5,7}\.[a-z]{2,4}$");
            if (txtNomUtilisateur.Text=="")
            {
                MessageBox.Show("Vueillez Saisie Le Nom Dutilisateur !", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(txtPassword.Text=="")
            {
                MessageBox.Show("Vueillez Saisie Le Mote De Passe !", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(!reg.IsMatch(txtNomUtilisateur.Text))
            {
                MessageBox.Show("Desole Veuillez Tapez Votre Adresse Email Comme Nom dutilisateur","information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            ADO.cmd = new SqlCommand("select count(*) from Utilisateur where Nom_Utilisateur like @nom", ADO.cnx);
            ADO.cmd.Parameters.AddWithValue("@nom", txtNomUtilisateur.Text);
            int Nombre = Convert.ToInt32(ADO.cmd.ExecuteScalar());
            if(Nombre==0)
            {
                ADO.cmd = new SqlCommand("insert into Utilisateur values(@email,@code,@type)",ADO.cnx);
                ADO.cmd.Parameters.AddWithValue("@email", txtNomUtilisateur.Text);
                ADO.cmd.Parameters.AddWithValue("@code", txtPassword.Text);
                if(rdbAdmin.Checked==true)
                {
                    ADO.cmd.Parameters.AddWithValue("@type", "admin");
                }
                else
                {
                    ADO.cmd.Parameters.AddWithValue("@type", "user");
                }
                ADO.cmd.ExecuteNonQuery();
                MessageBox.Show("L'utilisateur Bien Ajouter ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                data.Rows.Clear();
                ADO.cmd = new SqlCommand("select * from Utilisateur", ADO.cnx);
                SqlDataReader rd = ADO.cmd.ExecuteReader();
                while (rd.Read())
                {
                    data.Rows.Add(rd[0], rd[1], rd[2]);
                }
                rd.Close();
                this.Close();
            }
            else
            {
                MessageBox.Show("Ce Nom D'utilisateur Exist Deja Veillez Ajouter Un Autre Nom D'Utilisateur", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
