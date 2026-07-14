using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacy_management_system
{
    public partial class Admindashboard : UserControl
    {
        public Admindashboard()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-HB9J2MTK;Initial Catalog=pharmacy_management_system;Integrated Security=True;");


        private void label9_Click(object sender, EventArgs e)
        {

        }

        
       // LoadDashboardData();



        public void LoadDashboardData()
        {
            string query = "SELECT COUNT(*) AS totalcashier FROM users WHERE role = 'cashier'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                if (reader["totalcashier"] != DBNull.Value)
                {
                    int totalcashier = (int)reader["totalcashier"];
                    label9.Text = totalcashier.ToString();
                }
            }
            reader.Close();
            con.Close();

            string query1 = "SELECT COUNT(*) AS totalorder FROM orders WHERE billstutas='pending'";
            SqlCommand cmd1 = new SqlCommand(query1, con);
            con.Open();

            SqlDataReader reader1 = cmd1.ExecuteReader();
            if (reader1.Read())
            {
                if (reader1["totalorder"] != DBNull.Value)
                {
                    int totalorder = (int)reader1["totalorder"];
                    label4.Text = totalorder.ToString();
                }
            }
            reader1.Close();
            con.Close();
        }

           
        

        private void Admindashboard_Load(object sender, EventArgs e)
        {
            LoadDashboardData();
        }

        private void Admindashboard_VisibleChanged(object sender, EventArgs e)
        {

        }
    }
   
}
    

