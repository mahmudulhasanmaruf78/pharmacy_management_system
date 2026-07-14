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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Net.NetworkInformation;
using System.Data.SqlTypes;
using System.Xml.Linq;

namespace pharmacy_management_system
{
    public partial class Customar : Form
    {
        
        private string customerID;

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-HB9J2MTK;Initial Catalog=pharmacy_management_system;Integrated Security=True;");
        public Customar(string id)
        {
            InitializeComponent();
            customerID = id;

        }

        private void Orders_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM orders WHERE customerID = @customerID";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@customerID", customerID); // Assuming customerID is a variable holding the actual value
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataGridView1.DataSource = dt;
            }

        }

        
        private void LoadDataGridView()
        {
            string query = "SELECT* FROM products";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DataGridView1.DataSource = dt;
        }


        private void Or_add_Click(object sender, EventArgs e)
        {


           
            if (string.IsNullOrEmpty(this.quantity.Text))
            {
                MessageBox.Show("Please enter the quantity.");
                return;
            }

            if (!int.TryParse(quantity.Text, out int Quantity))
            {
                MessageBox.Show("Quantity must be an integer.");
                return;
            }


            string insert_query = "INSERT INTO orders VALUES ('" + customerID + "','" + name.Text + "','" + id.Text + "','" + Customar_category.Text + "','" + quantity.Text + "','" + price.Text + "','" + total.Text + "','active',GETDATE(),'Pending')";


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
                    MessageBox.Show("apnr product order table geche okhne giya khoj nen");
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




        private void Or_pay_Click(object sender, EventArgs e)
        {
            string update_query = "UPDATE orders SET billstutas = '" + Bill.Text + "' WHERE productName = '" + name.Text + "'";


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
                    MessageBox.Show("Payment successfull");
                    LoadDataGridView();
                }
                else
                {
                    MessageBox.Show(" payment Failed");
                }

            }
            else
            {
                MessageBox.Show("DB connection is not established");
            }
        }
        

        

        private void Customar_logout_Click(object sender, EventArgs e)
        {
            Loginform loginform = new Loginform();
            loginform.Show();
            this.Hide();
        }

        private void Customar_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < DataGridView1.Rows.Count)
            {
                DataGridViewRow row = DataGridView1.Rows[e.RowIndex];

                if (DataGridView1.Columns.Contains("productID"))
                {
                    // Handle the case when the DataGridView is displaying data from the products table
                    name.Text = row.Cells["productName"].Value?.ToString();
                    id.Text = row.Cells["productID"].Value?.ToString();
                    Customar_category.Text = row.Cells["catagory"].Value?.ToString();
                    price.Text = row.Cells["price"].Value?.ToString();
                }
                else if (DataGridView1.Columns.Contains("orderID"))
                {
                    // Handle the case when the DataGridView is displaying data from the orders table
                    id.Text = row.Cells["productID"].Value?.ToString();
                    Customar_category.Text = row.Cells["catagory"].Value?.ToString();
                    price.Text = row.Cells["price"].Value?.ToString();
                    quantity.Text = row.Cells["quantity"].Value?.ToString();
                    Bill.Text = row.Cells["billstutas"].Value?.ToString();
                    total.Text = row.Cells["totalprice"].Value?.ToString();

                    // Calculate the total price based on quantity and price
                    if (decimal.TryParse(quantity.Text, out decimal quantityValue) && decimal.TryParse(price.Text, out decimal priceValue))
                    {
                        decimal totalPrice = quantityValue * priceValue;
                        total.Text = totalPrice.ToString();
                    }
                    else
                    {
                        total.Text = "Invalid input";
                    }
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string query = "SELECT* FROM products";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "SELECT* FROM products";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DataGridView1.DataSource = dt;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(quantity.Text, out float Quantity) && float.TryParse(price.Text, out float Price))
            {
                float totalPrice = Quantity * Price;
                total.Text = totalPrice.ToString();
            }
            else
            {
                total.Text = "Invalid input";
            }



        }

        private void Amount_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(total.Text, out float Total) && float.TryParse(Amount.Text, out float amount))
            {
                float totalPrice = amount-Total;
                remaining.Text = totalPrice.ToString();
            }
           

        }

        private void Clear_Click(object sender, EventArgs e)
        {
           
            name.Clear();
            id.Clear();
            Customar_category.Clear();
            quantity.Clear();
            price.Clear();
            total.Clear();
            Amount.Clear();
            remaining.Clear();


        }

        private void label_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
