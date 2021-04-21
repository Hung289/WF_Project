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
    public partial class frmBillFood : Form
    {
        MovieDataContext mdc = new MovieDataContext();
        public frmBillFood()
        {
            InitializeComponent();
            LoadBillFood();
        }

        private void LoadBillFood()
        {
            var listBillFood = from bf in mdc.bill_foods
                               from a in mdc.accounts
                               where bf.Account_id == a.Name_user
                               select new Models.BillFood
                               {
                                   Id = bf.Id,
                                   DateSale = bf.Date_sale,
                                   NameStaff = a.Name_user
                               };
            dgvListBillFood.DataSource = listBillFood;
        }

        private void btnBillFood_Click(object sender, EventArgs e)
        {
            frmBillFoodViewReport frmBillFoodViewReport = new frmBillFoodViewReport();
            frmBillFoodViewReport.FrmStatus = true;
            frmBillFoodViewReport.ShowDialog();
        }

        private void btnBillFoodDetail_Click(object sender, EventArgs e)
        {
            if(dgvListBillFood.CurrentRow != null)
            {
                var row = dgvListBillFood.CurrentRow;
                int billFoodId = (int)row.Cells[0].Value;
                frmBillFoodViewReport frmBillFoodViewReport = new frmBillFoodViewReport();
                frmBillFoodViewReport.FrmStatus = false;
                frmBillFoodViewReport.BillFoodId = billFoodId;
                frmBillFoodViewReport.ShowDialog();
            }
        }
    }
}
