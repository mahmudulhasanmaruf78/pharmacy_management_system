namespace pharmacy_management_system
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_Exit = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Admin_Dashboard = new System.Windows.Forms.Button();
            this.Admin_adduser = new System.Windows.Forms.Button();
            this.Admin_addcategories = new System.Windows.Forms.Button();
            this.Admin_addproducts = new System.Windows.Forms.Button();
            this.Admin_transaction = new System.Windows.Forms.Button();
            this.Admin_logout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.admindashboard1 = new pharmacy_management_system.Admindashboard();
            this.adminadduser1 = new pharmacy_management_system.adminadduser();
            this.adminaddcategoris1 = new pharmacy_management_system.adminaddcategoris();
            this.adminaddproduct1 = new pharmacy_management_system.adminaddproduct();
            this.admintransection1 = new pharmacy_management_system.Admintransection();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::pharmacy_management_system.Properties.Resources.v987_18a;
            this.pictureBox3.Location = new System.Drawing.Point(3, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(53, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pharmacy Managment System";
            // 
            // label_Exit
            // 
            this.label_Exit.AutoSize = true;
            this.label_Exit.BackColor = System.Drawing.Color.Red;
            this.label_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Exit.ForeColor = System.Drawing.Color.White;
            this.label_Exit.Location = new System.Drawing.Point(1178, 5);
            this.label_Exit.Name = "label_Exit";
            this.label_Exit.Size = new System.Drawing.Size(34, 32);
            this.label_Exit.TabIndex = 7;
            this.label_Exit.Text = "X";
            this.label_Exit.Click += new System.EventHandler(this.label_Exit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label_Exit);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1217, 40);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(104, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome,";
            // 
            // Admin_Dashboard
            // 
            this.Admin_Dashboard.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Admin_Dashboard.FlatAppearance.BorderSize = 0;
            this.Admin_Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Admin_Dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_Dashboard.ForeColor = System.Drawing.Color.White;
            this.Admin_Dashboard.Image = ((System.Drawing.Image)(resources.GetObject("Admin_Dashboard.Image")));
            this.Admin_Dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Admin_Dashboard.Location = new System.Drawing.Point(41, 204);
            this.Admin_Dashboard.Name = "Admin_Dashboard";
            this.Admin_Dashboard.Size = new System.Drawing.Size(248, 46);
            this.Admin_Dashboard.TabIndex = 9;
            this.Admin_Dashboard.Text = "Dashboard";
            this.Admin_Dashboard.UseVisualStyleBackColor = false;
            this.Admin_Dashboard.Click += new System.EventHandler(this.Admin_Dashboard_Click);
            // 
            // Admin_adduser
            // 
            this.Admin_adduser.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Admin_adduser.FlatAppearance.BorderSize = 0;
            this.Admin_adduser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Admin_adduser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_adduser.ForeColor = System.Drawing.Color.White;
            this.Admin_adduser.Image = ((System.Drawing.Image)(resources.GetObject("Admin_adduser.Image")));
            this.Admin_adduser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Admin_adduser.Location = new System.Drawing.Point(41, 256);
            this.Admin_adduser.Name = "Admin_adduser";
            this.Admin_adduser.Size = new System.Drawing.Size(248, 46);
            this.Admin_adduser.TabIndex = 10;
            this.Admin_adduser.Text = "Add Users";
            this.Admin_adduser.UseVisualStyleBackColor = false;
            this.Admin_adduser.Click += new System.EventHandler(this.Admin_adduser_Click);
            // 
            // Admin_addcategories
            // 
            this.Admin_addcategories.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Admin_addcategories.FlatAppearance.BorderSize = 0;
            this.Admin_addcategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Admin_addcategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_addcategories.ForeColor = System.Drawing.Color.White;
            this.Admin_addcategories.Image = ((System.Drawing.Image)(resources.GetObject("Admin_addcategories.Image")));
            this.Admin_addcategories.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Admin_addcategories.Location = new System.Drawing.Point(41, 308);
            this.Admin_addcategories.Name = "Admin_addcategories";
            this.Admin_addcategories.Size = new System.Drawing.Size(248, 53);
            this.Admin_addcategories.TabIndex = 11;
            this.Admin_addcategories.Text = "Add Categories";
            this.Admin_addcategories.UseVisualStyleBackColor = false;
            this.Admin_addcategories.Click += new System.EventHandler(this.Admin_addcategories_Click);
            // 
            // Admin_addproducts
            // 
            this.Admin_addproducts.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Admin_addproducts.FlatAppearance.BorderSize = 0;
            this.Admin_addproducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Admin_addproducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_addproducts.ForeColor = System.Drawing.Color.White;
            this.Admin_addproducts.Image = ((System.Drawing.Image)(resources.GetObject("Admin_addproducts.Image")));
            this.Admin_addproducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Admin_addproducts.Location = new System.Drawing.Point(41, 367);
            this.Admin_addproducts.Name = "Admin_addproducts";
            this.Admin_addproducts.Size = new System.Drawing.Size(248, 52);
            this.Admin_addproducts.TabIndex = 12;
            this.Admin_addproducts.Text = "Add Products";
            this.Admin_addproducts.UseVisualStyleBackColor = false;
            this.Admin_addproducts.Click += new System.EventHandler(this.Admin_addproducts_Click);
            // 
            // Admin_transaction
            // 
            this.Admin_transaction.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Admin_transaction.FlatAppearance.BorderSize = 0;
            this.Admin_transaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Admin_transaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_transaction.ForeColor = System.Drawing.Color.White;
            this.Admin_transaction.Image = ((System.Drawing.Image)(resources.GetObject("Admin_transaction.Image")));
            this.Admin_transaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Admin_transaction.Location = new System.Drawing.Point(41, 425);
            this.Admin_transaction.Name = "Admin_transaction";
            this.Admin_transaction.Size = new System.Drawing.Size(248, 37);
            this.Admin_transaction.TabIndex = 13;
            this.Admin_transaction.Text = "Transactions";
            this.Admin_transaction.UseVisualStyleBackColor = false;
            this.Admin_transaction.Click += new System.EventHandler(this.Admin_transaction_Click);
            // 
            // Admin_logout
            // 
            this.Admin_logout.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Admin_logout.FlatAppearance.BorderSize = 0;
            this.Admin_logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Admin_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_logout.ForeColor = System.Drawing.Color.White;
            this.Admin_logout.Image = ((System.Drawing.Image)(resources.GetObject("Admin_logout.Image")));
            this.Admin_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Admin_logout.Location = new System.Drawing.Point(41, 588);
            this.Admin_logout.Name = "Admin_logout";
            this.Admin_logout.Size = new System.Drawing.Size(248, 50);
            this.Admin_logout.TabIndex = 14;
            this.Admin_logout.Text = "Logout";
            this.Admin_logout.UseVisualStyleBackColor = false;
            this.Admin_logout.Click += new System.EventHandler(this.Admin_logout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(178, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Admin";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Admin_logout);
            this.panel2.Controls.Add(this.Admin_transaction);
            this.panel2.Controls.Add(this.Admin_addproducts);
            this.panel2.Controls.Add(this.Admin_addcategories);
            this.panel2.Controls.Add(this.Admin_adduser);
            this.panel2.Controls.Add(this.Admin_Dashboard);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(375, 715);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.admintransection1);
            this.panel3.Controls.Add(this.adminaddproduct1);
            this.panel3.Controls.Add(this.adminaddcategoris1);
            this.panel3.Controls.Add(this.adminadduser1);
            this.panel3.Controls.Add(this.admindashboard1);
            this.panel3.Location = new System.Drawing.Point(370, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(835, 699);
            this.panel3.TabIndex = 2;
            // 
            // admindashboard1
            // 
            this.admindashboard1.Location = new System.Drawing.Point(18, 5);
            this.admindashboard1.Name = "admindashboard1";
            this.admindashboard1.Size = new System.Drawing.Size(814, 695);
            this.admindashboard1.TabIndex = 0;
            // 
            // adminadduser1
            // 
            this.adminadduser1.Location = new System.Drawing.Point(11, 0);
            this.adminadduser1.Name = "adminadduser1";
            this.adminadduser1.Size = new System.Drawing.Size(814, 695);
            this.adminadduser1.TabIndex = 1;
            // 
            // adminaddcategoris1
            // 
            this.adminaddcategoris1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.adminaddcategoris1.Location = new System.Drawing.Point(11, 3);
            this.adminaddcategoris1.Name = "adminaddcategoris1";
            this.adminaddcategoris1.Size = new System.Drawing.Size(814, 695);
            this.adminaddcategoris1.TabIndex = 2;
            // 
            // adminaddproduct1
            // 
            this.adminaddproduct1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.adminaddproduct1.Location = new System.Drawing.Point(3, -3);
            this.adminaddproduct1.Name = "adminaddproduct1";
            this.adminaddproduct1.Size = new System.Drawing.Size(814, 695);
            this.adminaddproduct1.TabIndex = 3;
            // 
            // admintransection1
            // 
            this.admintransection1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.admintransection1.Location = new System.Drawing.Point(3, 1);
            this.admintransection1.Name = "admintransection1";
            this.admintransection1.Size = new System.Drawing.Size(814, 695);
            this.admintransection1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 755);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_Exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Admin_Dashboard;
        private System.Windows.Forms.Button Admin_adduser;
        private System.Windows.Forms.Button Admin_addcategories;
        private System.Windows.Forms.Button Admin_addproducts;
        private System.Windows.Forms.Button Admin_transaction;
        private System.Windows.Forms.Button Admin_logout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Admintransection admintransection1;
        private adminaddproduct adminaddproduct1;
        private adminaddcategoris adminaddcategoris1;
        private adminadduser adminadduser1;
        private Admindashboard admindashboard1;
    }
}

