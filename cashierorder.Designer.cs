namespace pharmacy_management_system
{
    partial class cashierorder
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_AddtoCart = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.button_Cashier_Pay = new System.Windows.Forms.Button();
            this.button_Cashier_Recept = new System.Windows.Forms.Button();
            this.button_cashier_Cancel = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.CPid = new System.Windows.Forms.TextBox();
            this.CPname = new System.Windows.Forms.TextBox();
            this.CPprice = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.CPCategory = new System.Windows.Forms.TextBox();
            this.CPquantity = new System.Windows.Forms.TextBox();
            this.Cbill = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.CPtotalPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(449, 45);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(419, 220);
            this.dataGridView2.TabIndex = 59;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(614, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(169, 29);
            this.label11.TabIndex = 58;
            this.label11.Text = "Order Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 45);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(416, 220);
            this.dataGridView1.TabIndex = 57;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(93, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 29);
            this.label1.TabIndex = 56;
            this.label1.Text = "Avaiable Medicine";
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(128, 699);
            this.button_Clear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(236, 51);
            this.button_Clear.TabIndex = 73;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            // 
            // button_AddtoCart
            // 
            this.button_AddtoCart.Location = new System.Drawing.Point(36, 580);
            this.button_AddtoCart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_AddtoCart.Name = "button_AddtoCart";
            this.button_AddtoCart.Size = new System.Drawing.Size(152, 51);
            this.button_AddtoCart.TabIndex = 72;
            this.button_AddtoCart.Text = "Add to Cart";
            this.button_AddtoCart.UseVisualStyleBackColor = true;
            this.button_AddtoCart.Click += new System.EventHandler(this.button_AddtoCart_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(7, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 29);
            this.label7.TabIndex = 64;
            this.label7.Text = "Medicine ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(41, 512);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 29);
            this.label6.TabIndex = 63;
            this.label6.Text = "Quantity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(59, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 29);
            this.label4.TabIndex = 62;
            this.label4.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(51, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 29);
            this.label3.TabIndex = 61;
            this.label3.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(31, 470);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 29);
            this.label2.TabIndex = 60;
            this.label2.Text = "Category:";
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(211, 580);
            this.Clear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(161, 51);
            this.Clear.TabIndex = 74;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // button_Cashier_Pay
            // 
            this.button_Cashier_Pay.Location = new System.Drawing.Point(576, 554);
            this.button_Cashier_Pay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Cashier_Pay.Name = "button_Cashier_Pay";
            this.button_Cashier_Pay.Size = new System.Drawing.Size(189, 51);
            this.button_Cashier_Pay.TabIndex = 83;
            this.button_Cashier_Pay.Text = "PAY";
            this.button_Cashier_Pay.UseVisualStyleBackColor = true;
            this.button_Cashier_Pay.Click += new System.EventHandler(this.button_Cashier_Pay_Click);
            // 
            // button_Cashier_Recept
            // 
            this.button_Cashier_Recept.Location = new System.Drawing.Point(576, 495);
            this.button_Cashier_Recept.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Cashier_Recept.Name = "button_Cashier_Recept";
            this.button_Cashier_Recept.Size = new System.Drawing.Size(189, 51);
            this.button_Cashier_Recept.TabIndex = 82;
            this.button_Cashier_Recept.Text = "Recept";
            this.button_Cashier_Recept.UseVisualStyleBackColor = true;
            this.button_Cashier_Recept.Click += new System.EventHandler(this.button_Cashier_Recept_Click);
            // 
            // button_cashier_Cancel
            // 
            this.button_cashier_Cancel.Location = new System.Drawing.Point(576, 608);
            this.button_cashier_Cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_cashier_Cancel.Name = "button_cashier_Cancel";
            this.button_cashier_Cancel.Size = new System.Drawing.Size(189, 51);
            this.button_cashier_Cancel.TabIndex = 81;
            this.button_cashier_Cancel.Text = "CANCEL ORDER";
            this.button_cashier_Cancel.UseVisualStyleBackColor = true;
            this.button_cashier_Cancel.Click += new System.EventHandler(this.button_cashier_Cancel_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label19.Location = new System.Drawing.Point(59, 427);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(69, 29);
            this.label19.TabIndex = 84;
            this.label19.Text = "stock";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // CPid
            // 
            this.CPid.Location = new System.Drawing.Point(165, 282);
            this.CPid.Name = "CPid";
            this.CPid.ReadOnly = true;
            this.CPid.Size = new System.Drawing.Size(155, 26);
            this.CPid.TabIndex = 85;
            // 
            // CPname
            // 
            this.CPname.Location = new System.Drawing.Point(165, 327);
            this.CPname.Name = "CPname";
            this.CPname.ReadOnly = true;
            this.CPname.Size = new System.Drawing.Size(155, 26);
            this.CPname.TabIndex = 86;
            // 
            // CPprice
            // 
            this.CPprice.Location = new System.Drawing.Point(165, 376);
            this.CPprice.Name = "CPprice";
            this.CPprice.ReadOnly = true;
            this.CPprice.Size = new System.Drawing.Size(155, 26);
            this.CPprice.TabIndex = 87;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(165, 427);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(155, 26);
            this.textBox4.TabIndex = 88;
            // 
            // CPCategory
            // 
            this.CPCategory.Location = new System.Drawing.Point(165, 470);
            this.CPCategory.Name = "CPCategory";
            this.CPCategory.ReadOnly = true;
            this.CPCategory.Size = new System.Drawing.Size(155, 26);
            this.CPCategory.TabIndex = 90;
            // 
            // CPquantity
            // 
            this.CPquantity.Location = new System.Drawing.Point(165, 516);
            this.CPquantity.Name = "CPquantity";
            this.CPquantity.Size = new System.Drawing.Size(155, 26);
            this.CPquantity.TabIndex = 95;
            this.CPquantity.TextChanged += new System.EventHandler(this.textBox_quantity_TextChanged);
            // 
            // Cbill
            // 
            this.Cbill.FormattingEnabled = true;
            this.Cbill.Items.AddRange(new object[] {
            "complete"});
            this.Cbill.Location = new System.Drawing.Point(678, 451);
            this.Cbill.Name = "Cbill";
            this.Cbill.Size = new System.Drawing.Size(159, 28);
            this.Cbill.TabIndex = 98;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(541, 447);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 29);
            this.label8.TabIndex = 99;
            this.label8.Text = "billstatus:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(528, 327);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(136, 29);
            this.label15.TabIndex = 93;
            this.label15.Text = "Total Price:";
            // 
            // CPtotalPrice
            // 
            this.CPtotalPrice.Location = new System.Drawing.Point(678, 324);
            this.CPtotalPrice.Name = "CPtotalPrice";
            this.CPtotalPrice.ReadOnly = true;
            this.CPtotalPrice.Size = new System.Drawing.Size(159, 26);
            this.CPtotalPrice.TabIndex = 94;
            this.CPtotalPrice.TextChanged += new System.EventHandler(this.textBox_totalPrice_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(566, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 29);
            this.label5.TabIndex = 100;
            this.label5.Text = "amount:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(678, 364);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(159, 26);
            this.textBox3.TabIndex = 101;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(499, 403);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 29);
            this.label9.TabIndex = 102;
            this.label9.Text = "remaining bal:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(678, 407);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(159, 26);
            this.textBox5.TabIndex = 103;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(678, 283);
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Size = new System.Drawing.Size(159, 26);
            this.id.TabIndex = 104;
            this.id.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(563, 283);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 29);
            this.label10.TabIndex = 105;
            this.label10.Text = "orderId";
            this.label10.Visible = false;
            // 
            // cashierorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.id);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Cbill);
            this.Controls.Add(this.CPquantity);
            this.Controls.Add(this.CPtotalPrice);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.CPCategory);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.CPprice);
            this.Controls.Add(this.CPname);
            this.Controls.Add(this.CPid);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.button_Cashier_Pay);
            this.Controls.Add(this.button_Cashier_Recept);
            this.Controls.Add(this.button_cashier_Cancel);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_AddtoCart);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "cashierorder";
            this.Size = new System.Drawing.Size(887, 682);
            this.Load += new System.EventHandler(this.cashierorder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_AddtoCart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button button_Cashier_Pay;
        private System.Windows.Forms.Button button_Cashier_Recept;
        private System.Windows.Forms.Button button_cashier_Cancel;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox CPid;
        private System.Windows.Forms.TextBox CPname;
        private System.Windows.Forms.TextBox CPprice;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox CPCategory;
        private System.Windows.Forms.TextBox CPquantity;
        private System.Windows.Forms.ComboBox Cbill;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox CPtotalPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label10;
    }
}
