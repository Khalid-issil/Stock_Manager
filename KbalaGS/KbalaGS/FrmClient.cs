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
    public partial class FrmClient : Form
    {
        public FrmClient()
        {
            InitializeComponent();

        }
        private void FrmClient_Load(object sender, EventArgs e)
        {
            btnMaxim.Visible = false;
            ADO.cmd = new SqlCommand("AfficherTousLesClient", ADO.cnx);
            ADO.cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader rd = ADO.cmd.ExecuteReader();
            while(rd.Read())
            {
                datainfo.Rows.Add(false,rd[0].ToString(), rd[1].ToString(), rd[2].ToString(), rd[3].ToString(), rd[4].ToString(), rd[5].ToString(), rd[6].ToString(), rd[7].ToString());
            }
            rd.Close();
        }

        private void txtRecherche_Enter(object sender, EventArgs e)
        {
            if (txtRecherche.Text == "Nom Client")
            {
                txtRecherche.Text = "";
            }
        }

        private void txtRecherche_Leave(object sender, EventArgs e)
        {
            if (txtRecherche.Text == "")
            {
                txtRecherche.Text = "Nom Client";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            FrmAjouterClient form = new FrmAjouterClient(datainfo);
            form.ShowDialog();

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int count=0, index=-1;
            if(datainfo.Rows.Count<=0)
            {
                MessageBox.Show("Aucun Clien Pour Modifier Vuiellez Ajouter Des Client", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
           else
            {

                for (int i = 0; i < datainfo.Rows.Count; i++)
                {
                    if (datainfo.Rows[i].Cells[0].Value.ToString().ToLower() == "true")
                    {
                        index = i;
                        count++;
                        if (count > 1)
                        {
                            MessageBox.Show("Desole Veuillez Selectionnez Une Seule Ligne Pour La modification", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                }
                if (index == -1)
                {
                    MessageBox.Show("Desole Veuillez Selectionnez Une Ligne Pour La modification", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    string cin = datainfo.Rows[index].Cells[1].Value.ToString();
                    FrmModifierClient form = new FrmModifierClient(cin, datainfo);
                    form.ShowDialog();
                }
            }
            
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int count = 0, index = -1;
            if (datainfo.Rows.Count <= 0)
            {
                MessageBox.Show("Aucun Clien Pour Le Supprimer Vuiellez Ajouter Des Client", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {

                for (int i = 0; i < datainfo.Rows.Count; i++)
                {
                    if (datainfo.Rows[i].Cells[0].Value.ToString().ToLower() == "true")
                    {
                        index = i;
                        count++;
                        if (count > 1)
                        {
                            MessageBox.Show("Desole Veuillez Selectionnez Une Seule Client Pour La Supprission", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                }
                if (index == -1)
                {
                    MessageBox.Show("Desole Veuillez Selectionnez Une Ligne Pour La Supprission", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    int test;
                    string cin = datainfo.Rows[index].Cells[1].Value.ToString();
                    ADO.cmd = new SqlCommand("SupprimerClient", ADO.cnx);
                    ADO.cmd.CommandType = CommandType.StoredProcedure;
                    ADO.cmd.Parameters.AddWithValue("@cin", cin);
                    ADO.cmd.Parameters.Add("@status", SqlDbType.Int).Direction = ParameterDirection.Output;
                    ADO.cmd.ExecuteNonQuery();
                    test = int.Parse(ADO.cmd.Parameters["@status"].Value.ToString());
                    if(test==-1)
                    {
                        MessageBox.Show("Le Client Non Exists", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else if(test==1)
                    {
                        MessageBox.Show("Le Client Bien Supprimer", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ADO.cmd = new SqlCommand("AfficherTousLesClient", ADO.cnx);
                        ADO.cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataReader dr = ADO.cmd.ExecuteReader();
                        datainfo.Rows.Clear();
                        while (dr.Read())
                        {
                            datainfo.Rows.Add(false, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
                        }
                        dr.Close();
                    }
                    else if(test==-2)
                    {
                        MessageBox.Show("Desole Ce Client Deja Passe Des Commande Vuiellez Dabord Supprimer Les Commande De Ce Client");
                    }

                }
            }
        }

        private void btnMaxim_Click(object sender, EventArgs e)
        {
             this.WindowState = FormWindowState.Normal;
            btnNormale.Visible = true;
            btnMaxim.Visible = false;
        }

        private void btnNormale_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnNormale.Visible = false;
            btnMaxim.Visible = true;
        }

        private void btnMinim_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            datainfo.Rows.Clear();
            string NomRech="";
            if(txtRecherche.Text!= "Nom Client")
            {
                NomRech = txtRecherche.Text;
            }
                ADO.cmd = new SqlCommand("RechercheClient", ADO.cnx);
                ADO.cmd.CommandType = CommandType.StoredProcedure;
                ADO.cmd.Parameters.AddWithValue("@nom", NomRech);
                SqlDataReader rd = ADO.cmd.ExecuteReader();
                datainfo.Rows.Clear();
                while (rd.Read())
                {
                    datainfo.Rows.Add(false, rd[0], rd[1], rd[2], rd[3], rd[4], rd[5], rd[6],rd[7]);
                }
                rd.Close();


            
        }

 
        private void btnRecherche_Click(object sender, EventArgs e)
        {
            AutreMethodeRechercheClient form = new AutreMethodeRechercheClient(datainfo);
            form.ShowDialog();
        }

      

        private void datainfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (bool.Parse(datainfo.Rows[e.RowIndex].Cells[0].Value.ToString()) == false)
                {
                    foreach (DataGridViewRow row in datainfo.Rows)
                    {
                        row.Cells[0].Value = false;
                    }
                    datainfo.Rows[e.RowIndex].Cells[0].Value = true;
                }
                else
                {
                    datainfo.Rows[e.RowIndex].Cells[0].Value = false;
                }
            }
        }
    }
}
