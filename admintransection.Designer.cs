namespace pharmacy_management_system
{
    partial class Admintransection
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
            this.dataGridView_trans = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_trans)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_trans
            // 
            this.dataGridView_trans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_trans.Location = new System.Drawing.Point(17, 85);
            this.dataGridView_trans.Name = "dataGridView_trans";
            this.dataGridView_trans.RowHeadersWidth = 62;
            this.dataGridView_trans.RowTemplate.Height = 28;
            this.dataGridView_trans.Size = new System.Drawing.Size(789, 565);
            this.dataGridView_trans.TabIndex = 4;
            this.dataGridView_trans.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_trans_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "All Customar";
            // 
            // Admintransection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Controls.Add(this.dataGridView_trans);
            this.Controls.Add(this.label1);
            this.Name = "Admintransection";
            this.Size = new System.Drawing.Size(814, 695);
            this.Load += new System.EventHandler(this.Admintransection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_trans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_trans;
        private System.Windows.Forms.Label label1;
    }
}
