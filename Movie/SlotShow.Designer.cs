
namespace Movie
{
    partial class SlotShow
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
            this.dgvSlotShow = new System.Windows.Forms.DataGridView();
            this.dtpSearch = new System.Windows.Forms.DateTimePicker();
            this.btnSlotShowBC = new System.Windows.Forms.Button();
            this.btnTicket = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSlotShow)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSlotShow
            // 
            this.dgvSlotShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSlotShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSlotShow.Location = new System.Drawing.Point(1, 54);
            this.dgvSlotShow.Name = "dgvSlotShow";
            this.dgvSlotShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSlotShow.Size = new System.Drawing.Size(868, 429);
            this.dgvSlotShow.TabIndex = 0;
            // 
            // dtpSearch
            // 
            this.dtpSearch.CustomFormat = "dd/MM/yyyy";
            this.dtpSearch.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSearch.Location = new System.Drawing.Point(22, 12);
            this.dtpSearch.Name = "dtpSearch";
            this.dtpSearch.Size = new System.Drawing.Size(200, 20);
            this.dtpSearch.TabIndex = 1;
            this.dtpSearch.ValueChanged += new System.EventHandler(this.dtpSearch_ValueChanged);
            // 
            // btnSlotShowBC
            // 
            this.btnSlotShowBC.Location = new System.Drawing.Point(685, 489);
            this.btnSlotShowBC.Name = "btnSlotShowBC";
            this.btnSlotShowBC.Size = new System.Drawing.Size(184, 23);
            this.btnSlotShowBC.TabIndex = 2;
            this.btnSlotShowBC.Text = "Xuất báo cáo theo suất chiếu";
            this.btnSlotShowBC.UseVisualStyleBackColor = true;
            this.btnSlotShowBC.Click += new System.EventHandler(this.btnSlotShowBC_Click);
            // 
            // btnTicket
            // 
            this.btnTicket.Location = new System.Drawing.Point(549, 489);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(130, 23);
            this.btnTicket.TabIndex = 3;
            this.btnTicket.Text = "Chi tiết vé bán";
            this.btnTicket.UseVisualStyleBackColor = true;
            this.btnTicket.Click += new System.EventHandler(this.btnTicket_Click);
            // 
            // SlotShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 518);
            this.Controls.Add(this.btnTicket);
            this.Controls.Add(this.btnSlotShowBC);
            this.Controls.Add(this.dtpSearch);
            this.Controls.Add(this.dgvSlotShow);
            this.Name = "SlotShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SlotShow";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSlotShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSlotShow;
        private System.Windows.Forms.DateTimePicker dtpSearch;
        private System.Windows.Forms.Button btnSlotShowBC;
        private System.Windows.Forms.Button btnTicket;
    }
}