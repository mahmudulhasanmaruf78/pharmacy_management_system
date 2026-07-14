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
    public partial class LodingProject : Form
    {
        public LodingProject()
        {
            InitializeComponent();
        }

        private void LodingProject_Load(object sender, EventArgs e)
        {
            
            timer1.Start();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                this.Hide();
                Loginform loginpage = new Loginform();
                loginpage.Show();
                
            }

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
