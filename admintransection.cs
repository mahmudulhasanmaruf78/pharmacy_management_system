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
using System.Reflection;

namespace pharmacy_management_system
{
    public partial class Admintransection : UserControl
    {
        public Admintransection()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-HB9J2MTK;Initial Catalog=pharmacy_management_system;Integrated Security=True;");


      
        private void LoadtransectionData()
        {
            string query = "SELECT " +
                "u.Username AS CustomarName, " +
                "o.customerID, " +
                "o.productID, " +
                "o.price, " +
                "o.totalprice, " +
                "o.orderDate AS transactionDate " +
                "FROM orders o " +
                "INNER JOIN users u " +
                "ON o.customerID = u.id";

            //string query = "SELECT customerID ,productID, price, status, orderDate AS transactionDate FROM orders";
            //string query = "SELECT * FROM transactions";
            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView_trans.DataSource = dt;


        }

        private void Admintransection_Load(object sender, EventArgs e)
        {
            LoadtransectionData();
        }

        private void dataGridView_trans_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
