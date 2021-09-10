using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace KbalaGS
{
    public partial class FrmModifierProduit : Form
    {
        private string NomProduit;
        private int Quantite;
        private string Prix;
        private string nomCategorie;
        private byte[] imageProduit;
        private DataGridView datainfo;
        public FrmModifierProduit(string nomcat,string nomproduit,int quantite,string prix, byte[] imageproduit, DataGridView datainfo)
        {
            InitializeComponent();
            this.NomProduit = nomproduit;
            this.Quantite = quantite;
            this.Prix = prix;
            this.nomCategorie = nomcat;
            this.imageProduit = imageproduit;
            this.datainfo = datainfo;
        }

        private void FrmModifierProduit_Load(object sender, EventArgs e)
        {
            ADO.cmd = new SqlCommand("AfficherCetgorie", ADO.cnx);
            ADO.cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader rdcat = ADO.cmd.ExecuteReader();
            while (rdcat.Read())
            {
                cmbCategorie.Items.Add(rdcat[0]);
            }
            rdcat.Close();
            cmbCategorie.Text = this.nomCategorie;
            txtNom.Text = this.NomProduit;
            txtQuantité.Text = this.Quantite.ToString();
            txtPrix.Text = this.Prix;
            MemoryStream ms = new MemoryStream(this.imageProduit);
            pictureProduct.Image = new Bitmap(ms);


            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnModifier_Click(object sender, EventArgs e)
        {
            if(txtNom.Text=="")
            {
                MessageBox.Show("Vueillez Saisie Le Nom De Produit", "Error Nom", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (txtQuantité.Text == "")
            {
                MessageBox.Show("Vueillez Saisie La Quantite De Produit", "Error Quantite", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (txtPrix.Text == "")
            {
                MessageBox.Show("Vueillez Saisie Le Prix De Produit", "Error Prix", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
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
            int status;
            Image ProductPic = pictureProduct.Image;
            ImageConverter convert = new ImageConverter();
            byte[] imageproduct = (byte[])convert.ConvertTo(ProductPic, typeof(byte[]));
            ADO.cmd = new SqlCommand("ModifierProduit", ADO.cnx);
            ADO.cmd.CommandType = CommandType.StoredProcedure;
            ADO.cmd.Parameters.AddWithValue("@lastnom", this.NomProduit);
            ADO.cmd.Parameters.AddWithValue("@nom", txtNom.Text);
            ADO.cmd.Parameters.AddWithValue("@prix", txtPrix.Text);
            ADO.cmd.Parameters.AddWithValue("@quantite",int.Parse(txtQuantité.Text));
            ADO.cmd.Parameters.AddWithValue("@idcategorie", idCategorie);
            ADO.cmd.Parameters.AddWithValue("@image", imageproduct);
            ADO.cmd.Parameters.Add("@status", SqlDbType.Int).Direction = ParameterDirection.Output;
            ADO.cmd.ExecuteNonQuery();
            status = Convert.ToInt32(ADO.cmd.Parameters["@status"].Value);
            if(status==1)
            {
                MessageBox.Show("Le Produit Bien Modifier !", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ADO.cmd = new SqlCommand("AfficherTousProduit", ADO.cnx);
                ADO.cmd.CommandType = CommandType.StoredProcedure;
                this.datainfo.Rows.Clear();
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
                this.Close();
            }
           







        }

        private void btnParcourire_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                pictureProduct.Image = Image.FromFile(file.FileName);
            }
        }
    }
}
