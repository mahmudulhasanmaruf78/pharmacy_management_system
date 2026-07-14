namespace pharmacy_management_system
{
    partial class adminadduser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminadduser));
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.clearuser = new System.Windows.Forms.Button();
            this.deleteuser = new System.Windows.Forms.Button();
            this.updateuser = new System.Windows.Forms.Button();
            this.adduser = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView_user = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_user)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.clearuser);
            this.panel1.Controls.Add(this.deleteuser);
            this.panel1.Controls.Add(this.updateuser);
            this.panel1.Controls.Add(this.adduser);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 695);
            this.panel1.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.comboBox2.Location = new System.Drawing.Point(32, 358);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(222, 28);
            this.comboBox2.TabIndex = 26;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Admin",
            "Cashier",
            "Customar"});
            this.comboBox1.Location = new System.Drawing.Point(32, 288);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(222, 28);
            this.comboBox1.TabIndex = 25;
            // 
            // clearuser
            // 
            this.clearuser.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.clearuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearuser.Location = new System.Drawing.Point(32, 555);
            this.clearuser.Name = "clearuser";
            this.clearuser.Size = new System.Drawing.Size(222, 46);
            this.clearuser.TabIndex = 24;
            this.clearuser.Text = "CLEAR";
            this.clearuser.UseVisualStyleBackColor = false;
            this.clearuser.Click += new System.EventHandler(this.button4_Click);
            // 
            // deleteuser
            // 
            this.deleteuser.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.deleteuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteuser.Location = new System.Drawing.Point(32, 508);
            this.deleteuser.Name = "deleteuser";
            this.deleteuser.Size = new System.Drawing.Size(222, 41);
            this.deleteuser.TabIndex = 23;
            this.deleteuser.Text = "DELETE";
            this.deleteuser.UseVisualStyleBackColor = false;
            this.deleteuser.Click += new System.EventHandler(this.button3_Click);
            // 
            // updateuser
            // 
            this.updateuser.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.updateuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateuser.Location = new System.Drawing.Point(32, 461);
            this.updateuser.Name = "updateuser";
            this.updateuser.Size = new System.Drawing.Size(222, 41);
            this.updateuser.TabIndex = 22;
            this.updateuser.Text = "UPDATE";
            this.updateuser.UseVisualStyleBackColor = false;
            this.updateuser.Click += new System.EventHandler(this.button2_Click);
            // 
            // adduser
            // 
            this.adduser.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.adduser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adduser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.adduser.Location = new System.Drawing.Point(32, 414);
            this.adduser.Name = "adduser";
            this.adduser.Size = new System.Drawing.Size(222, 41);
            this.adduser.TabIndex = 21;
            this.adduser.Text = "ADD";
            this.adduser.UseVisualStyleBackColor = false;
            this.adduser.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Role";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(33, 207);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(224, 40);
            this.textBox2.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 130);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 40);
            this.textBox1.TabIndex = 16;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(92, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.dataGridView_user);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(294, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(520, 695);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView_user
            // 
            this.dataGridView_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_user.Location = new System.Drawing.Point(71, 67);
            this.dataGridView_user.Name = "dataGridView_user";
            this.dataGridView_user.RowHeadersWidth = 62;
            this.dataGridView_user.RowTemplate.Height = 28;
            this.dataGridView_user.Size = new System.Drawing.Size(404, 526);
            this.dataGridView_user.TabIndex = 0;
            this.dataGridView_user.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_user_CellClick);
            this.dataGridView_user.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_user_CellContentClick);
            // 
            // adminadduser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "adminadduser";
            this.Size = new System.Drawing.Size(814, 695);
            this.Load += new System.EventHandler(this.adminadduser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_user)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button clearuser;
        private System.Windows.Forms.Button deleteuser;
        private System.Windows.Forms.Button updateuser;
        private System.Windows.Forms.Button adduser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView_user;
    }
}
