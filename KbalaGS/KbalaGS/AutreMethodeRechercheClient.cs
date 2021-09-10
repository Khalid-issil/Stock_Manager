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
    public partial class AutreMethodeRechercheClient : Form
    {
        DataGridView datainfo;
        public AutreMethodeRechercheClient(DataGridView datainfo)
        {
            InitializeComponent();
            this.datainfo = datainfo;
        }

        private void AutreMethodeRechercheClient_Load(object sender, EventArgs e)
        {
            ADO.cmd = new SqlCommand("AfficherTousLesClient", ADO.cnx);
            ADO.cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader rd = ADO.cmd.ExecuteReader();
            while(rd.Read())
            {
                datalisteClient.Rows.Add(false, rd[0], rd[1], rd[2], rd[3], rd[4], rd[5], rd[6], rd[7]);
            }
            rd.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AutreMethodeRechercheClient_TextChanged(object sender, EventArgs e)
        {
            datalisteClient.Rows.Clear();
            ADO.cmd = new SqlCommand("RechercheClientCmd", ADO.cnx);
            ADO.cmd.CommandType = CommandType.StoredProcedure;
            ADO.cmd.Parameters.AddWithValue("@nom", txtNomRech.Text);
            ADO.cmd.Parameters.AddWithValue("@prenom", txtprenomrech.Text);
            ADO.cmd.Parameters.AddWithValue("@cin", txtcinrech.Text);
            ADO.cmd.Parameters.AddWithValue("@tel", txttelrech.Text);
            SqlDataReader rd = ADO.cmd.ExecuteReader();
            while(rd.Read())
            {
                datalisteClient.Rows.Add(false, rd[8], rd[1], rd[2], rd[3], rd[4], rd[5], rd[6]);
            }
            rd.Close();
        }

        private void datalisteClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex!=-1)
            {
                if(bool.Parse(datalisteClient.Rows[e.RowIndex].Cells[0].Value.ToString())==true)
                {
                    datalisteClient.Rows[e.RowIndex].Cells[0].Value = false;
                }
                else
                {
                    for(int i=0;i<datalisteClient.Rows.Count;i++)
                    {
                        if (bool.Parse(datalisteClient.Rows[i].Cells[0].Value.ToString()) == true)
                        {
                            datalisteClient.Rows[i].Cells[0].Value = false;
                        }
                    }
                    datalisteClient.Rows[e.RowIndex].Cells[0].Value = true;
                    datainfo.Rows.Clear();
                    ADO.cmd = new SqlCommand("select * from Client where CIN_Client like @cin", ADO.cnx);
                    ADO.cmd.Parameters.AddWithValue("@cin", datalisteClient.Rows[e.RowIndex].Cells[1].Value.ToString());
                    SqlDataReader rd = ADO.cmd.ExecuteReader();
                    while(rd.Read())
                    {
                        datainfo.Rows.Add(false, rd[8], rd[1], rd[2], rd[3], rd[4], rd[5], rd[6], rd[7]);
                    }
                    rd.Close();
                    this.Close();
                }
            }
        }
    }
}
