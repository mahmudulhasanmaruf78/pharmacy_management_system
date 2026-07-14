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
    public partial class Cashier : Form
    {
        private string CashierID;
        public Cashier(string id)
        {
            InitializeComponent();
            CashierID = id;
        }

        List<UserControl> userControls = new List<UserControl>();
        int index = 0;

        private void Cashier_Load(object sender, EventArgs e)
        {
            Cashiardeshboard dashboard1 = new Cashiardeshboard();
            cashierorder cashierorder1 = new cashierorder(CashierID);
            cashiertransection cashiertransactions1 = new cashiertransection();

            userControls.Add(dashboard1);
            userControls.Add(cashierorder1);
            userControls.Add(cashiertransactions1);

            foreach (UserControl control in userControls)
            {
                control.Visible = false;
                control.Dock = DockStyle.Fill;
                this.Controls.Add(control);
            }

            userControls[index].Visible = true;
            userControls[index].BringToFront();
        }

        private void Cashier_Dashboard_Click(object sender, EventArgs e)
        {
            index = 0;
            ShowControl(index);
        }

        private void Cashierorder_Click(object sender, EventArgs e)
        {

            index = 1;
            ShowControl(index);
        }

        private void Cashiertransaction_Click(object sender, EventArgs e)
        {

            index = 2;
            ShowControl(index);

        }

        private void ShowControl(int index)
        {

            for (int i = 0; i < userControls.Count; i++)
            {
                if (i == index)
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

        private void Cashierlogout_Click(object sender, EventArgs e)
        {
            Loginform loginform = new Loginform();
            loginform.Show();
            this.Hide();
        }

        private void label_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            index = 0;
            ShowControl(index);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
