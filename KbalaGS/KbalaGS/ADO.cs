using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace KbalaGS
{
    class ADO
    {
        public static SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-T7HHOKC\SQLEXPRESS;Initial Catalog=ProjetFF;Integrated Security=True");
        public static SqlCommand cmd;
        public static DataRow dr;
        public static SqlDataAdapter dap;
        public static SqlCommandBuilder scb;
        public static DataSet ds = new DataSet();

        public ADO()
        {

        }
        public void Connecter()
        {

          if(cnx.State==ConnectionState.Closed || cnx.State==ConnectionState.Broken)
            {
                cnx.Open();
            }
          

        }
        public void Deconnecter()
        {
            if(cnx.State==ConnectionState.Open)
            {
                cnx.Close();
            }
                
        }

    }
}
