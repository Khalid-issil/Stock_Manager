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
    public partial class Frm_Ajouter_Commande : Form
    {
        private DataGridView datasup;
        public Frm_Ajouter_Commande(DataGridView dataSup)
        {
            InitializeComponent();
            this.datasup = dataSup;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Methode Valide Quantite
        private void ValideQuantite()
        {
            for(int i=0;i<dataProduit.Rows.Count;i++)
            {
                if(dataProduit.Rows[i].Cells[2].Value.ToString()=="0")
                {
                    dataProduit.Rows[i].Cells[2].Style.BackColor = Color.Red;
                    dataProduit.Rows[i].Cells[2].Style.ForeColor = Color.WhiteSmoke;
                }
                else
                {
                    dataProduit.Rows[i].Cells[2].Style.BackColor = Color.White;
                    dataProduit.Rows[i].Cells[2].Style.ForeColor = Color.Black;
                }
            }
        }
        private void Frm_Ajouter_Commande_Load(object sender, EventArgs e)
        {
            ADO.cmd=new  SqlCommand("select Nom_Produit,Quantite_Produit,Prix_Produit from Produit",ADO.cnx);
            SqlDataReader rd = ADO.cmd.ExecuteReader();
            while(rd.Read())
            {
                dataProduit.Rows.Add(false, rd[0].ToString(), rd[1].ToString(), rd[2].ToString());
            }
            rd.Close();
            ValideQuantite();
        }

        private void txtRecherche_Leave(object sender, EventArgs e)
        {
            if (txtRecherche.Text == "")
            {
                txtRecherche.Text = "Nom De Produit";
            }
        }

        private void txtRecherche_Enter(object sender, EventArgs e)
        {
            if (txtRecherche.Text == "Nom De Produit")
            {
                txtRecherche.Text = "";
            }
        }


        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            dataProduit.Rows.Clear();
            string prod;
            if(txtRecherche.Text== "Nom De Produit")
            {
                prod = "";
            }
            else
            {
                prod = txtRecherche.Text;
            }
            ADO.cmd = new SqlCommand("select Nom_Produit,Quantite_Produit,Prix_Produit from Produit where Nom_Produit like '%"+prod+"%'", ADO.cnx);
            SqlDataReader rd = ADO.cmd.ExecuteReader();
            while (rd.Read())
            {
                dataProduit.Rows.Add(false, rd[0].ToString(), rd[1].ToString(), rd[2].ToString());
            }
            rd.Close();
            ValideQuantite();
        }

        
        private void dataProduit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex!=-1)
            {
                if (dataProduit.Rows[e.RowIndex].Cells[0].Value.ToString().ToLower().CompareTo("true") == 0)
                    dataProduit.Rows[e.RowIndex].Cells[0].Value = false;
                else
                {
                    for (int i = 0; i < dataProduit.Rows.Count; i++)
                    {
                        if (dataProduit.Rows[i].Cells[0].Value.ToString().ToLower().CompareTo("true") == 0)
                        {
                            dataProduit.Rows[i].Cells[0].Value = false;
                        }
                    }
                    if (dataProduit.Rows[e.RowIndex].Cells[2].Value.ToString() == "0")
                    {
                        MessageBox.Show("Desole Ce Produit Est Terminer Dans Le Stock", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataProduit.Rows[e.RowIndex].Cells[0].Value = false;
                    }
                    else
                    {
                        string NomProduit = dataProduit.Rows[e.RowIndex].Cells[1].Value.ToString();
                        bool trouve = false;
                        for(int i=0;i<datadetail.Rows.Count;i++)
                        {
                            if(datadetail.Rows[i].Cells[0].Value.ToString().CompareTo(NomProduit)==0)
                            {
                                MessageBox.Show("Desole Ce Produit Exist Deja Dans La Commande !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                trouve = true;
                            }
                        }
                        if(trouve==false)
                        {
                            dataProduit.Rows[e.RowIndex].Cells[0].Value = true;
                            FrmProduitCommande form = new FrmProduitCommande(dataProduit.Rows[e.RowIndex].Cells[1].Value.ToString(), dataProduit.Rows[e.RowIndex].Cells[2].Value.ToString(), dataProduit.Rows[e.RowIndex].Cells[3].Value.ToString(), datadetail, dataProduit);
                            form.ShowDialog();
                        }
                       

                    }
                }
            }


        }

        private void btnSelectClient_Click(object sender, EventArgs e)
        {
            List_Client_Commande form = new List_Client_Commande(txtNom,txtPrenom,txtTel,txtcin,txtPays,txtVille);
            form.ShowDialog();
        }


        //Methode De Mise Ajoure Le Stock Dans La Base De Donnée
        private void MiseAjour()
        {
            for(int i=0;i<datadetail.Rows.Count;i++)
            {
                string NomProduit = datadetail.Rows[i].Cells[0].Value.ToString();
                int Quantite = int.Parse(datadetail.Rows[i].Cells[1].Value.ToString());
                ADO.cmd = new SqlCommand("MiseAjoureDestock", ADO.cnx);
                ADO.cmd.CommandType = CommandType.StoredProcedure;
                ADO.cmd.Parameters.AddWithValue("@nomProduit", NomProduit);
                ADO.cmd.Parameters.AddWithValue("@Quantite", Quantite);
                ADO.cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Le Stock Bien Mise Ajourer");
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if(txtcin.Text=="")
            {
                MessageBox.Show("Vuillez Dabord Selectionner Le Client de la Commande !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(txtTotalTTC.Text=="0")
            {
                MessageBox.Show("Vuillez Dabord Selectionner Les Produits De La Commande", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dtpdebut.Value.Year==DateTime.Now.Year && dtpdebut.Value.Month==DateTime.Now.Month && dtpdebut.Value.Day==DateTime.Now.Day)
            {
                if (MessageBox.Show("Voulez Vous Ajouter Cette Commande ?", "Quantion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int status = -1;
                    ADO.cmd = new SqlCommand("AjouteCommande", ADO.cnx);
                    ADO.cmd.CommandType = CommandType.StoredProcedure;
                    ADO.cmd.Parameters.AddWithValue("@cin", txtcin.Text);
                    ADO.cmd.Parameters.AddWithValue("@date", dtpdebut.Value);
                    ADO.cmd.Parameters.AddWithValue("@totalht", txtTotaleHT.Text);
                    ADO.cmd.Parameters.AddWithValue("@tva", txttva.Text);
                    ADO.cmd.Parameters.AddWithValue("@totalttc", txtTotalTTC.Text);
                    ADO.cmd.Parameters.Add("@status", SqlDbType.Int).Direction = ParameterDirection.Output;
                    ADO.cmd.ExecuteNonQuery();
                    status = int.Parse(ADO.cmd.Parameters["@status"].Value.ToString());
                    if (status == 1)
                    {
                        MessageBox.Show("La Commande Bien Ajouter Dan La Table Commande");
                        int dernierCommande = -1;
                        ADO.cmd = new SqlCommand("select dbo.DernierCommande()", ADO.cnx);
                        dernierCommande = Convert.ToInt32(ADO.cmd.ExecuteScalar());
                        if (dernierCommande != -1)
                        {
                            for (int j = 0; j < datadetail.Rows.Count; j++)
                            {
                                string NomP = datadetail.Rows[j].Cells[0].Value.ToString();
                                int QTE = int.Parse(datadetail.Rows[j].Cells[1].Value.ToString());
                                string PrixP = datadetail.Rows[j].Cells[2].Value.ToString();
                                int remiseP = int.Parse(datadetail.Rows[j].Cells[3].Value.ToString());
                                string TotalP = datadetail.Rows[j].Cells[4].Value.ToString();
                                ADO.cmd = new SqlCommand("AjouterDetailsCommande", ADO.cnx);
                                ADO.cmd.CommandType = CommandType.StoredProcedure;
                                ADO.cmd.Parameters.AddWithValue("@idcmd", dernierCommande);
                                ADO.cmd.Parameters.AddWithValue("@produit", NomP);
                                ADO.cmd.Parameters.AddWithValue("@quantite", QTE);
                                ADO.cmd.Parameters.AddWithValue("@prix", PrixP);
                                ADO.cmd.Parameters.AddWithValue("@remise", remiseP);
                                ADO.cmd.Parameters.AddWithValue("@totale", TotalP);
                                ADO.cmd.ExecuteNonQuery();
                            }
                            MessageBox.Show("Le Detials Bien Ajouter");
                            MiseAjour();
                            MessageBox.Show("La Commande Bien Ajouter");
                            btnClose_Click(sender, e);
                            ADO.cmd = new SqlCommand("select C.Date_Commande,CL.CIN_Client,Total_Ht,Tva,Total_Ttc from Commande C,Client CL where C.Id_Client = CL.Id_Client", ADO.cnx);
                            SqlDataReader rd = ADO.cmd.ExecuteReader();
                            datasup.Rows.Clear();
                            while (rd.Read())
                            {
                                datasup.Rows.Add(false, DateTime.Parse(rd[0].ToString()).ToShortDateString(), rd[1].ToString(), rd[2].ToString(), rd[3].ToString(), rd[4].ToString());
                            }
                            rd.Close();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Le Commande est Refuse");
                    }
                }
                
            }
            else
            {
                MessageBox.Show("La Date De Commande Doit Etre Egale La Date D'aujourd'hui", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
           
        }


       
        private void txtNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(datadetail.Rows.Count>0)
            {
                if (MessageBox.Show("Voulez Vous Modifier Ce Produit Dans La Commande ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    string NomProduit = "";
                    string QuantiteStock = "";
                    string QuantiteProduit = "";
                    string PrixProduit = "";
                    string Remise = "";
                    string Totale = "";
                    int indexRow = datadetail.CurrentRow.Index;
                    NomProduit = datadetail.Rows[indexRow].Cells[0].Value.ToString();
                    QuantiteProduit = datadetail.Rows[indexRow].Cells[1].Value.ToString();
                    Remise = datadetail.Rows[indexRow].Cells[3].Value.ToString();
                    Totale = datadetail.Rows[indexRow].Cells[4].Value.ToString();
                    for (int i = 0; i < dataProduit.Rows.Count; i++)
                    {
                        if (dataProduit.Rows[i].Cells[1].Value.ToString().ToLower().CompareTo(NomProduit.ToLower()) == 0)
                        {
                            QuantiteStock = dataProduit.Rows[i].Cells[2].Value.ToString();
                            PrixProduit = dataProduit.Rows[i].Cells[3].Value.ToString();
                        }
                    }
                    FrmModifierProduitCommande form = new FrmModifierProduitCommande(NomProduit, QuantiteStock, PrixProduit, datadetail, dataProduit, QuantiteProduit, Remise, Totale,txtTotaleHT);
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("La Modification Est Annule !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(datadetail.Rows.Count>0)
            {
                if(MessageBox.Show("Voulez Vous Supprimer Ce Produit Dans La Commande ?","Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
                {
                    string QuantiteProduit = "";
                    int indexRow = datadetail.CurrentRow.Index;
                    QuantiteProduit = datadetail.Rows[indexRow].Cells[1].Value.ToString();
                    string NomProduit = "";
                    NomProduit = datadetail.Rows[indexRow].Cells[0].Value.ToString();
                    datadetail.Rows.RemoveAt(indexRow);
                    for (int i = 0; i < dataProduit.Rows.Count; i++)
                    {
                        if (dataProduit.Rows[i].Cells[1].Value.ToString().ToLower().CompareTo(NomProduit.ToLower()) == 0)
                        {
                            double lastQuantite = double.Parse(dataProduit.Rows[i].Cells[2].Value.ToString());
                            double TotalQuantite = lastQuantite + double.Parse(QuantiteProduit);
                            dataProduit.Rows[i].Cells[2].Value = TotalQuantite.ToString();
                        }
                    }
                    double totaldet = 0;
                    for (int i = 0; i < datadetail.Rows.Count; i++)
                    {
                        totaldet += double.Parse(datadetail.Rows[i].Cells[4].Value.ToString());
                    }
                    txtTotaleHT.Text = totaldet.ToString();
                    ValideQuantite();
                }
                else
                {
                    MessageBox.Show("La Supprission Est Annule !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private void txttva_TextChanged(object sender, EventArgs e)
        {
            if (txttva.Text != "")
            {
                double totalht = double.Parse(txtTotaleHT.Text);
                double tva = double.Parse(txttva.Text);
                txtTotalTTC.Text = (totalht + (totalht * tva) / 100).ToString();
            }
        }

        private void txtTotaleHT_TextChanged(object sender, EventArgs e)
        {
            if(txtTotaleHT.Text!="")
            {
                double totalht = double.Parse(txtTotaleHT.Text);
                double tva = double.Parse(txttva.Text);
                txtTotalTTC.Text = (totalht + (totalht * tva) / 100).ToString();
            }
        }

        private void txttva_Leave(object sender, EventArgs e)
        {
            if(txttva.Text=="")
            {
                txttva.Text = "0";
            }
        }

        private void txttva_Enter(object sender, EventArgs e)
        {
            if(txttva.Text=="0")
            {
                txttva.Text = "";
            }
        }

        private void txttva_KeyPress(object sender, KeyPressEventArgs e)
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

        private void datadetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void datadetail_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            double totaldet=0;
            for(int i=0;i<datadetail.Rows.Count;i++)
            {
                totaldet +=double.Parse(datadetail.Rows[i].Cells[4].Value.ToString());
            }
            txtTotaleHT.Text = totaldet.ToString();

        }
    }
}
