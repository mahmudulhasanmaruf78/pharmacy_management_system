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


namespace pharmacy_management_system
{
    public partial class Loginform : Form
    {



        public Loginform()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-HB9J2MTK;Initial Catalog=pharmacy_management_system;Integrated Security=True;");



        private void Loginform_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form = new Form2();   
            form.Show();
            this.Hide();

        }

        

        private void LogIn_login_Click(object sender, EventArgs e)
        {
            

            if (string.IsNullOrWhiteSpace(Ltext.Text) || string.IsNullOrWhiteSpace(Lpasstext.Text))   
            {
                MessageBox.Show("Please Login koren");
                return;
            }
            users userEntity = new users();
            DataTable dt = userEntity.AuthenticateUser(Ltext.Text, Lpasstext.Text);

            if (dt.Rows.Count == 1)
            {
                if (dt.Rows[0][4].ToString() == "Active")
                {
                    if (dt.Rows[0][3].ToString() == "Admin")
                    {
                        new Form1().Show();
                        this.Hide();
                    }
                    else if (dt.Rows[0][3].ToString() == "Cashier")
                    {
                        string id = dt.Rows[0][0].ToString();
                        Cashier CashierPage = new Cashier(id);
                        CashierPage.Show();
                        this.Hide();

                        
                    }
                    else if (dt.Rows[0][3].ToString() == "Customar")
                    {
                        string id = dt.Rows[0][0].ToString();
                        Customar customerPage = new Customar(id);
                        customerPage.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("plz contract Admin");
                }

            }
            else
            {
                MessageBox.Show("please Sign Up First.");
            }


        }

        private void LogIn_signup_Click(object sender, EventArgs e)
        {
            signInform signInform1 = new signInform();  
            signInform1.Show();
            this.Hide();
        }

        private void label_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogIn_checkBox_CheckedChanged(object sender, EventArgs e)
        {

            if (LogIn_checkBox.Checked)
            {
               
                Lpasstext.UseSystemPasswordChar = false;
            }
            else
            {
               
                Lpasstext.UseSystemPasswordChar = true;
            }

        }
    }
}
