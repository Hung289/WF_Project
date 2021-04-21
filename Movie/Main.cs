using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie
{
    public partial class frmMain : Form
    {
        public string NameUser { get; set; }
        public frmMain()
        {
            
        }

        public frmMain(string nameUser)
        {
            NameUser = nameUser;
            
            InitializeComponent();
            timer1.Enabled = true;
            timer1.Interval = 1000;
            label1.Text ="Chào mừng: " + NameUser + " đã đăng nhập";
        }

        private void tsmManager_Click(object sender, EventArgs e)
        {
            frmManager manager = new frmManager();
            manager.ShowDialog();
        }

        private void tsmSale_Click(object sender, EventArgs e)
        {
            frmGhe ghe = new frmGhe();
            ghe.ShowDialog();
        }

        private void tsmStatistical_Click(object sender, EventArgs e)
        {
            /*frmAddSeat addSeat = new frmAddSeat();
            addSeat.ShowDialog();*/
        }

        private void tslBanvVe_Click(object sender, EventArgs e)
        {
            frmTicketSale frmTicketSale = new frmTicketSale();
            frmTicketSale.NameAccount = NameUser;
            frmTicketSale.ShowDialog();
        }

        private void tsmiVeban_Click(object sender, EventArgs e)
        {
            frmThongKeVeBan frmThongKeVeBan = new frmThongKeVeBan(NameUser);
            frmThongKeVeBan.ShowDialog();
        }

        private void tsmiPhim_Click(object sender, EventArgs e)
        {
            frmThongKePhim frmThongKePhim = new frmThongKePhim();
            frmThongKePhim.ShowDialog();
        }

        private void tslFood_Click(object sender, EventArgs e)
        {
            frmSellFood frmSellFood = new frmSellFood(NameUser);
            frmSellFood.ShowDialog();
        }

        private void tsmiFood_Click(object sender, EventArgs e)
        {
            frmThongKeDoAn frmThongKeDoAn = new frmThongKeDoAn();
            frmThongKeDoAn.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt");
        }

        private void tsmiDoanhThu_Click(object sender, EventArgs e)
        {
            frmThongKeDoanhThu frmThongKeDoanhThu = new frmThongKeDoanhThu();
            frmThongKeDoanhThu.ShowDialog();
        }

        private void reportMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewReport frmViewReport = new frmViewReport();
            frmViewReport.ShowDialog();
        }

        private void reportBillFoodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBillFood frmBillFood = new frmBillFood();
            frmBillFood.ShowDialog();

        }

        private void reportSlotShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SlotShow frmSlotShowViewReport = new SlotShow();
            frmSlotShowViewReport.ShowDialog();
        }
    }
}
