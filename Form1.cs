using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void adminadduser1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
             admindashboard f1 = new admindashboard();
             adminadduser f2 = new adminadduser();
             adminaddcategoris f3= new adminaddcategoris();
             adminaddproduct f4= new adminaddproduct();
             admintransection f5 = new admintransection();

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

        private void admin_Dashboard_Click(object sender, EventArgs e)
        {
            index = 0;
            ShowControl(index);

        }

        private void admin_adduser_Click(object sender, EventArgs e)
        {
            index = 1;
            ShowControl(index);

        }

        private void admin_addcategories_Click(object sender, EventArgs e)
        {
            index = 2;
            ShowControl(index);
        }

        private void admin_addproducts_Click(object sender, EventArgs e)
        {
            index = 3;
            ShowControl(index);
        }

        private void admin_transaction_Click(object sender, EventArgs e)
        {
            index = 4;
            ShowControl(index);
        }

        private void admin_logout_Click(object sender, EventArgs e)
        {
            Loginform a1 = new Loginform();
            a1.Show();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
    }
}
