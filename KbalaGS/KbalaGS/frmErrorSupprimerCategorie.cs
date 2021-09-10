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
    public partial class frmErrorSupprimerCategorie : Form
    {
        private string Categorie;
        public frmErrorSupprimerCategorie(string Categorie)
        {
            InitializeComponent();
            this.Categorie = Categorie;
        }

        private void frmErrorSupprimerCategorie_Load(object sender, EventArgs e)
        {
            ADO.cmd = new SqlCommand("select Nom_Produit,Quantite_Produit,Prix_Produit From Produit where Id_Categorie = @cat", ADO.cnx);
            ADO.cmd.Parameters.AddWithValue("@cat", Categorie);
            SqlDataReader rd = ADO.cmd.ExecuteReader();
            while(rd.Read())
            {
                datainfo.Rows.Add(rd[0].ToString(), rd[1].ToString(), rd[2].ToString());
            }
            rd.Close();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
