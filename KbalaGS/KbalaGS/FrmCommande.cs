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
    public partial class FrmCommande : Form
    {
        public FrmCommande()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCommande_Load(object sender, EventArgs e)
        {
            ADO.cmd = new SqlCommand("select C.Date_Commande,CL.CIN_Client,Total_Ht,Tva,Total_Ttc from Commande C,Client CL where C.Id_Client = CL.Id_Client", ADO.cnx);
            SqlDataReader rd = ADO.cmd.ExecuteReader();
            while(rd.Read())
            {
                datainfo.Rows.Add(false, DateTime.Parse(rd[0].ToString()).ToShortDateString(), rd[1].ToString(), rd[2].ToString(), rd[3].ToString(), rd[4].ToString());
            }
            rd.Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Frm_Ajouter_Commande form = new Frm_Ajouter_Commande(datainfo);
            form.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            datainfo.Rows.Clear();
            ADO.cmd = new SqlCommand("RechercheCommandeDeuxdate", ADO.cnx);
            ADO.cmd.CommandType = CommandType.StoredProcedure;
            ADO.cmd.Parameters.AddWithValue("@firstdate", dtpdebut.Value);
            ADO.cmd.Parameters.AddWithValue("@lastdate", dtpfin.Value);
            SqlDataReader rd = ADO.cmd.ExecuteReader();
            while (rd.Read())
            {
                datainfo.Rows.Add(false, DateTime.Parse(rd[0].ToString()).ToShortDateString(), rd[1].ToString(), rd[2].ToString(), rd[3].ToString(), rd[4].ToString());
            }
            rd.Close();
        }

        private void datainfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex!=-1)
            {
                if(bool.Parse(datainfo.Rows[e.RowIndex].Cells[0].Value.ToString())==true)
                {
                    datainfo.Rows[e.RowIndex].Cells[0].Value = false;
                }
                else
                {
                    for(int i=0;i<datainfo.Rows.Count;i++)
                    {
                        datainfo.Rows[i].Cells[0].Value = false;
                    }
                    datainfo.Rows[e.RowIndex].Cells[0].Value = true;
                }
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int RowIndex=-1;
            for(int i=0;i<datainfo.Rows.Count;i++)
            {
                if(bool.Parse(datainfo.Rows[i].Cells[0].Value.ToString())==true)
                {
                    RowIndex = i;
                    break;
                }
            }
            if(RowIndex==-1)
            {
                MessageBox.Show("Desole Vuillez Selectionner Une Commande Pour La Supprission !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            else
            {
                if (MessageBox.Show("Voulez Vous Supprimer Ce Commande ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int Year, Month, Day;
                    DateTime dateCMD = DateTime.Parse(datainfo.Rows[RowIndex].Cells[1].Value.ToString());
                    Year = dateCMD.Year;
                    Month = dateCMD.Month;
                    Day = dateCMD.Day;
                    string date =Year+"-"+Month+"-"+Day;
                    string cin = datainfo.Rows[RowIndex].Cells[2].Value.ToString();
                    string totalht = datainfo.Rows[RowIndex].Cells[3].Value.ToString();
                    int tva =int.Parse(datainfo.Rows[RowIndex].Cells[4].Value.ToString());
                    string totalttc = datainfo.Rows[RowIndex].Cells[5].Value.ToString();
                    ADO.cmd = new SqlCommand("SupprimerCommande", ADO.cnx);
                    ADO.cmd.CommandType = CommandType.StoredProcedure;
                    ADO.cmd.Parameters.AddWithValue("@date", date);
                    ADO.cmd.Parameters.AddWithValue("@client", cin);
                    ADO.cmd.Parameters.AddWithValue("@totalht", totalht);
                    ADO.cmd.Parameters.AddWithValue("@tva", tva);
                    ADO.cmd.Parameters.AddWithValue("@totalttc", totalttc);
                    ADO.cmd.ExecuteNonQuery();
                    MessageBox.Show("La Commande Bien Supprimer ");
                    datainfo.Rows.Clear();
                    ADO.cmd = new SqlCommand("select C.Date_Commande,CL.CIN_Client,Total_Ht,Tva,Total_Ttc from Commande C,Client CL where C.Id_Client = CL.Id_Client", ADO.cnx);
                    SqlDataReader rd = ADO.cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        datainfo.Rows.Add(false, DateTime.Parse(rd[0].ToString()).ToShortDateString(), rd[1].ToString(), rd[2].ToString(), rd[3].ToString(), rd[4].ToString());
                    }
                    rd.Close();

                }
                else
                {
                    MessageBox.Show("Le Supprission Est Annuller .");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int RowIndex = -1;
            for (int i = 0; i < datainfo.Rows.Count; i++)
            {
                if (bool.Parse(datainfo.Rows[i].Cells[0].Value.ToString()) == true)
                {
                    RowIndex = i;
                    break;
                }
            }
            if (RowIndex == -1)
            {
                MessageBox.Show("Desole Vuillez Selectionner Une Commande Pour Afficher Les Datils !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            else
            {
                int Year, Month, Day;
                DateTime dateCMD = DateTime.Parse(datainfo.Rows[RowIndex].Cells[1].Value.ToString());
                Year = dateCMD.Year;
                Month = dateCMD.Month;
                Day = dateCMD.Day;
                string date = Year + "-" + Month + "-" + Day;
                string cin = datainfo.Rows[RowIndex].Cells[2].Value.ToString();
                string totalht = datainfo.Rows[RowIndex].Cells[3].Value.ToString();
                int tva = int.Parse(datainfo.Rows[RowIndex].Cells[4].Value.ToString());
                string totalttc = datainfo.Rows[RowIndex].Cells[5].Value.ToString();
                FrmDetailsCommande from = new FrmDetailsCommande(date,cin,totalht,tva,totalttc);
                from.ShowDialog();
            }
        }
    }
}
