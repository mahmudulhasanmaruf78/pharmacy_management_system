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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pharmacy_management_system
{
    public partial class adminaddcategoris : UserControl
    {
        public adminaddcategoris()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-HB9J2MTK;Initial Catalog=pharmacy_management_system;Integrated Security=True;");

        private void adminaddcategoris_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            string query = "SELECT category,status,insertDate FROM categories";
            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView_categorie.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(categorie_text.Text) ||

                string.IsNullOrWhiteSpace(categorie_status.Text) )
                
            {
                MessageBox.Show("Please fill in all fields before adding category.");
                return;
            }

            string insert_query = "INSERT INTO categories values('" + categorie_text.Text + "','" + categorie_status.Text + "',GETDATE())";
           



            SqlCommand cmd = new SqlCommand(insert_query, con);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            int result = cmd.ExecuteNonQuery();

            if (con.State == ConnectionState.Open)
            {
                if (result > 0)
                {
                    MessageBox.Show("Add successfull");
                    LoadDataGridView();
                }
                else
                {
                    MessageBox.Show("Failed");
                }

            }
            else
            {
                MessageBox.Show("DB connection is not established");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string update_query = "UPDATE categories SET Status = '" + categorie_status.Text + "' WHERE category = '" + categorie_text.Text + "'";


            SqlCommand cmd = new SqlCommand(update_query, con);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            int result = cmd.ExecuteNonQuery();

            if (con.State == ConnectionState.Open)
            {
                if (result > 0)
                {
                    MessageBox.Show("Update successfull");
                    LoadDataGridView();
                }
                else
                {
                    MessageBox.Show("Failed");
                }

            }
            else
            {
                MessageBox.Show("DB connection is not established");
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            string delete_query = "DELETE FROM categories WHERE category = '" + categorie_text.Text.Replace("'", "''") + "'";



            SqlCommand cmd = new SqlCommand(delete_query, con);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            int result = cmd.ExecuteNonQuery();

            if (con.State == ConnectionState.Open)
            {
                if (result > 0)
                {
                    MessageBox.Show("Delete successfull");
                    LoadDataGridView();
                }
                else
                {
                    MessageBox.Show("Failed");
                }

            }
            else
            {
                MessageBox.Show("DB connection is not established");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            categorie_text.Clear();
             categorie_status.SelectedIndex = -1;
            categorie_text.Focus();
        }

        private void dataGridView_categorie_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView_categorie.Rows.Count)
            {
                DataGridViewRow row = dataGridView_categorie.Rows[e.RowIndex];
                categorie_text.Text = row.Cells["category"].Value?.ToString();
                categorie_status.Text = row.Cells["status"].Value?.ToString();

            }
        }
    }
    
}
