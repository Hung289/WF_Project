
namespace Movie
{
    partial class frmGhe
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
            this.flpGhe = new System.Windows.Forms.FlowLayoutPanel();
            this.panScreen = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelCoNguoiNgoi = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDatve = new System.Windows.Forms.Button();
            this.txtPriceChoiceSeat = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpGhe
            // 
            this.flpGhe.AutoScroll = true;
            this.flpGhe.Location = new System.Drawing.Point(350, 64);
            this.flpGhe.Name = "flpGhe";
            this.flpGhe.Size = new System.Drawing.Size(622, 439);
            this.flpGhe.TabIndex = 0;
            // 
            // panScreen
            // 
            this.panScreen.BackColor = System.Drawing.SystemColors.ControlText;
            this.panScreen.Location = new System.Drawing.Point(300, 12);
            this.panScreen.Name = "panScreen";
            this.panScreen.Size = new System.Drawing.Size(672, 33);
            this.panScreen.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPriceChoiceSeat);
            this.panel1.Controls.Add(this.btnDatve);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panelCoNguoiNgoi);
            this.panel1.Location = new System.Drawing.Point(12, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 437);
            this.panel1.TabIndex = 2;
            // 
            // panelCoNguoiNgoi
            // 
            this.panelCoNguoiNgoi.BackColor = System.Drawing.Color.Brown;
            this.panelCoNguoiNgoi.Location = new System.Drawing.Point(17, 24);
            this.panelCoNguoiNgoi.Name = "panelCoNguoiNgoi";
            this.panelCoNguoiNgoi.Size = new System.Drawing.Size(54, 20);
            this.panelCoNguoiNgoi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vip";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(17, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(54, 20);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Có người ngồi";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RosyBrown;
            this.panel3.Location = new System.Drawing.Point(17, 98);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(54, 20);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Thường";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Red;
            this.panel4.Location = new System.Drawing.Point(17, 134);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(54, 20);
            this.panel4.TabIndex = 0;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(87, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Đang chọn";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnDatve
            // 
            this.btnDatve.Location = new System.Drawing.Point(17, 394);
            this.btnDatve.Name = "btnDatve";
            this.btnDatve.Size = new System.Drawing.Size(75, 23);
            this.btnDatve.TabIndex = 2;
            this.btnDatve.Text = "Đặt vé";
            this.btnDatve.UseVisualStyleBackColor = true;
            this.btnDatve.Click += new System.EventHandler(this.btnDatve_Click);
            // 
            // txtPriceChoiceSeat
            // 
            this.txtPriceChoiceSeat.Location = new System.Drawing.Point(108, 397);
            this.txtPriceChoiceSeat.Name = "txtPriceChoiceSeat";
            this.txtPriceChoiceSeat.Size = new System.Drawing.Size(100, 20);
            this.txtPriceChoiceSeat.TabIndex = 3;
            // 
            // frmGhe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 513);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panScreen);
            this.Controls.Add(this.flpGhe);
            this.Name = "frmGhe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ghe";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpGhe;
        private System.Windows.Forms.Panel panScreen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelCoNguoiNgoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnDatve;
        private System.Windows.Forms.TextBox txtPriceChoiceSeat;
    }
}