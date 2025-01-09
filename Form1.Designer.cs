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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.admin_Dashboard = new System.Windows.Forms.Button();
            this.admin_adduser = new System.Windows.Forms.Button();
            this.admin_addcategories = new System.Windows.Forms.Button();
            this.admin_addproducts = new System.Windows.Forms.Button();
            this.admin_transaction = new System.Windows.Forms.Button();
            this.admin_logout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.admintransection1 = new pharmacy_management_system.admintransection();
            this.adminaddproduct1 = new pharmacy_management_system.adminaddproduct();
            this.adminaddcategoris1 = new pharmacy_management_system.adminaddcategoris();
            this.adminadduser1 = new pharmacy_management_system.adminadduser();
            this.admindashboard1 = new pharmacy_management_system.admindashboard();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1215, 40);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.admin_logout);
            this.panel2.Controls.Add(this.admin_transaction);
            this.panel2.Controls.Add(this.admin_addproducts);
            this.panel2.Controls.Add(this.admin_addcategories);
            this.panel2.Controls.Add(this.admin_adduser);
            this.panel2.Controls.Add(this.admin_Dashboard);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(382, 715);
            this.panel2.TabIndex = 1;
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
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome,Admin";
            // 
            // admin_Dashboard
            // 
            this.admin_Dashboard.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.admin_Dashboard.FlatAppearance.BorderSize = 0;
            this.admin_Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_Dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_Dashboard.ForeColor = System.Drawing.Color.White;
            this.admin_Dashboard.Image = ((System.Drawing.Image)(resources.GetObject("admin_Dashboard.Image")));
            this.admin_Dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.admin_Dashboard.Location = new System.Drawing.Point(41, 204);
            this.admin_Dashboard.Name = "admin_Dashboard";
            this.admin_Dashboard.Size = new System.Drawing.Size(248, 46);
            this.admin_Dashboard.TabIndex = 9;
            this.admin_Dashboard.Text = "Dashboard";
            this.admin_Dashboard.UseVisualStyleBackColor = false;
            this.admin_Dashboard.Click += new System.EventHandler(this.admin_Dashboard_Click);
            // 
            // admin_adduser
            // 
            this.admin_adduser.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.admin_adduser.FlatAppearance.BorderSize = 0;
            this.admin_adduser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_adduser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_adduser.ForeColor = System.Drawing.Color.White;
            this.admin_adduser.Image = ((System.Drawing.Image)(resources.GetObject("admin_adduser.Image")));
            this.admin_adduser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.admin_adduser.Location = new System.Drawing.Point(41, 256);
            this.admin_adduser.Name = "admin_adduser";
            this.admin_adduser.Size = new System.Drawing.Size(248, 46);
            this.admin_adduser.TabIndex = 10;
            this.admin_adduser.Text = "Add Users";
            this.admin_adduser.UseVisualStyleBackColor = false;
            this.admin_adduser.Click += new System.EventHandler(this.admin_adduser_Click);
            // 
            // admin_addcategories
            // 
            this.admin_addcategories.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.admin_addcategories.FlatAppearance.BorderSize = 0;
            this.admin_addcategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_addcategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_addcategories.ForeColor = System.Drawing.Color.White;
            this.admin_addcategories.Image = ((System.Drawing.Image)(resources.GetObject("admin_addcategories.Image")));
            this.admin_addcategories.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.admin_addcategories.Location = new System.Drawing.Point(41, 308);
            this.admin_addcategories.Name = "admin_addcategories";
            this.admin_addcategories.Size = new System.Drawing.Size(248, 53);
            this.admin_addcategories.TabIndex = 11;
            this.admin_addcategories.Text = "Add Categories";
            this.admin_addcategories.UseVisualStyleBackColor = false;
            this.admin_addcategories.Click += new System.EventHandler(this.admin_addcategories_Click);
            // 
            // admin_addproducts
            // 
            this.admin_addproducts.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.admin_addproducts.FlatAppearance.BorderSize = 0;
            this.admin_addproducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_addproducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_addproducts.ForeColor = System.Drawing.Color.White;
            this.admin_addproducts.Image = ((System.Drawing.Image)(resources.GetObject("admin_addproducts.Image")));
            this.admin_addproducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.admin_addproducts.Location = new System.Drawing.Point(41, 367);
            this.admin_addproducts.Name = "admin_addproducts";
            this.admin_addproducts.Size = new System.Drawing.Size(248, 52);
            this.admin_addproducts.TabIndex = 12;
            this.admin_addproducts.Text = "Add Products";
            this.admin_addproducts.UseVisualStyleBackColor = false;
            this.admin_addproducts.Click += new System.EventHandler(this.admin_addproducts_Click);
            // 
            // admin_transaction
            // 
            this.admin_transaction.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.admin_transaction.FlatAppearance.BorderSize = 0;
            this.admin_transaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_transaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_transaction.ForeColor = System.Drawing.Color.White;
            this.admin_transaction.Image = ((System.Drawing.Image)(resources.GetObject("admin_transaction.Image")));
            this.admin_transaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.admin_transaction.Location = new System.Drawing.Point(41, 425);
            this.admin_transaction.Name = "admin_transaction";
            this.admin_transaction.Size = new System.Drawing.Size(248, 37);
            this.admin_transaction.TabIndex = 13;
            this.admin_transaction.Text = "Transactions";
            this.admin_transaction.UseVisualStyleBackColor = false;
            this.admin_transaction.Click += new System.EventHandler(this.admin_transaction_Click);
            // 
            // admin_logout
            // 
            this.admin_logout.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.admin_logout.FlatAppearance.BorderSize = 0;
            this.admin_logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.admin_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_logout.ForeColor = System.Drawing.Color.White;
            this.admin_logout.Image = ((System.Drawing.Image)(resources.GetObject("admin_logout.Image")));
            this.admin_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.admin_logout.Location = new System.Drawing.Point(41, 588);
            this.admin_logout.Name = "admin_logout";
            this.admin_logout.Size = new System.Drawing.Size(248, 50);
            this.admin_logout.TabIndex = 14;
            this.admin_logout.Text = "Logout";
            this.admin_logout.UseVisualStyleBackColor = false;
            this.admin_logout.Click += new System.EventHandler(this.admin_logout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1174, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.admintransection1);
            this.panel3.Controls.Add(this.adminaddproduct1);
            this.panel3.Controls.Add(this.adminaddcategoris1);
            this.panel3.Controls.Add(this.adminadduser1);
            this.panel3.Controls.Add(this.admindashboard1);
            this.panel3.Location = new System.Drawing.Point(388, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(814, 695);
            this.panel3.TabIndex = 2;
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
            // admintransection1
            // 
            this.admintransection1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.admintransection1.Location = new System.Drawing.Point(-3, -6);
            this.admintransection1.Name = "admintransection1";
            this.admintransection1.Size = new System.Drawing.Size(814, 695);
            this.admintransection1.TabIndex = 4;
            // 
            // adminaddproduct1
            // 
            this.adminaddproduct1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.adminaddproduct1.Location = new System.Drawing.Point(-3, -6);
            this.adminaddproduct1.Name = "adminaddproduct1";
            this.adminaddproduct1.Size = new System.Drawing.Size(814, 695);
            this.adminaddproduct1.TabIndex = 3;
            // 
            // adminaddcategoris1
            // 
            this.adminaddcategoris1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.adminaddcategoris1.Location = new System.Drawing.Point(-3, -3);
            this.adminaddcategoris1.Name = "adminaddcategoris1";
            this.adminaddcategoris1.Size = new System.Drawing.Size(814, 695);
            this.adminaddcategoris1.TabIndex = 2;
            // 
            // adminadduser1
            // 
            this.adminadduser1.Location = new System.Drawing.Point(0, -3);
            this.adminadduser1.Name = "adminadduser1";
            this.adminadduser1.Size = new System.Drawing.Size(814, 695);
            this.adminadduser1.TabIndex = 1;
            // 
            // admindashboard1
            // 
            this.admindashboard1.Location = new System.Drawing.Point(0, 0);
            this.admindashboard1.Name = "admindashboard1";
            this.admindashboard1.Size = new System.Drawing.Size(814, 695);
            this.admindashboard1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 755);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button admin_addproducts;
        private System.Windows.Forms.Button admin_addcategories;
        private System.Windows.Forms.Button admin_adduser;
        private System.Windows.Forms.Button admin_Dashboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button admin_logout;
        private System.Windows.Forms.Button admin_transaction;
        private System.Windows.Forms.Panel panel3;
        private admintransection admintransection1;
        private adminaddproduct adminaddproduct1;
        private adminaddcategoris adminaddcategoris1;
        private adminadduser adminadduser1;
        private admindashboard admindashboard1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
    }
}

