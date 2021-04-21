
namespace Movie
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmManager = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmStatistical = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVeban = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPhim = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDoanhThu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFood = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportMovieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportBillFoodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslBanvVe = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslFood = new System.Windows.Forms.ToolStripLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.reportSlotShowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmManager,
            this.tsmStatistical,
            this.reportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(919, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmManager
            // 
            this.tsmManager.Image = ((System.Drawing.Image)(resources.GetObject("tsmManager.Image")));
            this.tsmManager.Name = "tsmManager";
            this.tsmManager.Size = new System.Drawing.Size(76, 20);
            this.tsmManager.Text = "Quản lý";
            this.tsmManager.Click += new System.EventHandler(this.tsmManager_Click);
            // 
            // tsmStatistical
            // 
            this.tsmStatistical.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiVeban,
            this.tsmiPhim,
            this.tsmiDoanhThu,
            this.tsmiFood});
            this.tsmStatistical.Image = ((System.Drawing.Image)(resources.GetObject("tsmStatistical.Image")));
            this.tsmStatistical.Name = "tsmStatistical";
            this.tsmStatistical.Size = new System.Drawing.Size(84, 20);
            this.tsmStatistical.Text = "Thống kê";
            this.tsmStatistical.Click += new System.EventHandler(this.tsmStatistical_Click);
            // 
            // tsmiVeban
            // 
            this.tsmiVeban.Name = "tsmiVeban";
            this.tsmiVeban.Size = new System.Drawing.Size(181, 22);
            this.tsmiVeban.Text = "Thống kê vé bán";
            this.tsmiVeban.Click += new System.EventHandler(this.tsmiVeban_Click);
            // 
            // tsmiPhim
            // 
            this.tsmiPhim.Name = "tsmiPhim";
            this.tsmiPhim.Size = new System.Drawing.Size(181, 22);
            this.tsmiPhim.Text = "Thống kê phim";
            this.tsmiPhim.Click += new System.EventHandler(this.tsmiPhim_Click);
            // 
            // tsmiDoanhThu
            // 
            this.tsmiDoanhThu.Name = "tsmiDoanhThu";
            this.tsmiDoanhThu.Size = new System.Drawing.Size(181, 22);
            this.tsmiDoanhThu.Text = "Thống kê doanh thu";
            this.tsmiDoanhThu.Click += new System.EventHandler(this.tsmiDoanhThu_Click);
            // 
            // tsmiFood
            // 
            this.tsmiFood.Name = "tsmiFood";
            this.tsmiFood.Size = new System.Drawing.Size(181, 22);
            this.tsmiFood.Text = "Thống kê đồ ăn";
            this.tsmiFood.Click += new System.EventHandler(this.tsmiFood_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportMovieToolStripMenuItem,
            this.reportBillFoodToolStripMenuItem,
            this.reportSlotShowToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // reportMovieToolStripMenuItem
            // 
            this.reportMovieToolStripMenuItem.Name = "reportMovieToolStripMenuItem";
            this.reportMovieToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reportMovieToolStripMenuItem.Text = "ReportMovie";
            this.reportMovieToolStripMenuItem.Click += new System.EventHandler(this.reportMovieToolStripMenuItem_Click);
            // 
            // reportBillFoodToolStripMenuItem
            // 
            this.reportBillFoodToolStripMenuItem.Name = "reportBillFoodToolStripMenuItem";
            this.reportBillFoodToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reportBillFoodToolStripMenuItem.Text = "ReportBillFood";
            this.reportBillFoodToolStripMenuItem.Click += new System.EventHandler(this.reportBillFoodToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslBanvVe,
            this.toolStripSeparator1,
            this.tslFood});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(919, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tslBanvVe
            // 
            this.tslBanvVe.Image = ((System.Drawing.Image)(resources.GetObject("tslBanvVe.Image")));
            this.tslBanvVe.Name = "tslBanvVe";
            this.tslBanvVe.Size = new System.Drawing.Size(58, 22);
            this.tslBanvVe.Text = "Bán vé";
            this.tslBanvVe.Click += new System.EventHandler(this.tslBanvVe_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tslFood
            // 
            this.tslFood.Image = ((System.Drawing.Image)(resources.GetObject("tslFood.Image")));
            this.tslFood.Name = "tslFood";
            this.tslFood.Size = new System.Drawing.Size(76, 22);
            this.tslFood.Text = "Bán đồ ăn";
            this.tslFood.Click += new System.EventHandler(this.tslFood_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(583, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(586, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // reportSlotShowToolStripMenuItem
            // 
            this.reportSlotShowToolStripMenuItem.Name = "reportSlotShowToolStripMenuItem";
            this.reportSlotShowToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reportSlotShowToolStripMenuItem.Text = "ReportSlotShow";
            this.reportSlotShowToolStripMenuItem.Click += new System.EventHandler(this.reportSlotShowToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 496);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý rạp chiếu phim";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmManager;
        private System.Windows.Forms.ToolStripMenuItem tsmStatistical;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslBanvVe;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiVeban;
        private System.Windows.Forms.ToolStripMenuItem tsmiPhim;
        private System.Windows.Forms.ToolStripMenuItem tsmiDoanhThu;
        private System.Windows.Forms.ToolStripLabel tslFood;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem tsmiFood;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportMovieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportBillFoodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportSlotShowToolStripMenuItem;
    }
}