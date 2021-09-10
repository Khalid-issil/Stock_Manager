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
    public partial class frmAjouterCategorie : Form
    {
       private  DataGridView datainfo;
        public frmAjouterCategorie(DataGridView data)
        {
            InitializeComponent();
            this.datainfo = data;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNom_Leave(object sender, EventArgs e)
        {
            if(txtNom.Text== "")
            {
                txtNom.Text = "Entrer Le Nom";

            }
        }

        private void txtNom_Enter(object sender, EventArgs e)
        {
            if (txtNom.Text == "Entrer Le Nom")
            {
                txtNom.Text = "";
            }
        }


        private void btnadd_Click(object sender, EventArgs e)
        {
            if(txtId.Text=="")
            {
                MessageBox.Show("Desole Veuillez Saisie Le Id de Categorie", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(txtNom.Text=="")
            {
                MessageBox.Show("Desole Veuillez Saisie Le Nom de Categorie", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ADO.cmd = new SqlCommand("select count(*) from Categorie where Id_Categorie =" + txtId.Text+ " or Nom_Categorie like '"+txtNom.Text+"'", ADO.cnx);
            int count = Convert.ToInt32(ADO.cmd.ExecuteScalar());
            if (count==0)
            {
                ADO.cmd = new SqlCommand("insert into Categorie values(@id,@nom)", ADO.cnx);
                ADO.cmd.Parameters.AddWithValue("@id", txtId.Text);
                ADO.cmd.Parameters.AddWithValue("@nom", txtNom.Text);
                ADO.cmd.ExecuteNonQuery();
                MessageBox.Show("La Categorie Bien Ajouter", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.datainfo.Rows.Clear();
                ADO.cmd = new SqlCommand("select * from Categorie", ADO.cnx);
                SqlDataReader rd = ADO.cmd.ExecuteReader();
                while (rd.Read())
                {
                    this.datainfo.Rows.Add(rd[0].ToString(), rd[1].ToString());
                }
                rd.Close();
                txtId.Text = "";
                txtNom.Text = "";
            }
            else
            {
                MessageBox.Show("Desole Ce Categorie Deja Exeste Vuillez Sasiez Une Autre Categorie", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
         
            
        }

        private void frmAjouterCategorie_Load(object sender, EventArgs e)
        {
            txtId.Focus();
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
