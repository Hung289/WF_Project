
namespace Movie
{
    partial class frmAddSeat
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
            this.cboRoom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudRow = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudCol = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cboAddRow = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboAddCol = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboCateSeat = new System.Windows.Forms.ComboBox();
            this.dgvSeat = new System.Windows.Forms.DataGridView();
            this.btnAddSeat = new System.Windows.Forms.Button();
            this.btnEditSeat = new System.Windows.Forms.Button();
            this.flpAddSeat = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.nudRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeat)).BeginInit();
            this.SuspendLayout();
            // 
            // cboRoom
            // 
            this.cboRoom.FormattingEnabled = true;
            this.cboRoom.Location = new System.Drawing.Point(90, 33);
            this.cboRoom.Name = "cboRoom";
            this.cboRoom.Size = new System.Drawing.Size(121, 21);
            this.cboRoom.TabIndex = 0;
            this.cboRoom.SelectedIndexChanged += new System.EventHandler(this.cboRoom_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hàng";
            // 
            // nudRow
            // 
            this.nudRow.Location = new System.Drawing.Point(328, 40);
            this.nudRow.Name = "nudRow";
            this.nudRow.ReadOnly = true;
            this.nudRow.Size = new System.Drawing.Size(120, 20);
            this.nudRow.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(526, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cột";
            // 
            // nudCol
            // 
            this.nudCol.Location = new System.Drawing.Point(574, 40);
            this.nudCol.Name = "nudCol";
            this.nudCol.ReadOnly = true;
            this.nudCol.Size = new System.Drawing.Size(120, 20);
            this.nudCol.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "AddRow";
            // 
            // cboAddRow
            // 
            this.cboAddRow.FormattingEnabled = true;
            this.cboAddRow.Location = new System.Drawing.Point(90, 92);
            this.cboAddRow.Name = "cboAddRow";
            this.cboAddRow.Size = new System.Drawing.Size(121, 21);
            this.cboAddRow.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "AddCol";
            // 
            // cboAddCol
            // 
            this.cboAddCol.FormattingEnabled = true;
            this.cboAddCol.Location = new System.Drawing.Point(90, 135);
            this.cboAddCol.Name = "cboAddCol";
            this.cboAddCol.Size = new System.Drawing.Size(121, 21);
            this.cboAddCol.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Status";
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(90, 179);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(121, 21);
            this.cboStatus.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Loại Ghế";
            // 
            // cboCateSeat
            // 
            this.cboCateSeat.FormattingEnabled = true;
            this.cboCateSeat.Location = new System.Drawing.Point(90, 227);
            this.cboCateSeat.Name = "cboCateSeat";
            this.cboCateSeat.Size = new System.Drawing.Size(121, 21);
            this.cboCateSeat.TabIndex = 5;
            // 
            // dgvSeat
            // 
            this.dgvSeat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeat.Location = new System.Drawing.Point(236, 92);
            this.dgvSeat.Name = "dgvSeat";
            this.dgvSeat.Size = new System.Drawing.Size(552, 346);
            this.dgvSeat.TabIndex = 6;
            // 
            // btnAddSeat
            // 
            this.btnAddSeat.Location = new System.Drawing.Point(65, 293);
            this.btnAddSeat.Name = "btnAddSeat";
            this.btnAddSeat.Size = new System.Drawing.Size(75, 23);
            this.btnAddSeat.TabIndex = 7;
            this.btnAddSeat.Text = "Thêm ";
            this.btnAddSeat.UseVisualStyleBackColor = true;
            this.btnAddSeat.Click += new System.EventHandler(this.btnAddSeat_Click);
            // 
            // btnEditSeat
            // 
            this.btnEditSeat.Location = new System.Drawing.Point(146, 293);
            this.btnEditSeat.Name = "btnEditSeat";
            this.btnEditSeat.Size = new System.Drawing.Size(75, 23);
            this.btnEditSeat.TabIndex = 7;
            this.btnEditSeat.Text = "Sửa";
            this.btnEditSeat.UseVisualStyleBackColor = true;
            // 
            // flpAddSeat
            // 
            this.flpAddSeat.AutoScroll = true;
            this.flpAddSeat.Location = new System.Drawing.Point(20, 549);
            this.flpAddSeat.Name = "flpAddSeat";
            this.flpAddSeat.Size = new System.Drawing.Size(723, 194);
            this.flpAddSeat.TabIndex = 8;
            // 
            // frmAddSeat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 749);
            this.Controls.Add(this.flpAddSeat);
            this.Controls.Add(this.btnEditSeat);
            this.Controls.Add(this.btnAddSeat);
            this.Controls.Add(this.dgvSeat);
            this.Controls.Add(this.cboCateSeat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboAddCol);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboAddRow);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudCol);
            this.Controls.Add(this.nudRow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboRoom);
            this.Name = "frmAddSeat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddSeat";
            ((System.ComponentModel.ISupportInitialize)(this.nudRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboRoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudRow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudCol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboAddRow;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboAddCol;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboCateSeat;
        private System.Windows.Forms.DataGridView dgvSeat;
        private System.Windows.Forms.Button btnAddSeat;
        private System.Windows.Forms.Button btnEditSeat;
        private System.Windows.Forms.FlowLayoutPanel flpAddSeat;
    }
}