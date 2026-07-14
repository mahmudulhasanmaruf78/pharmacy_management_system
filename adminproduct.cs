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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pharmacy_management_system
{
    public partial class adminaddproduct : UserControl
    {


        public adminaddproduct()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-HB9J2MTK;Initial Catalog=pharmacy_management_system;Integrated Security=True;");

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void adminaddproduct_Load(object sender, EventArgs e)
        {
            LoadDataGridView();


        }
        private void LoadDataGridView()
        {
            string query = "SELECT* FROM products";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView_product.DataSource = dt;
        }

        private void dataGridView_product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView_product.Rows.Count)
            {
                DataGridViewRow row = dataGridView_product.Rows[e.RowIndex];
                textBox1.Text = row.Cells["productID"].Value?.ToString();
                textBox2.Text = row.Cells["productName"].Value?.ToString();
                textBox3.Text = row.Cells["price"].Value?.ToString();
                textBox4.Text = row.Cells["stock"].Value?.ToString();
                comboBox1.Text = row.Cells["catagory"].Value?.ToString();
                comboBox2.Text = row.Cells["status"].Value?.ToString();
                string imagePath = row.Cells["image"].Value?.ToString();
                if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
                {
                    pictureBox1.Image = Image.FromFile(imagePath);
                   
                }
                else
                {
                    pictureBox1.Image = null;
                }
                
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string check_query = "SELECT COUNT(*) FROM products WHERE productID = '" + textBox1.Text + "'";
            SqlCommand checkCmd = new SqlCommand(check_query, con);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            int productExists = (int)checkCmd.ExecuteScalar();

            if (productExists > 0)
            {
                MessageBox.Show("This productID already exists. Please choose a different productID.");
            }
            else
            {
                string insert_query = "insert into products values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + importbatton.Text + "', '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "')";




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
            string update_query = "UPDATE products SET stock = '" + textBox4.Text + "' WHERE productName = '" + textBox2.Text + "'";


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
            string delete_query = "DELETE FROM products WHERE productID = '" + textBox1.Text.Replace("'", "''") + "'";



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
            textBox3.Clear();
            textBox4.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            pictureBox1.Image = null;
            textBox1.Focus();

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            string query = "SELECT category FROM categories";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "category";
        }

        private void importbatton_Click(object sender, EventArgs e)
        {
           
        }

        private void importbatton_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(ofd.FileName);
                importbatton.Text = ofd.FileName;
            }

        }
    }
}
