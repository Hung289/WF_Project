
namespace Movie
{
    partial class frmBillFood
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
            this.dgvListBillFood = new System.Windows.Forms.DataGridView();
            this.btnBillFood = new System.Windows.Forms.Button();
            this.btnBillFoodDetail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBillFood)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListBillFood
            // 
            this.dgvListBillFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListBillFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListBillFood.Location = new System.Drawing.Point(1, 29);
            this.dgvListBillFood.Name = "dgvListBillFood";
            this.dgvListBillFood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListBillFood.Size = new System.Drawing.Size(885, 455);
            this.dgvListBillFood.TabIndex = 0;
            // 
            // btnBillFood
            // 
            this.btnBillFood.Location = new System.Drawing.Point(659, 497);
            this.btnBillFood.Name = "btnBillFood";
            this.btnBillFood.Size = new System.Drawing.Size(216, 23);
            this.btnBillFood.TabIndex = 1;
            this.btnBillFood.Text = "Xuất báo cáo đơn food";
            this.btnBillFood.UseVisualStyleBackColor = true;
            this.btnBillFood.Click += new System.EventHandler(this.btnBillFood_Click);
            // 
            // btnBillFoodDetail
            // 
            this.btnBillFoodDetail.Location = new System.Drawing.Point(478, 497);
            this.btnBillFoodDetail.Name = "btnBillFoodDetail";
            this.btnBillFoodDetail.Size = new System.Drawing.Size(175, 23);
            this.btnBillFoodDetail.TabIndex = 2;
            this.btnBillFoodDetail.Text = "Xuất chi tiết đơn food";
            this.btnBillFoodDetail.UseVisualStyleBackColor = true;
            this.btnBillFoodDetail.Click += new System.EventHandler(this.btnBillFoodDetail_Click);
            // 
            // frmBillFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 532);
            this.Controls.Add(this.btnBillFoodDetail);
            this.Controls.Add(this.btnBillFood);
            this.Controls.Add(this.dgvListBillFood);
            this.Name = "frmBillFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BillFood";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBillFood)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListBillFood;
        private System.Windows.Forms.Button btnBillFood;
        private System.Windows.Forms.Button btnBillFoodDetail;
    }
}