using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pharmacy_management_system
{
    public partial class cashierorder : UserControl
    {
        private string CashierID;
        public cashierorder(String id)
        {
            InitializeComponent();
            CashierID = id;

        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-HB9J2MTK;Initial Catalog=pharmacy_management_system;Integrated Security=True;");

        private void cashierorder_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }
        private void LoadDataGridView()
        {
            string query1 = "select productID, productName, catagory, price, stock, expaireDate  from products where stock >0 and status = 'Active'";
            SqlDataAdapter sda1 = new SqlDataAdapter(query1, con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            dataGridView1.DataSource = dt1;



            string query2= "select *from orders";
            SqlDataAdapter sda2 = new SqlDataAdapter(query2, con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            dataGridView2.DataSource = dt2;


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                CPid.Text = row.Cells["productID"].Value?.ToString();
                CPname.Text = row.Cells["productName"].Value?.ToString();
                CPCategory.Text = row.Cells["catagory"].Value?.ToString();
                CPprice.Text = row.Cells["price"].Value?.ToString();
                textBox4.Text = row.Cells["stock"].Value?.ToString();

               
            }
            
        }

        private void button_AddtoCart_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(CPquantity.Text))
            {
                MessageBox.Show("Please enter a quantity.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CPtotalPrice.Text = string.Empty;
                return;
            }

            if (!int.TryParse(CPquantity.Text, out int Quantity))
            {
                MessageBox.Show("Quantity must be an integer.");
                return;
            }
            if (!int.TryParse(textBox4.Text, out int stock))
            {
                MessageBox.Show("Invalid stock quantity.");
                return;
            }

            if (Quantity > stock)
            {
                MessageBox.Show("Quantity exceeds stock quantity.");
                return;
            }

            // Step 1: Insert the order into the orders table
            string insert_query = "INSERT INTO orders VALUES ('" + CashierID + "','" + CPname.Text + "','" + CPid.Text + "','" + CPCategory.Text + "','" + CPquantity.Text + "','" + CPprice.Text + "','" + CPtotalPrice.Text + "','active',GETDATE(),'Pending')";
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

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void textBox_totalPrice_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox_quantity_TextChanged(object sender, EventArgs e)
        {
           

            if (decimal.TryParse(CPquantity.Text, out decimal quantity) && decimal.TryParse(CPprice.Text, out decimal price))
            {
                decimal totalPrice = quantity * price;
                CPtotalPrice.Text = totalPrice.ToString();
            }
            else
            {
                CPtotalPrice.Text = "Invalid input";
            }
        }

        private void button_Cashier_Recept_Click(object sender, EventArgs e)
        {

        }

        private void button_Cashier_Pay_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Please enter an amount.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox5.Text = string.Empty;
                return;
            }

            // Step 1: Get the quantity of the product from the orders table
            string getQuantityQuery = "SELECT quantity FROM orders WHERE productName = '" + CPname.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(getQuantityQuery, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (!int.TryParse(CPquantity.Text, out int quantity))
            {
                MessageBox.Show("Invalid quantity.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Step 2: Update the stock in the products table
            string update_stock_query = "UPDATE products SET stock = stock - " + quantity + " WHERE productID = '" + CPid.Text + "'";
            SqlCommand stockCmd = new SqlCommand(update_stock_query, con);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            int stockResult = stockCmd.ExecuteNonQuery();

            if (stockResult > 0)
            {
                string update_query = "UPDATE orders SET billstutas = '" + Cbill.Text + "' WHERE id = '" + id.Text + "'";
                SqlCommand cmd = new SqlCommand(update_query, con);

                int result = cmd.ExecuteNonQuery();

                if (con.State == ConnectionState.Open)
                {
                    if (result > 0)
                    {
                        MessageBox.Show("Payment successful");
                        LoadDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Payment failed");
                    }
                }
                else
                {
                    MessageBox.Show("DB connection is not established");
                }
            }
            else
            {
                MessageBox.Show("Stock update failed. Please check stock quantity.");
            }

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView2.Rows.Count)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                CPid.Text = row.Cells["productID"].Value?.ToString();
                CPname.Text = row.Cells["productName"].Value?.ToString();
                CPCategory.Text = row.Cells["catagory"].Value?.ToString();
                CPprice.Text = row.Cells["price"].Value?.ToString();
                CPquantity.Text = row.Cells["quantity"].Value?.ToString();
                Cbill.Text = row.Cells["billstutas"].Value?.ToString();
                id.Text = row.Cells["id"].Value?.ToString();
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Clear1();
        }

        private void Clear1()
        {
            CPid.Clear();
            CPname.Clear();
            CPCategory.Clear();
            CPprice.Clear();
            textBox4.Clear();
            CPquantity.Clear();
            CPtotalPrice.Clear();
            Cbill.SelectedIndex = -1;
            textBox3.Clear();
            textBox5.Clear();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
            if (decimal.TryParse(textBox3.Text, out decimal amount) && decimal.TryParse(CPtotalPrice.Text, out decimal totalPrice))
            {
                decimal remaining = amount - totalPrice;
                textBox5.Text = remaining.ToString();
            }
            else
            {
                textBox5.Text = "Invalid input";
            }



        }

        private void button_cashier_Cancel_Click(object sender, EventArgs e)
        {

            DialogResult res = MessageBox.Show("Are you sure you want to cancel the order?", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (res == DialogResult.OK)
            {
                string delete_query = "DELETE FROM orders WHERE id = '" + id.Text.Replace("'", "''") + "'";

                // Step 1: Delete the order from the orders table   
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
                        MessageBox.Show("your order cencel successfully");
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
    }
}

