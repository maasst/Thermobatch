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
using ZedGraph;

namespace Thermobatch
{
    public partial class Hauptfenster : Form
    {
        public Hauptfenster()
        {
            InitializeComponent();

            string connectionString = "Data Source=VS-LABOR;Initial Catalog=Temperaturlabor;Integrated Security=True";
            tbx_DBConnectionStr.Text = connectionString;
            string sql = "SELECT Zeitstempel,Messstelle,Messwert,Einheit,Bemerkung FROM messwerte";
            tbx_SqlCmd_Messwerte.Text = sql;



        }

        private void btn_DBMesswerteLesen_Click(object sender, EventArgs e)
        {

          
            string sql = "SELECT Zeitstempel,Messstelle,Messwert,Einheit,Bemerkung FROM messwerte";
          
            

            SqlConnection connection = new SqlConnection(tbx_DBConnectionStr.Text);
            SqlDataAdapter dataadapter = new SqlDataAdapter(tbx_SqlCmd_Messwerte.Text, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "MesswerteTab");
            connection.Close();
            dGrVw_Messwerte.DataSource = ds;
            dGrVw_Messwerte.DataMember = "MesswerteTab";


        }

      
        private void btn_DBMessstellenLesen_Click(object sender, EventArgs e)
        {
            string SqlCmdStr = "SELECT distinct Messstelle FROM messwerte";

            SqlConnection connection = new SqlConnection(tbx_DBConnectionStr.Text);
            SqlCommand command = new SqlCommand(SqlCmdStr,connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    chklb_Messtellen.Items.Add(reader.GetString(0));
                    btn_DBMesswerteLesen.Enabled = true;
                }
            }
            else
            {
                chklb_Messtellen.Items.Add("Keine Messtellegefunden");
                btn_DBMesswerteLesen.Enabled = false;
            }
            reader.Close();

            
            
            



        }

        private void zedGraphControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
