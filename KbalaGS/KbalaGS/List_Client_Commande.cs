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
    public partial class List_Client_Commande : Form
    {
        private TextBox txtcinCMD;
        private TextBox txtnomCMD;
        private TextBox txtprenomCMD;
        private TextBox txttelCMD;
        private TextBox txtpaysCMD;
        private TextBox txtvilleCMD;
        public List_Client_Commande(TextBox txtNom,TextBox txtPrenom,TextBox txtTel,TextBox txtcmdcin,TextBox txtPays,TextBox txtVille)
        {
            InitializeComponent();
            txtcinCMD = txtcmdcin;
            txtnomCMD = txtNom;
            txtprenomCMD = txtPrenom;
            txtvilleCMD = txtVille;
            txtpaysCMD = txtPays;
            txttelCMD = txtTel;
        }

        private void btnQuitterlgf_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void List_Client_Commande_Load(object sender, EventArgs e)
        {
            ADO.cmd = new SqlCommand("select * from Client", ADO.cnx);
            SqlDataReader rd = ADO.cmd.ExecuteReader();
            while(rd.Read())
            {
                datalisteClient.Rows.Add(false, rd[8].ToString(), rd[1].ToString(), rd[2].ToString(), rd[3].ToString(), rd[4].ToString(), rd[5].ToString(), rd[6].ToString());
            }
            rd.Close();
        }


        //Methode de Recherche Clients
        private void Recherche()
        {
            datalisteClient.Rows.Clear();
            ADO.cmd = new SqlCommand("RechercheClientCmd", ADO.cnx);
            ADO.cmd.CommandType = CommandType.StoredProcedure;
            ADO.cmd.Parameters.AddWithValue("@nom", txtNomRech.Text);
            ADO.cmd.Parameters.AddWithValue("@prenom", txtprenomrech.Text);
            ADO.cmd.Parameters.AddWithValue("@cin", txtcinrech.Text);
            ADO.cmd.Parameters.AddWithValue("@tel", txttelrech.Text);

            SqlDataReader rd = ADO.cmd.ExecuteReader();
            while (rd.Read())
            {
                datalisteClient.Rows.Add(false, rd[8].ToString(), rd[1].ToString(), rd[2].ToString(), rd[3].ToString(), rd[4].ToString(), rd[5].ToString(), rd[6].ToString());
            }
            rd.Close();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void datalisteClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex!=-1)
            {
                if (datalisteClient.Rows[e.RowIndex].Cells[0].Value.ToString().ToLower().CompareTo("true") == 0)
                    datalisteClient.Rows[e.RowIndex].Cells[0].Value = false;
                else
                {
                    for (int i = 0; i < datalisteClient.Rows.Count; i++)
                    {
                        if (datalisteClient.Rows[i].Cells[0].Value.ToString().ToLower().CompareTo("true") == 0)
                        {
                            datalisteClient.Rows[i].Cells[0].Value = false;
                        }
                    }
                    datalisteClient.Rows[e.RowIndex].Cells[0].Value = true;
                    this.txtcinCMD.Text = datalisteClient.Rows[e.RowIndex].Cells[1].Value.ToString();
                    this.txtnomCMD.Text = datalisteClient.Rows[e.RowIndex].Cells[2].Value.ToString();
                    this.txtprenomCMD.Text = datalisteClient.Rows[e.RowIndex].Cells[3].Value.ToString();
                    this.txttelCMD.Text = datalisteClient.Rows[e.RowIndex].Cells[5].Value.ToString();
                    this.txtpaysCMD.Text = datalisteClient.Rows[e.RowIndex].Cells[6].Value.ToString();
                    this.txtvilleCMD.Text = datalisteClient.Rows[e.RowIndex].Cells[7].Value.ToString();
                    this.Close();
                }
            }
        }

        private void txtvillerech_TextChanged(object sender, EventArgs e)
        {
            Recherche();
        }
    }
}
