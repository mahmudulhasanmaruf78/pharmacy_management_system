namespace pharmacy_management_system
{
    partial class signInform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signInform));
            this.label_Exit = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.LogIn_signup = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.signintextpassword = new System.Windows.Forms.TextBox();
            this.signinuser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.signinrole = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Exit
            // 
            this.label_Exit.AutoSize = true;
            this.label_Exit.BackColor = System.Drawing.Color.Red;
            this.label_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Exit.ForeColor = System.Drawing.Color.White;
            this.label_Exit.Location = new System.Drawing.Point(1180, 0);
            this.label_Exit.Name = "label_Exit";
            this.label_Exit.Size = new System.Drawing.Size(34, 32);
            this.label_Exit.TabIndex = 39;
            this.label_Exit.Text = "X";
            this.label_Exit.Click += new System.EventHandler(this.label_Exit_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 755);
            this.panel1.TabIndex = 30;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(86, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(33, 405);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(350, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pharmacy Management System";
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(584, 356);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(177, 29);
            this.checkBox2.TabIndex = 37;
            this.checkBox2.Text = "Show password";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // LogIn_signup
            // 
            this.LogIn_signup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LogIn_signup.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.LogIn_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogIn_signup.Location = new System.Drawing.Point(588, 592);
            this.LogIn_signup.Name = "LogIn_signup";
            this.LogIn_signup.Size = new System.Drawing.Size(431, 48);
            this.LogIn_signup.TabIndex = 35;
            this.LogIn_signup.Text = "Sign up";
            this.LogIn_signup.UseVisualStyleBackColor = false;
            this.LogIn_signup.Click += new System.EventHandler(this.LogIn_signup_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(583, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 29);
            this.label2.TabIndex = 34;
            this.label2.Text = "Password";
            // 
            // signintextpassword
            // 
            this.signintextpassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signintextpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signintextpassword.Location = new System.Drawing.Point(584, 299);
            this.signintextpassword.Name = "signintextpassword";
            this.signintextpassword.Size = new System.Drawing.Size(435, 35);
            this.signintextpassword.TabIndex = 33;
            this.signintextpassword.UseSystemPasswordChar = true;
            this.signintextpassword.TextChanged += new System.EventHandler(this.signintextpassword_TextChanged);
            // 
            // signinuser
            // 
            this.signinuser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signinuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signinuser.Location = new System.Drawing.Point(584, 225);
            this.signinuser.Multiline = true;
            this.signinuser.Name = "signinuser";
            this.signinuser.Size = new System.Drawing.Size(435, 39);
            this.signinuser.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(583, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 29);
            this.label3.TabIndex = 31;
            this.label3.Text = "Username";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(674, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(234, 29);
            this.label6.TabIndex = 43;
            this.label6.Text = "SignUP ACCOUNT";
            // 
            // signinrole
            // 
            this.signinrole.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signinrole.FormattingEnabled = true;
            this.signinrole.Items.AddRange(new object[] {
            "Admin",
            "Cashier",
            "Customar"});
            this.signinrole.Location = new System.Drawing.Point(584, 438);
            this.signinrole.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.signinrole.Name = "signinrole";
            this.signinrole.Size = new System.Drawing.Size(427, 28);
            this.signinrole.TabIndex = 68;
            this.signinrole.SelectedIndexChanged += new System.EventHandler(this.signinrole_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(583, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 29);
            this.label1.TabIndex = 69;
            this.label1.Text = "Role";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(774, 504);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(237, 30);
            this.dateTimePicker1.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(583, 502);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 29);
            this.label4.TabIndex = 71;
            this.label4.Text = "dateRegister:";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(588, 658);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(431, 48);
            this.button1.TabIndex = 72;
            this.button1.Text = "Back Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // signInform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1215, 755);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signinrole);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_Exit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.LogIn_signup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.signintextpassword);
            this.Controls.Add(this.signinuser);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "signInform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "signInform";
            this.Load += new System.EventHandler(this.signInform_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button LogIn_signup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox signintextpassword;
        private System.Windows.Forms.TextBox signinuser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox signinrole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}