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
    public partial class FrmDetailsCommande : Form
    {
        private string date;
        private string cin;
        private string totalht;
        private int tva;
        private string totalttc;
        public FrmDetailsCommande(string date,string cin,string totalht,int tva,string totalttc)
        {
            InitializeComponent();
            this.date = date;
            this.cin = cin;
            this.totalht = totalht;
            this.tva = tva;
            this.totalttc = totalttc;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDetailsCommande_Load(object sender, EventArgs e)
        {
            //Remplser LeS Labels
            ADO.cmd = new SqlCommand("lblDetailsCommande", ADO.cnx);
            ADO.cmd.CommandType = CommandType.StoredProcedure;
            ADO.cmd.Parameters.AddWithValue("@cin", this.cin);
            SqlDataReader rd2 = ADO.cmd.ExecuteReader();
            while(rd2.Read())
            {
                lblNomClient.Text = rd2[0].ToString();
                lblDernierDate.Text =DateTime.Parse(rd2[1].ToString()).ToShortDateString();
                lblNombreCommande.Text = rd2[2].ToString();
                lblTotalCommandes.Text = rd2[3].ToString()+"  DH";
            }
            rd2.Close();
            ADO.cmd = new SqlCommand("AfficherDetails", ADO.cnx);
            ADO.cmd.CommandType = CommandType.StoredProcedure;
            ADO.cmd.Parameters.AddWithValue("@date", this.date);
            ADO.cmd.Parameters.AddWithValue("@client", this.cin);
            ADO.cmd.Parameters.AddWithValue("@totalht", this.totalht);
            ADO.cmd.Parameters.AddWithValue("@tva", this.tva);
            ADO.cmd.Parameters.AddWithValue("@totalttc", this.totalttc);
            SqlDataReader rd = ADO.cmd.ExecuteReader();
            while(rd.Read())
            {
                datalisteClient.Rows.Add(rd[0], rd[1], rd[2], rd[3], rd[4]);
            }
            rd.Close();
        }

     
    }
}
