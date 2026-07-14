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
using System.Net.NetworkInformation;
using System.Windows.Forms.VisualStyles;

namespace pharmacy_management_system
{
    public partial class adminadduser : UserControl
    {
        public adminadduser()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-HB9J2MTK;Initial Catalog=pharmacy_management_system;Integrated Security=True;");


        private void dataGridView_user_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void adminadduser_Load(object sender, EventArgs e)
        {
            LoadDataGridView();


        }

        private void LoadDataGridView()
        {
            string query = "SELECT username,role,status,dateRegister,password FROM Users";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView_user.DataSource = dt; 
        }

        private void dataGridView_user_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView_user.Rows.Count)
            {
                DataGridViewRow row = dataGridView_user.Rows[e.RowIndex];
                textBox1.Text = row.Cells["Username"].Value?.ToString();
                textBox2.Text = row.Cells["Password"].Value?.ToString();
                comboBox1.Text = row.Cells["Role"].Value?.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(comboBox1.Text) ||
                string.IsNullOrWhiteSpace(comboBox2.Text))
            {
                MessageBox.Show("Please fill in all fields before adding a user.");
                return;
            }

            string check_query = "SELECT COUNT(*) FROM Users WHERE Username = '" + textBox1.Text + "'";
            SqlCommand checkCmd = new SqlCommand(check_query, con);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            int userExists = (int)checkCmd.ExecuteScalar();

            if (userExists > 0)
            {
                MessageBox.Show("This username already exists. Please choose a different username.");
            }
            else
            {
                string insert_query = "insert into users values('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "', GETDATE())";



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
        }


        private void button2_Click(object sender, EventArgs e)
        {

            string update_query = "UPDATE Users SET Status = '" + comboBox2.Text + "' WHERE Username = '" + textBox1.Text + "'";


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
            string delete_query = "DELETE FROM Users WHERE Username = '" + textBox1.Text.Replace("'", "''") + "'";



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
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            textBox1.Focus();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
