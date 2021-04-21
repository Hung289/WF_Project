
namespace Movie
{
    partial class frmThongKePhim
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
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.dgvListThongKePhim = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbTime = new System.Windows.Forms.GroupBox();
            this.nudNam = new System.Windows.Forms.NumericUpDown();
            this.nudThang = new System.Windows.Forms.NumericUpDown();
            this.dtpSearchDate = new System.Windows.Forms.DateTimePicker();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSearchNameMovie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThongKePhim = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListThongKePhim)).BeginInit();
            this.panel2.SuspendLayout();
            this.gbTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 527);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblTotalPrice);
            this.panel3.Controls.Add(this.dgvListThongKePhim);
            this.panel3.Location = new System.Drawing.Point(285, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(654, 521);
            this.panel3.TabIndex = 1;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(426, 17);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(0, 18);
            this.lblTotalPrice.TabIndex = 1;
            // 
            // dgvListThongKePhim
            // 
            this.dgvListThongKePhim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListThongKePhim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListThongKePhim.Location = new System.Drawing.Point(4, 53);
            this.dgvListThongKePhim.Name = "dgvListThongKePhim";
            this.dgvListThongKePhim.Size = new System.Drawing.Size(647, 465);
            this.dgvListThongKePhim.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnThongKePhim);
            this.panel2.Controls.Add(this.gbTime);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(276, 521);
            this.panel2.TabIndex = 0;
            // 
            // gbTime
            // 
            this.gbTime.Controls.Add(this.nudNam);
            this.gbTime.Controls.Add(this.nudThang);
            this.gbTime.Controls.Add(this.dtpSearchDate);
            this.gbTime.Controls.Add(this.rb2);
            this.gbTime.Controls.Add(this.rb1);
            this.gbTime.Location = new System.Drawing.Point(6, 116);
            this.gbTime.Name = "gbTime";
            this.gbTime.Size = new System.Drawing.Size(260, 181);
            this.gbTime.TabIndex = 2;
            this.gbTime.TabStop = false;
            this.gbTime.Text = "Thời Gian";
            // 
            // nudNam
            // 
            this.nudNam.Location = new System.Drawing.Point(130, 137);
            this.nudNam.Maximum = new decimal(new int[] {
            2030,
            0,
            0,
            0});
            this.nudNam.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudNam.Name = "nudNam";
            this.nudNam.Size = new System.Drawing.Size(117, 20);
            this.nudNam.TabIndex = 2;
            this.nudNam.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // nudThang
            // 
            this.nudThang.Location = new System.Drawing.Point(13, 137);
            this.nudThang.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudThang.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudThang.Name = "nudThang";
            this.nudThang.Size = new System.Drawing.Size(111, 20);
            this.nudThang.TabIndex = 2;
            this.nudThang.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dtpSearchDate
            // 
            this.dtpSearchDate.CustomFormat = "dd/MM/yyyy";
            this.dtpSearchDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSearchDate.Location = new System.Drawing.Point(13, 55);
            this.dtpSearchDate.Name = "dtpSearchDate";
            this.dtpSearchDate.Size = new System.Drawing.Size(234, 20);
            this.dtpSearchDate.TabIndex = 1;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(13, 114);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(80, 17);
            this.rb2.TabIndex = 0;
            this.rb2.TabStop = true;
            this.rb2.Text = "Theo tháng";
            this.rb2.UseVisualStyleBackColor = true;
            this.rb2.CheckedChanged += new System.EventHandler(this.rb2_CheckedChanged);
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(13, 32);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(76, 17);
            this.rb1.TabIndex = 0;
            this.rb1.TabStop = true;
            this.rb1.Text = "Theo ngày";
            this.rb1.UseVisualStyleBackColor = true;
            this.rb1.CheckedChanged += new System.EventHandler(this.rb1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSearchNameMovie);
            this.groupBox1.Location = new System.Drawing.Point(3, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 46);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tên phim";
            // 
            // txtSearchNameMovie
            // 
            this.txtSearchNameMovie.Location = new System.Drawing.Point(3, 19);
            this.txtSearchNameMovie.Name = "txtSearchNameMovie";
            this.txtSearchNameMovie.Size = new System.Drawing.Size(260, 20);
            this.txtSearchNameMovie.TabIndex = 0;
            this.txtSearchNameMovie.TextChanged += new System.EventHandler(this.txtSearchNameMovie_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bộ lọc thống kê";
            // 
            // btnThongKePhim
            // 
            this.btnThongKePhim.Location = new System.Drawing.Point(54, 441);
            this.btnThongKePhim.Name = "btnThongKePhim";
            this.btnThongKePhim.Size = new System.Drawing.Size(169, 23);
            this.btnThongKePhim.TabIndex = 3;
            this.btnThongKePhim.Text = "Xem Thống kê phim";
            this.btnThongKePhim.UseVisualStyleBackColor = true;
            this.btnThongKePhim.Click += new System.EventHandler(this.btnThongKePhim_Click);
            // 
            // frmThongKePhim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 532);
            this.Controls.Add(this.panel1);
            this.Name = "frmThongKePhim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThongKePhim";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListThongKePhim)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbTime.ResumeLayout(false);
            this.gbTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListThongKePhim;
        private System.Windows.Forms.TextBox txtSearchNameMovie;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.GroupBox gbTime;
        private System.Windows.Forms.NumericUpDown nudNam;
        private System.Windows.Forms.NumericUpDown nudThang;
        private System.Windows.Forms.DateTimePicker dtpSearchDate;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.Button btnThongKePhim;
    }
}