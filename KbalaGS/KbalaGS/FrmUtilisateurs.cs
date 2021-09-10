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
    public partial class FrmUtilisateurs : Form
    {
        public FrmUtilisateurs()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmUtilisateurs_Load(object sender, EventArgs e)
        {
            ADO.cmd = new SqlCommand("select * from Utilisateur",ADO.cnx);
            SqlDataReader rd = ADO.cmd.ExecuteReader();
            while(rd.Read())
            {
                datainfo.Rows.Add(rd[0], rd[1], rd[2]);
            }
            rd.Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            FrmAjouterUser form = new FrmAjouterUser(datainfo);
            form.ShowDialog();
        }

        private void datainfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex!=-1)
            {
                if(e.ColumnIndex==4)
                {
                    string TypeCompte = datainfo.Rows[e.RowIndex].Cells[2].Value.ToString();
                    if(TypeCompte.ToLower().CompareTo("admin")==0)
                    {
                        MessageBox.Show("Desole Ce Compte Est Un Admin Vous Pouvez Pas Supprimer Ce Compte", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        if(MessageBox.Show("Voulez Vous Supprimmer Ce Compte ?","Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                        {
                            ADO.cmd = new SqlCommand("delete from Utilisateur where Nom_Utilisateur like @nom",ADO.cnx);
                            ADO.cmd.Parameters.AddWithValue("@nom", datainfo.Rows[e.RowIndex].Cells[0].Value.ToString());
                            ADO.cmd.ExecuteNonQuery();
                            MessageBox.Show("Le Compte Bien Supprimer !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Question);
                            datainfo.Rows.Clear();
                            ADO.cmd = new SqlCommand("select * from Utilisateur", ADO.cnx);
                            SqlDataReader rd = ADO.cmd.ExecuteReader();
                            while (rd.Read())
                            {
                                datainfo.Rows.Add(rd[0], rd[1], rd[2]);
                            }
                            rd.Close();
                        }
                        else
                        {
                            MessageBox.Show("La Supprission Est Annuler");
                        }
                    }
                }
                else if(e.ColumnIndex==3)
                {
                    FrmModifierUser form = new FrmModifierUser(datainfo.Rows[e.RowIndex].Cells[0].Value.ToString(), datainfo.Rows[e.RowIndex].Cells[1].Value.ToString(), datainfo.Rows[e.RowIndex].Cells[2].Value.ToString(),datainfo);
                    form.ShowDialog();
                }
            }
        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            datainfo.Rows.Clear();
            string Nom = "";
            if(txtRecherche.Text!= "Nom D'utilisateur")
            {
                Nom = txtRecherche.Text;
            }
            ADO.cmd = new SqlCommand("RechercheUtilisateur", ADO.cnx);
            ADO.cmd.CommandType = CommandType.StoredProcedure;
            ADO.cmd.Parameters.AddWithValue("@nom", Nom);
            SqlDataReader rd = ADO.cmd.ExecuteReader();
            while (rd.Read())
            {
                datainfo.Rows.Add(rd[0], rd[1], rd[2]);
            }
            rd.Close();
        }

        private void txtRecherche_Enter(object sender, EventArgs e)
        {
            if(txtRecherche.Text== "Nom D'utilisateur")
            {
                txtRecherche.Text = "";
            }
        }

        private void txtRecherche_Leave(object sender, EventArgs e)
        {
            if(txtRecherche.Text=="")
            {
                txtRecherche.Text = "Nom D'utilisateur";
            }
        }
    }
}
