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
    public partial class FrmProduit : Form
    {
        public FrmProduit()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNormale_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnNormale.Visible = false;
            btnMaxim.Visible = true;
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
      
 
        private void FrmProduit_Load(object sender, EventArgs e)
        {
            btnMaxim.Visible = false;
            //Test Categories
            ADO.cmd = new SqlCommand("select COUNT(*) from Categorie", ADO.cnx);
            int NombreCatgories =Convert.ToInt32(ADO.cmd.ExecuteScalar());
            if(NombreCatgories==0)
            {
                MessageBox.Show("Veuillez Dabord Ajouter Des Categories Pour Faire La Gestion Des Produits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            cmbCategorie.Items.Add("Tous");
            ADO.cmd = new SqlCommand("AfficherCetgorie", ADO.cnx);
            ADO.cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader rdcat = ADO.cmd.ExecuteReader();
            while (rdcat.Read())
            {
                cmbCategorie.Items.Add(rdcat[0]);
            }
            rdcat.Close();
            //ADO.cmd = new SqlCommand("Select dbo.AfficherNomCategorie(1)", ADO.cnx);
            //var NomCat = ADO.cmd.ExecuteScalar();
            //MessageBox.Show(NomCat.ToString());
            ADO.cmd = new SqlCommand("AfficherTousProduit", ADO.cnx);
            ADO.cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader rd = ADO.cmd.ExecuteReader();
            List<string[]> liste = new List<string[]>();
            while(rd.Read())
            {

               string cat = rd[0].ToString();
               string nom = rd[1].ToString();
               string quant = rd[2].ToString();
               string prix = rd[3].ToString();
                string[] tab = { cat, nom, quant, prix };
                liste.Add(tab);

            }
            rd.Close();

            for (int i = 0; i < liste.Count; i++)
            {
                ADO.cmd = new SqlCommand("Select dbo.AfficherNomCategorie(" + int.Parse(liste[i][0]) + ")", ADO.cnx);
                var NomCat = ADO.cmd.ExecuteScalar();
                datainfo.Rows.Add(false, NomCat.ToString(), liste[i][1], liste[i][2], liste[i][3]);
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            FrmAjouterProduit form = new FrmAjouterProduit(datainfo);
            form.ShowDialog();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int count = 0, index = -1;
            if(datainfo.Rows.Count<=0)
            {
                MessageBox.Show("Aucun Produit Pour Le Modifier Vueillez Ajouter Des Produits", "Error Modifier Produit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                for(int i=0;i<datainfo.Rows.Count;i++)
                {
                    if(datainfo.Rows[i].Cells[0].Value.ToString().ToLower() == "true")
                    {
                        count++;
                        index = i;
                        if(count>1)
                        {
                            break;
                        }
                    }
                }
                if(count>1)
                {
                    MessageBox.Show("Veuillez Selectionnez Une Seule Ligne", "Error Plusieur Ligne", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                if(index==-1)
                {
                    MessageBox.Show("Veuillez Selectionnez Une Ligne", "Error Aucun Ligne", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                else
                {
                    string NomProduit=datainfo.Rows[index].Cells[2].Value.ToString();
                    int QuantiteProduit=int.Parse(datainfo.Rows[index].Cells[3].Value.ToString());
                    string PrixProduit= datainfo.Rows[index].Cells[4].Value.ToString();
                    string CategorieProduit= datainfo.Rows[index].Cells[1].Value.ToString();
                    byte[] ImageProduit=null;
                    ADO.cmd = new SqlCommand("AfficherImageProduit", ADO.cnx);
                    ADO.cmd.CommandType = CommandType.StoredProcedure;
                    ADO.cmd.Parameters.AddWithValue("@nomProduit", NomProduit);
                    SqlDataReader rd = ADO.cmd.ExecuteReader();
                    while(rd.Read())
                    {
                        ImageProduit =(byte[])(rd[0]);
                    }

                    rd.Close();
                    FrmModifierProduit form = new FrmModifierProduit(CategorieProduit, NomProduit, QuantiteProduit, PrixProduit,ImageProduit,datainfo);
                    form.ShowDialog();

                }

            }
          
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {


            int count = 0, index = -1;
            if (datainfo.Rows.Count <= 0)
            {
                MessageBox.Show("Aucun Produit Pour Le Modifier Vueillez Ajouter Des Produits", "Error Modifier Produit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                for (int i = 0; i < datainfo.Rows.Count; i++)
                {
                    if (datainfo.Rows[i].Cells[0].Value.ToString().ToLower() == "true")
                    {
                        count++;
                        index = i;
                        if (count > 1)
                        {
                            break;
                        }
                    }
                }
                if (count > 1)
                {
                    MessageBox.Show("Veuillez Selectionnez Une Seule Ligne", "Error Plusieur Ligne", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                if (index == -1)
                {
                    MessageBox.Show("Veuillez Selectionnez Une Ligne", "Error Aucun Ligne", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                else
                {
                    int test = 0;
                    string NomProduit = datainfo.Rows[index].Cells[2].Value.ToString();
                    ADO.cmd = new SqlCommand("SupprimerProduit", ADO.cnx);
                    ADO.cmd.CommandType = CommandType.StoredProcedure;
                    ADO.cmd.Parameters.AddWithValue("@lastnom", NomProduit);
                    SqlDataReader rd = ADO.cmd.ExecuteReader();
                    while(rd.Read())
                    {
                        test =int.Parse(rd[0].ToString());
                    }
                    rd.Close();
                    if(test==-1)
                    {
                        MessageBox.Show("Desole Ce Produit Nexeste Pas Dans LA liste Des Produit");
                        return;
                    }
                    else if(test==-2)
                    {
                        MessageBox.Show("Desole Ce Produit Exeste Deja Dana Une Commande Veuillez Dabord Supprimer Les Commande Puis Supprimer Le Produit");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Le Produit Bien Supprimer");
                        datainfo.Rows.Clear();
                        ADO.cmd = new SqlCommand("AfficherTousProduit", ADO.cnx);
                        ADO.cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataReader rd2 = ADO.cmd.ExecuteReader();
                        List<string[]> liste = new List<string[]>();
                        while (rd2.Read())
                        {

                            string cat = rd2[0].ToString();
                            string nom = rd2[1].ToString();
                            string quant = rd2[2].ToString();
                            string prix = rd2[3].ToString();
                            string[] tab = { cat, nom, quant, prix };
                            liste.Add(tab);

                        }
                        rd2.Close();

                        for (int i = 0; i < liste.Count; i++)
                        {
                            ADO.cmd = new SqlCommand("Select dbo.AfficherNomCategorie(" + int.Parse(liste[i][0]) + ")", ADO.cnx);
                            var NomCat = ADO.cmd.ExecuteScalar();
                            datainfo.Rows.Add(false, NomCat.ToString(), liste[i][1], liste[i][2], liste[i][3]);
                        }
                    }
                }

            }
        }

        private void btnAfficherPhoto_Click(object sender, EventArgs e)
        {
            int count = 0, index = -1;
            if (datainfo.Rows.Count <= 0)
            {
                MessageBox.Show("Aucun Produit Pour Le Modifier Vueillez Ajouter Des Produits", "Error Modifier Produit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                for (int i = 0; i < datainfo.Rows.Count; i++)
                {
                    if (datainfo.Rows[i].Cells[0].Value.ToString().ToLower() == "true")
                    {
                        count++;
                        index = i;
                        if (count > 1)
                        {
                            break;
                        }
                    }
                }
                if (count > 1)
                {
                    MessageBox.Show("Veuillez Selectionnez Une Seule Ligne", "Error Plusieur Ligne", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                if (index == -1)
                {
                    MessageBox.Show("Veuillez Selectionnez Une Ligne", "Error Aucun Ligne", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                else
                {
                    byte[] ImageProduit = null;
                    string NomProduit = datainfo.Rows[index].Cells[2].Value.ToString();
                    ADO.cmd = new SqlCommand("AfficherImageProduit", ADO.cnx);
                    ADO.cmd.CommandType = CommandType.StoredProcedure;
                    ADO.cmd.Parameters.AddWithValue("@nomProduit", NomProduit);
                    SqlDataReader rd = ADO.cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        ImageProduit = (byte[])(rd[0]);
                    }
                    rd.Close();
                    PhotoProduit form = new PhotoProduit(ImageProduit);
                    form.ShowDialog();
                }

            }
        }

        private void txtRecherche_Enter(object sender, EventArgs e)
        {
           if(txtRecherche.Text== "Nom De Produit")
            {
                txtRecherche.Text = "";
            }
        }

        private void txtRecherche_Leave(object sender, EventArgs e)
        {
            if (txtRecherche.Text == "")
            {
                txtRecherche.Text = "Nom De Produit";
            }
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {

            string NomRech = "";
            if(txtRecherche.Text!= "Nom De Produit")
            {
                NomRech = txtRecherche.Text;
            }
           
                datainfo.Rows.Clear();
                ADO.cmd = new SqlCommand("RechercheProduit", ADO.cnx);
                ADO.cmd.CommandType = CommandType.StoredProcedure;
                ADO.cmd.Parameters.AddWithValue("@lastnom",NomRech);
                SqlDataReader rd = ADO.cmd.ExecuteReader();
                List<string[]> liste = new List<string[]>();
                while (rd.Read())
                {

                    string cat = rd[0].ToString();
                    string nom = rd[1].ToString();
                    string quant = rd[2].ToString();
                    string prix = rd[3].ToString();
                    string[] tab = { cat, nom, quant, prix };
                    liste.Add(tab);

                }
                rd.Close();

                for (int i = 0; i < liste.Count; i++)
                {
                    ADO.cmd = new SqlCommand("Select dbo.AfficherNomCategorie(" + int.Parse(liste[i][0]) + ")", ADO.cnx);
                    var NomCat = ADO.cmd.ExecuteScalar();
                    datainfo.Rows.Add(false, NomCat.ToString(), liste[i][1], liste[i][2], liste[i][3]);
                }
            
        }

        private void cmbCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbCategorie.Text=="Tous")
            {
                datainfo.Rows.Clear();
                ADO.cmd = new SqlCommand("AfficherTousProduit", ADO.cnx);
                ADO.cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader rd = ADO.cmd.ExecuteReader();
                List<string[]> liste = new List<string[]>();
                while (rd.Read())
                {

                    string cat = rd[0].ToString();
                    string nom = rd[1].ToString();
                    string quant = rd[2].ToString();
                    string prix = rd[3].ToString();
                    string[] tab = { cat, nom, quant, prix };
                    liste.Add(tab);

                }
                rd.Close();

                for (int i = 0; i < liste.Count; i++)
                {
                    ADO.cmd = new SqlCommand("Select dbo.AfficherNomCategorie(" + int.Parse(liste[i][0]) + ")", ADO.cnx);
                    var NomCat = ADO.cmd.ExecuteScalar();
                    datainfo.Rows.Add(false, NomCat.ToString(), liste[i][1], liste[i][2], liste[i][3]);
                }
            }
            else
            {
                int idCategorie = 0;
                ADO.cmd = new SqlCommand("AfficherId", ADO.cnx);
                ADO.cmd.CommandType = CommandType.StoredProcedure;
                ADO.cmd.Parameters.AddWithValue("@nomCategorie", cmbCategorie.Text);
                SqlDataReader rd = ADO.cmd.ExecuteReader();
                while (rd.Read())
                {
                    idCategorie = int.Parse(rd[0].ToString());
                }
                rd.Close();
                ADO.cmd = new SqlCommand("AfficherProduitParCategorie", ADO.cnx);
                ADO.cmd.CommandType = CommandType.StoredProcedure;
                ADO.cmd.Parameters.AddWithValue("@id", idCategorie);
                SqlDataReader rddata = ADO.cmd.ExecuteReader();
                datainfo.Rows.Clear();
                while (rddata.Read())
                {
                    datainfo.Rows.Add(false, cmbCategorie.Text, rddata[0].ToString(), rddata[1].ToString(), rddata[2].ToString());
                }
                rddata.Close();
            }
            

        }



        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            string NomRech = "";
            if (txtRecherche.Text != "Nom De Produit")
            {
                NomRech = txtRecherche.Text;
            }
            string NomCategore;
            if (cmbCategorie.Text == "Tous" || cmbCategorie.Text== "Categorie:")
            {
                NomCategore = "";
            }
            else
            {
                NomCategore = cmbCategorie.Text;
            }
            datainfo.Rows.Clear();
            ADO.cmd = new SqlCommand("RechercheProduit", ADO.cnx);
            ADO.cmd.CommandType = CommandType.StoredProcedure;
            ADO.cmd.Parameters.AddWithValue("@lastnom", NomRech);
            ADO.cmd.Parameters.AddWithValue("@nomCat", NomCategore);
            SqlDataReader rd = ADO.cmd.ExecuteReader();
            List<string[]> liste = new List<string[]>();
            while (rd.Read())
            {

                string cat = rd[0].ToString();
                string nom = rd[1].ToString();
                string quant = rd[2].ToString();
                string prix = rd[3].ToString();
                string[] tab = { cat, nom, quant, prix };
                liste.Add(tab);

            }
            rd.Close();

            for (int i = 0; i < liste.Count; i++)
            {
                ADO.cmd = new SqlCommand("Select dbo.AfficherNomCategorie(" + int.Parse(liste[i][0]) + ")", ADO.cnx);
                var NomCat = ADO.cmd.ExecuteScalar();
                datainfo.Rows.Add(false, NomCat.ToString(), liste[i][1], liste[i][2], liste[i][3]);
            }
        }


        private void datainfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (Convert.ToBoolean(datainfo.Rows[e.RowIndex].Cells[0].Value) == false)
                {
                    foreach (DataGridViewRow row in datainfo.Rows)
                    {
                        row.Cells[0].Value = false;
                    }
                    datainfo.Rows[datainfo.CurrentRow.Index].Cells[0].Value = true;
                }
                    
                else
                    datainfo.Rows[datainfo.CurrentRow.Index].Cells[0].Value = false;
            }
        }
    }
}
