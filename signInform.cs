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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pharmacy_management_system
{
    public partial class signInform : Form
    {
        public signInform()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-HB9J2MTK;Initial Catalog=pharmacy_management_system;Integrated Security=True;");


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void signintextpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox2.Checked)
            {

                signintextpassword.UseSystemPasswordChar = false;
            }
            else
            {

                signintextpassword.UseSystemPasswordChar = true;
            }


        }

        private void label_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void LogIn_signup_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(signinuser.Text) ||
                string.IsNullOrWhiteSpace(signintextpassword.Text) ||
                string.IsNullOrWhiteSpace(signinrole.Text) ||
                (signinrole.SelectedItem.ToString() == "Cashier" && string.IsNullOrWhiteSpace(dateTimePicker1.Value.ToString("yyyy-MM-dd"))))
            {
                MessageBox.Show("Please fill in all fields .");
                return;
            }
            else
            {
                users newUser = new users();
                string role = signinrole.SelectedItem.ToString();
                string dateRegister = (role == "Cashier") ? dateTimePicker1.Value.ToString("yyyy-MM-dd") : "";

                bool isInserted = newUser.InsertUser(signinuser.Text, signintextpassword.Text, role, "Pending", dateRegister);


                if (isInserted)
                {
                    MessageBox.Show("Signup successful!");
                    new Loginform().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Signup failed. Please try again.");
                }

            }
        }

        private void signInform_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new Loginform().Show();
            this.Hide();
        }

        private void signinrole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (signinrole.SelectedItem.ToString() == "Cashier")
            {
                dateTimePicker1.Visible = true;
            }
            else
            {
                dateTimePicker1.Visible = false;
            }





        }
    }
}
