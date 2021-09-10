using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KbalaGS
{
    public partial class FrmModifierProduitCommande : Form
    {
        private string NomProduit;
        private DataGridView datadet;
        private DataGridView dataproduit;
        private string QuantiteProduit;
        private string PrixProduit;
        private string QuantiteCmd;
        private string Remise;
        private string Totale;
        private double QuantiteTotale;
        private TextBox totalht;

        public FrmModifierProduitCommande(string nomProduit, string QuantiteStock, string Prix, DataGridView datadetailles, DataGridView dataproduit,string QuantiteCmd,string Remise,string Totale,TextBox txtTotalHt)
        {
            InitializeComponent();
            this.NomProduit = nomProduit;
            this.datadet = datadetailles;
            this.dataproduit = dataproduit;
            this.QuantiteProduit = QuantiteStock;
            this.PrixProduit = Prix;
            this.QuantiteCmd = QuantiteCmd;
            this.Remise = Remise;
            this.Totale = Totale;
            this.totalht = txtTotalHt;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Methode Calcule Remise
        private double CalculeTotale(double prix, int Qunatite, int Remise)
        {
            double totale;
            totale = prix * Qunatite;
            totale -= totale * Remise / 100;
            return totale;

        }

        private void txtQuantite_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantite.Text != "")
            {
                txtTotal.Text = CalculeTotale(double.Parse(lblPrix.Text), int.Parse(txtQuantite.Text), int.Parse(txtRemise.Text)).ToString();
            }
        }

        private void txtRemise_TextChanged(object sender, EventArgs e)
        {
            if (txtRemise.Text != "")
            {
                txtTotal.Text = CalculeTotale(double.Parse(lblPrix.Text), int.Parse(txtQuantite.Text), int.Parse(txtRemise.Text)).ToString();
            }
        }

        private void txtRemise_Leave(object sender, EventArgs e)
        {
            if (txtRemise.Text == "")
            {
                txtRemise.Text = "0";
            }
        }

        private void txtRemise_Enter(object sender, EventArgs e)
        {
            if (txtRemise.Text == "0")
            {
                txtRemise.Text = "";
            }
        }

        private void txtQuantite_Enter(object sender, EventArgs e)
        {
            if (txtQuantite.Text == "0")
            {
                txtQuantite.Text = "";
            }
        }

        private void txtQuantite_Leave(object sender, EventArgs e)
        {
            if (txtQuantite.Text == "")
            {
                txtQuantite.Text = "0";
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
                else
                {
                    this.dataproduit.Rows[i].Cells[2].Style.BackColor = Color.White;
                    this.dataproduit.Rows[i].Cells[2].Style.ForeColor = Color.Black;
                }
            }
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtQuantite.Text) > int.Parse(lblStock.Text))
            {
                MessageBox.Show("Desole La Quantite Saisie Est Plus Grand Que La Quantite de stock \n Veuillez Saisie Une Quantite Disponible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (txtTotal.Text == "0")
            {
                MessageBox.Show("Veuillez Saisie La Quantite De Produit Et Le Remise Pour Ajouter Ce Produit Dans La Commande", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Mise Ajour La Table De DEtail Produit
                for(int i=0;i<datadet.Rows.Count;i++)
                {
                    if(datadet.Rows[i].Cells[0].Value.ToString().ToLower().CompareTo(NomProduit.ToLower())==0)
                    {
                        datadet.Rows[i].Cells[1].Value = txtQuantite.Text;
                        datadet.Rows[i].Cells[2].Value = PrixProduit;
                        datadet.Rows[i].Cells[3].Value = txtRemise.Text;
                        datadet.Rows[i].Cells[4].Value = txtTotal.Text;
                    }
                }
                //Mise Ajour La Table Produit
                for(int i=0;i<dataproduit.Rows.Count;i++)
                {
                    if(dataproduit.Rows[i].Cells[1].Value.ToString().ToLower().CompareTo(NomProduit.ToLower())==0)
                    {
                        dataproduit.Rows[i].Cells[2].Value = QuantiteTotale - double.Parse(txtQuantite.Text);
                    }
                }
                ValideQuantite();
                MessageBox.Show("Le Produit Bien Modifier");
                double totaldet = 0;
                for (int i = 0; i < datadet.Rows.Count; i++)
                {
                    totaldet += double.Parse(datadet.Rows[i].Cells[4].Value.ToString());
                }
                totalht.Text = totaldet.ToString();
                this.Close();
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

        private void txtQuantite_KeyPress(object sender, KeyPressEventArgs e)
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

        private void FrmModifierProduitCommande_Load(object sender, EventArgs e)
        {
            lblNom.Text = this.NomProduit;
            lblPrix.Text = this.PrixProduit;
            QuantiteTotale = double.Parse(QuantiteCmd) + double.Parse(QuantiteProduit);
            lblStock.Text = this.QuantiteTotale.ToString();
            txtQuantite.Text = this.QuantiteCmd;
            txtRemise.Text = this.Remise;
            txtTotal.Text = this.Totale;
        }
    }
}
