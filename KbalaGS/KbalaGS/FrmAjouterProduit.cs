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
    public partial class FrmAjouterProduit : Form
    {
        DataGridView datainfo;
        public FrmAjouterProduit(DataGridView datainfo)
        {
            InitializeComponent();
            this.datainfo = datainfo;
        }
        public static int NumeroProduit=0;
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void FrmAjouterProduit_Load(object sender, EventArgs e)
        {
            ADO.cmd = new SqlCommand("AfficherCetgorie", ADO.cnx);
            ADO.cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader rd = ADO.cmd.ExecuteReader();
            while (rd.Read())
            {
                cmbCategorie.Items.Add(rd[0]);
            }
            rd.Close();
            if(cmbCategorie.Items.Count>0)
                cmbCategorie.SelectedIndex = 0;
        }

        private void txtNom_Enter(object sender, EventArgs e)
        {
            Enter(txtNom, "Nom Produit");
        }

        private void txtNom_Leave(object sender, EventArgs e)
        {
            Leave(txtNom, "Nom Produit");
        }

        private void txtQuantité_Leave(object sender, EventArgs e)
        {
            Leave(txtQuantité, "Quantité");
        }

        private void txtQuantité_Enter(object sender, EventArgs e)
        {
            Enter(txtQuantité, "Quantité");
        }

        private void txtPrix_Leave(object sender, EventArgs e)
        {
            Leave(txtPrix, "Prix");
        }

        private void txtPrix_Enter(object sender, EventArgs e)
        {
            Enter(txtPrix, "Prix");
        }

        private void txtQuantité_KeyPress(object sender, KeyPressEventArgs e)
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
        Image ProduitImage;
        private void btnParcourire_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if(file.ShowDialog()==DialogResult.OK)
            {
                pictureProduct.Image = Image.FromFile(file.FileName);
                ProduitImage = Image.FromFile(file.FileName);
            }
            choosePhoto = 1;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbCategorie.SelectedIndex = 0;
            txtQuantité.Text = "Quantité";
            txtPrix.Text = "Prix";
            txtNom.Text = "Nom Produit";
            pictureProduct.Image = null;

        }



        private void btnadd_Click(object sender, EventArgs e)
        {
            if(txtNom.Text== "Nom Produit")
            {
                MessageBox.Show("Veuillez Saisie Le Nom De Produit", "Nom Produit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtQuantité.Text == "Quantité")
            {
                MessageBox.Show("Veuillez Saisie La Qunatité De Produit", "Quantite Produit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtPrix.Text == "Prix")
            {
                MessageBox.Show("Veuillez Saisie Le Prix De Produit", "Prix Produit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(choosePhoto==0)
            {
                MessageBox.Show("Veuillez Choisie Une Photo Pour De Produit", "Photo Produit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int idCategorie = 0;
            ADO.cmd = new SqlCommand("AfficherId", ADO.cnx);
            ADO.cmd.CommandType = CommandType.StoredProcedure;
            ADO.cmd.Parameters.AddWithValue("@nomCategorie", cmbCategorie.Text);
            SqlDataReader rd = ADO.cmd.ExecuteReader();
            while(rd.Read())
            {
                idCategorie =int.Parse(rd[0].ToString());
            }
            rd.Close();
            int test;
            ImageConverter convert = new ImageConverter();
            byte[] imageproduct = (byte[])convert.ConvertTo(ProduitImage, typeof(byte[]));
            ADO.cmd = new SqlCommand("AjouterProduit", ADO.cnx);
            ADO.cmd.CommandType = CommandType.StoredProcedure;
            ADO.cmd.Parameters.AddWithValue("@nom", txtNom.Text);
            ADO.cmd.Parameters.AddWithValue("@Quantite", int.Parse(txtQuantité.Text));
            ADO.cmd.Parameters.AddWithValue("@prix", txtPrix.Text);
            ADO.cmd.Parameters.AddWithValue("@image", imageproduct);
            ADO.cmd.Parameters.AddWithValue("@idcategorie", idCategorie);
            ADO.cmd.Parameters.Add("@status", SqlDbType.Int).Direction = ParameterDirection.Output;
            ADO.cmd.ExecuteNonQuery();
            test = Convert.ToInt32(ADO.cmd.Parameters["@status"].Value);
            if (test == -1)
            {
                MessageBox.Show("Ce Produit Exeste Deja Veuillez Ajouter Une Nouveau Produit", "Produit Exist Deja", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (test == 1)
            {
                MessageBox.Show("Le Produit Bien Ajouter", "Produit Bien Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                choosePhoto = 0;
                btnClear_Click(sender, e);
                this.datainfo.Rows.Clear();
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
        int choosePhoto = 0;
        private void txtPrix_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
