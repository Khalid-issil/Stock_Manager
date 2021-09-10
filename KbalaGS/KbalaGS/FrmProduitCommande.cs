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
    public partial class FrmProduitCommande : Form
    {
        private string NomProduit;
        private DataGridView datadet;
        private DataGridView dataproduit;
        private string QuantiteProduit;
        private string PrixProduit;
        public FrmProduitCommande(string nomProduit,string QuantiteStock,string Prix,DataGridView datadetailles,DataGridView dataproduit)
        {
            InitializeComponent();
            this.NomProduit = nomProduit;
            this.datadet = datadetailles;
            this.dataproduit = dataproduit;
            this.QuantiteProduit = QuantiteStock;
            this.PrixProduit = Prix;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Form Load
        private void FrmProduitCommande_Load(object sender, EventArgs e)
        {
            lblNom.Text = this.NomProduit;
            lblPrix.Text = this.PrixProduit;
            lblStock.Text = this.QuantiteProduit;      
        }


        //Methode Calcule Remise
        private double CalculeTotale(double prix,int Qunatite,int Remise)
        {
            double totale;
            totale =prix * Qunatite;
            totale -= totale * Remise / 100;
            return totale;

        }
        private void txtQuantite_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtRemise_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtQuantite_TextChanged(object sender, EventArgs e)
        {
            if(txtQuantite.Text!="")
            {
                txtTotal.Text=CalculeTotale(double.Parse(lblPrix.Text), int.Parse(txtQuantite.Text), int.Parse(txtRemise.Text)).ToString();
            }
        }



        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if(int.Parse(txtQuantite.Text)>int.Parse(lblStock.Text))
            {
                MessageBox.Show("Desole La Quantite Saisie Est Plus Grand Que La Quantite de stock \n Veuillez Saisie Une Quantite Disponible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if(txtTotal.Text=="0")
            {
                MessageBox.Show("Veuillez Saisie La Quantite De Produit Et Le Remise Pour Ajouter Ce Produit Dans La Commande", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                datadet.Rows.Add(lblNom.Text, txtQuantite.Text, lblPrix.Text, txtRemise.Text, txtTotal.Text);
                for(int i=0;i<this.dataproduit.Rows.Count;i++)
                {
                    if(dataproduit.Rows[i].Cells[1].Value.ToString().CompareTo(this.NomProduit)==0)
                    {
                        int lastQuantite =int.Parse(dataproduit.Rows[i].Cells[2].Value.ToString());
                        int newQuantite = lastQuantite - int.Parse(txtQuantite.Text);
                        dataproduit.Rows[i].Cells[2].Value = newQuantite.ToString();
                    }
                }
                foreach(DataGridViewRow r in this.dataproduit.Rows)
                {
                    r.Cells[0].Value = false;
                }
                ValideQuantite();
                this.Close();
            }

        }
        //Methode Valide Quantite
        private void ValideQuantite()
        {
            for (int i = 0; i < this.dataproduit.Rows.Count; i++)
            {
                if (this.dataproduit.Rows[i].Cells[2].Value.ToString() == "0")
                {
                    this.dataproduit.Rows[i].Cells[2].Style.BackColor = Color.Red;
                    this.dataproduit.Rows[i].Cells[2].Style.ForeColor = Color.WhiteSmoke;
                }
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtQuantite_Enter(object sender, EventArgs e)
        {
            if(txtQuantite.Text=="0")
            {
                txtQuantite.Text = "";
            }
        }

        private void txtQuantite_Leave(object sender, EventArgs e)
        {
            if(txtQuantite.Text=="")
            {
                txtQuantite.Text = "0";
            }
        }

        private void txtRemise_TextChanged_1(object sender, EventArgs e)
        {
            if (txtRemise.Text != "")
            {
              txtTotal.Text=CalculeTotale(double.Parse(lblPrix.Text), int.Parse(txtQuantite.Text), int.Parse(txtRemise.Text)).ToString();
            }
        }

        private void txtRemise_Enter_1(object sender, EventArgs e)
        {
            if (txtRemise.Text == "0")
            {
                txtRemise.Text = "";
            }
        }

        private void txtRemise_Leave_1(object sender, EventArgs e)
        {
            if (txtRemise.Text == "")
            {
                txtRemise.Text = "0";
            }
        }
    }
}
