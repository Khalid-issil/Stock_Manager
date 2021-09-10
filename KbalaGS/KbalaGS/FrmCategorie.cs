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
    public partial class FrmCategorie : Form
    {
        public FrmCategorie()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaxim_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnNormale.Visible = true;
            btnMaxim.Visible = false;
        }

        private void btnMinim_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnNormale_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnNormale.Visible = false;
            btnMaxim.Visible = true;
        }

        private void FrmCategorie_Load(object sender, EventArgs e)
        {
            btnMaxim.Visible = false;
            ADO.cmd = new SqlCommand("select * from Categorie", ADO.cnx);
            SqlDataReader rd = ADO.cmd.ExecuteReader();
            while(rd.Read())
            {
                datainfo.Rows.Add(rd[0].ToString(), rd[1].ToString());
            }
            rd.Close();
        }

        private void datainfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==2)
            {
                frmModifierCategorie form = new frmModifierCategorie(int.Parse(datainfo.Rows[e.RowIndex].Cells[0].Value.ToString()), datainfo.Rows[e.RowIndex].Cells[1].Value.ToString(),datainfo);
                form.ShowDialog();
            }
            else if (e.ColumnIndex == 3)
            {
               if(MessageBox.Show("Voulez Vous Supprimer Cette Categorie ?","Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    ADO.cmd = new SqlCommand("select count(*) from Produit where Id_Categorie = @id", ADO.cnx);
                    ADO.cmd.Parameters.AddWithValue("@id", datainfo.Rows[e.RowIndex].Cells[0].Value.ToString());
                    int count = Convert.ToInt32(ADO.cmd.ExecuteScalar());
                    if(count==0)
                    {
                        ADO.cmd = new SqlCommand("delete from Categorie where Id_Categorie = @id",ADO.cnx);
                        ADO.cmd.Parameters.AddWithValue("@id", datainfo.Rows[e.RowIndex].Cells[0].Value.ToString());
                        ADO.cmd.ExecuteNonQuery();
                        MessageBox.Show("Le Categorie Bien Supprimer", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        datainfo.Rows.Clear();
                        FrmCategorie_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Desole ilya Des Produit Dans Cette Categorie", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        frmErrorSupprimerCategorie from = new frmErrorSupprimerCategorie(datainfo.Rows[e.RowIndex].Cells[0].Value.ToString());
                        from.ShowDialog();
                    }
                }
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            frmAjouterCategorie form = new frmAjouterCategorie(datainfo);
            form.ShowDialog();
        }
    
        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            if(txtRecherche.Text!="Nom De Categorie")
            {
                datainfo.Rows.Clear();
                ADO.cmd = new SqlCommand("select * from Categorie where Nom_Categorie like '%" + txtRecherche.Text + "%'", ADO.cnx);
                SqlDataReader rd = ADO.cmd.ExecuteReader();
                while (rd.Read())
                {
                    datainfo.Rows.Add(rd[0].ToString(), rd[1].ToString());
                }
                rd.Close();
            }
            
        }

        private void txtRecherche_Leave(object sender, EventArgs e)
        {
            if(txtRecherche.Text=="")
            {
                txtRecherche.Text = "Nom De Categorie";
            }
        }

        private void txtRecherche_Enter(object sender, EventArgs e)
        {
            if(txtRecherche.Text== "Nom De Categorie")
            {
                txtRecherche.Text = "";
            }
        }
    }
}
