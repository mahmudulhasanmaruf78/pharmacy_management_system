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
using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Net.NetworkInformation;

namespace pharmacy_management_system
{
    public partial class Form1 : Form
    {

        List<UserControl> userControls = new List<UserControl>();
        int index = 0;

        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-HB9J2MTK;Initial Catalog=pharmacy_management_system;Integrated Security=True;");


        

        private void Form1_Load(object sender, EventArgs e)
        {
             Admindashboard f1 = new Admindashboard();
             adminadduser f2 = new adminadduser();
             adminaddcategoris f3= new adminaddcategoris();
             adminaddproduct f4= new adminaddproduct();
             Admintransection f5 = new Admintransection();

            userControls.Add(f1);
            userControls.Add(f2);
            userControls.Add(f3);
            userControls.Add(f4);
            userControls.Add(f5);

            foreach (var control in userControls)
            {
                control.Visible = false;
                control.Dock = DockStyle.Fill; 
                this.Controls.Add(control);
            }

            userControls[index].Visible = true;
            userControls[index].BringToFront();

        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }


        private void ShowControl(int controlIndex)
        {
            for (int i = 0; i < userControls.Count; i++)
            {
                if (i == controlIndex)
                {
                    userControls[i].Visible = true;
                    userControls[i].BringToFront();
                }
                else
                {
                    userControls[i].Visible = false;
                }
            }
        }

        private void label_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            index = 0;
            ShowControl(index);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Admin_addcategories_Click(object sender, EventArgs e)
        {

            index = 2;
            ShowControl(index);
        }

        private void Admin_addproducts_Click(object sender, EventArgs e)
        {

            index = 3;
            ShowControl(index);
        }

        private void Admin_adduser_Click(object sender, EventArgs e)
        {
            index = 1;
            ShowControl(index);

        }

        private void Admin_Dashboard_Click(object sender, EventArgs e)
        {
            index = 0;
            ShowControl(index);
        }

        private void Admin_logout_Click(object sender, EventArgs e)
        {
            Loginform a1 = new Loginform();
            a1.Show();
            this.Hide();
        }

        private void Admin_transaction_Click(object sender, EventArgs e)
        {
            index = 4;
            ShowControl(index);
        }
    }
}
