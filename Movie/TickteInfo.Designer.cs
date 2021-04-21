
namespace Movie
{
    partial class TickteInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddTicket = new System.Windows.Forms.Button();
            this.txtPhongChieu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDinhDang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGioChieu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenphim = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNgayChieu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaSuatChieu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvListTicketInfo = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTicketInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin vé bán. Vui lòng kiểm tra trước khi in";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddTicket);
            this.panel1.Controls.Add(this.txtPhongChieu);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtDinhDang);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtGioChieu);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtTenphim);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtNgayChieu);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtMaSuatChieu);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 486);
            this.panel1.TabIndex = 1;
            // 
            // btnAddTicket
            // 
            this.btnAddTicket.Location = new System.Drawing.Point(22, 410);
            this.btnAddTicket.Name = "btnAddTicket";
            this.btnAddTicket.Size = new System.Drawing.Size(75, 23);
            this.btnAddTicket.TabIndex = 3;
            this.btnAddTicket.Text = "Thêm Vé";
            this.btnAddTicket.UseVisualStyleBackColor = true;
            this.btnAddTicket.Click += new System.EventHandler(this.btnAddTicket_Click);
            // 
            // txtPhongChieu
            // 
            this.txtPhongChieu.Location = new System.Drawing.Point(99, 250);
            this.txtPhongChieu.Name = "txtPhongChieu";
            this.txtPhongChieu.Size = new System.Drawing.Size(178, 20);
            this.txtPhongChieu.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Phòng chiếu";
            // 
            // txtDinhDang
            // 
            this.txtDinhDang.Location = new System.Drawing.Point(99, 209);
            this.txtDinhDang.Name = "txtDinhDang";
            this.txtDinhDang.Size = new System.Drawing.Size(178, 20);
            this.txtDinhDang.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Định dạng";
            // 
            // txtGioChieu
            // 
            this.txtGioChieu.Location = new System.Drawing.Point(99, 166);
            this.txtGioChieu.Name = "txtGioChieu";
            this.txtGioChieu.Size = new System.Drawing.Size(178, 20);
            this.txtGioChieu.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Giờ chiếu";
            // 
            // txtTenphim
            // 
            this.txtTenphim.Location = new System.Drawing.Point(99, 89);
            this.txtTenphim.Name = "txtTenphim";
            this.txtTenphim.Size = new System.Drawing.Size(178, 20);
            this.txtTenphim.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tên phim";
            // 
            // txtNgayChieu
            // 
            this.txtNgayChieu.Location = new System.Drawing.Point(99, 127);
            this.txtNgayChieu.Name = "txtNgayChieu";
            this.txtNgayChieu.Size = new System.Drawing.Size(178, 20);
            this.txtNgayChieu.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngày chiếu";
            // 
            // txtMaSuatChieu
            // 
            this.txtMaSuatChieu.Location = new System.Drawing.Point(99, 52);
            this.txtMaSuatChieu.Name = "txtMaSuatChieu";
            this.txtMaSuatChieu.Size = new System.Drawing.Size(178, 20);
            this.txtMaSuatChieu.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã suất chiếu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thông tin suất chiếu";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTotalPrice);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.dgvListTicketInfo);
            this.panel2.Location = new System.Drawing.Point(300, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(609, 486);
            this.panel2.TabIndex = 2;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(456, 446);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(0, 20);
            this.lblTotalPrice.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(391, 451);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Tổng cộng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Thông tin ghế ngồi";
            // 
            // dgvListTicketInfo
            // 
            this.dgvListTicketInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListTicketInfo.Location = new System.Drawing.Point(3, 55);
            this.dgvListTicketInfo.Name = "dgvListTicketInfo";
            this.dgvListTicketInfo.Size = new System.Drawing.Size(603, 379);
            this.dgvListTicketInfo.TabIndex = 0;
            // 
            // TickteInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 529);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "TickteInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TickteInfo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTicketInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPhongChieu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDinhDang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGioChieu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenphim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNgayChieu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaSuatChieu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvListTicketInfo;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAddTicket;
    }
}