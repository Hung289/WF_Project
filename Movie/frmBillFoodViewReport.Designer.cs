
namespace Movie
{
    partial class frmBillFoodViewReport
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
            this.crvBillFood = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvBillFood
            // 
            this.crvBillFood.ActiveViewIndex = -1;
            this.crvBillFood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvBillFood.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvBillFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvBillFood.Location = new System.Drawing.Point(0, 0);
            this.crvBillFood.Name = "crvBillFood";
            this.crvBillFood.Size = new System.Drawing.Size(838, 503);
            this.crvBillFood.TabIndex = 0;
            // 
            // frmBillFoodViewReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 503);
            this.Controls.Add(this.crvBillFood);
            this.Name = "frmBillFoodViewReport";
            this.Text = "frmBillFoodViewReport";
            this.Load += new System.EventHandler(this.frmBillFoodViewReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvBillFood;
    }
}