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
    public partial class frmModifierCategorie : Form
    {
        private int IdCat;
        private string NomCat;
        private DataGridView datainfo;
        public frmModifierCategorie(int idcat,string nomCat, DataGridView data)
        {
            InitializeComponent();
            this.IdCat = idcat;
            this.NomCat = nomCat;
            this.datainfo = data;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ADO.cmd = new SqlCommand("update Categorie set Nom_Categorie =@nom where Id_Categorie ="+txtId.Text, ADO.cnx);
            ADO.cmd.Parameters.AddWithValue("@nom", txtNom.Text);
            ADO.cmd.ExecuteNonQuery();
            MessageBox.Show("La Categorie Bien Modifier", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.datainfo.Rows.Clear();
            ADO.cmd = new SqlCommand("select * from Categorie", ADO.cnx);
            SqlDataReader rd = ADO.cmd.ExecuteReader();
            while (rd.Read())
            {
                this.datainfo.Rows.Add(rd[0].ToString(), rd[1].ToString());
            }
            rd.Close();

        }

        private void frmModifierCategorie_Load(object sender, EventArgs e)
        {
            txtId.Text = this.IdCat.ToString();
            txtNom.Text = this.NomCat;
            txtNom.Focus();
        }
    }
}
