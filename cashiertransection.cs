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
    public partial class cashiertransection : UserControl
    {
        public cashiertransection()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-HB9J2MTK;Initial Catalog=pharmacy_management_system;Integrated Security=True;");

        private void cashiertransection_Load(object sender, EventArgs e)
        {
            loadtransectionData();
        }

        private void loadtransectionData()
        {

            string query = "SELECT * FROM orders WHERE orderdate = CAST(GETDATE() AS DATE)";

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                StringBuilder details = new StringBuilder();

                foreach (DataGridViewCell cell in row.Cells)
                {
                    details.AppendLine($"{dataGridView1.Columns[cell.ColumnIndex].HeaderText}: {cell.Value}");
                }

                MessageBox.Show(details.ToString(), "Row Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
