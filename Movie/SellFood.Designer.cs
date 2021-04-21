
namespace Movie
{
    partial class frmSellFood
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAddBillDetail = new System.Windows.Forms.Button();
            this.dgvListHoaDon = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvListFood = new System.Windows.Forms.DataGridView();
            this.btnAddFoodDetail = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCateFood = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListHoaDon)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 530);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAddBillDetail);
            this.panel3.Controls.Add(this.dgvListHoaDon);
            this.panel3.Location = new System.Drawing.Point(322, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(565, 523);
            this.panel3.TabIndex = 1;
            // 
            // btnAddBillDetail
            // 
            this.btnAddBillDetail.Location = new System.Drawing.Point(4, 52);
            this.btnAddBillDetail.Name = "btnAddBillDetail";
            this.btnAddBillDetail.Size = new System.Drawing.Size(145, 23);
            this.btnAddBillDetail.TabIndex = 1;
            this.btnAddBillDetail.Text = "Thêm vào hóa đơn";
            this.btnAddBillDetail.UseVisualStyleBackColor = true;
            this.btnAddBillDetail.Click += new System.EventHandler(this.btnAddBillDetail_Click);
            // 
            // dgvListHoaDon
            // 
            this.dgvListHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListHoaDon.Location = new System.Drawing.Point(4, 89);
            this.dgvListHoaDon.Name = "dgvListHoaDon";
            this.dgvListHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListHoaDon.Size = new System.Drawing.Size(555, 431);
            this.dgvListHoaDon.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvListFood);
            this.panel2.Controls.Add(this.btnAddFoodDetail);
            this.panel2.Controls.Add(this.numericUpDown1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cboCateFood);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(312, 523);
            this.panel2.TabIndex = 0;
            // 
            // dgvListFood
            // 
            this.dgvListFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListFood.Location = new System.Drawing.Point(3, 172);
            this.dgvListFood.Name = "dgvListFood";
            this.dgvListFood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListFood.Size = new System.Drawing.Size(306, 313);
            this.dgvListFood.TabIndex = 6;
            this.dgvListFood.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvListFood_MouseClick);
            // 
            // btnAddFoodDetail
            // 
            this.btnAddFoodDetail.Location = new System.Drawing.Point(234, 493);
            this.btnAddFoodDetail.Name = "btnAddFoodDetail";
            this.btnAddFoodDetail.Size = new System.Drawing.Size(75, 23);
            this.btnAddFoodDetail.TabIndex = 5;
            this.btnAddFoodDetail.Text = "Chọn";
            this.btnAddFoodDetail.UseVisualStyleBackColor = true;
            this.btnAddFoodDetail.Click += new System.EventHandler(this.btnAddFoodDetail_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(66, 133);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(232, 20);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số lượng";
            // 
            // cboCateFood
            // 
            this.cboCateFood.FormattingEnabled = true;
            this.cboCateFood.Location = new System.Drawing.Point(11, 89);
            this.cboCateFood.Name = "cboCateFood";
            this.cboCateFood.Size = new System.Drawing.Size(287, 21);
            this.cboCateFood.TabIndex = 2;
            this.cboCateFood.SelectionChangeCommitted += new System.EventHandler(this.cboCateFood_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loại đồ ăn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bán đồ ăn";
            // 
            // frmSellFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 532);
            this.Controls.Add(this.panel1);
            this.Name = "frmSellFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellFood";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListHoaDon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddFoodDetail;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCateFood;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListFood;
        private System.Windows.Forms.DataGridView dgvListHoaDon;
        private System.Windows.Forms.Button btnAddBillDetail;
    }
}