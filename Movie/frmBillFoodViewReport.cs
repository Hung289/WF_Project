using Movie.Models;
using Movie.Reposts;
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
    public partial class frmBillFoodViewReport : Form
    {
        MovieDataContext mdc = new MovieDataContext();
        public bool FrmStatus { get; set; }
        public int BillFoodId { get; set; }
        public frmBillFoodViewReport()
        {
            InitializeComponent();
        }

        private void frmBillFoodViewReport_Load(object sender, EventArgs e)
        {
            if(FrmStatus)
            {
                    Reposts.BillFood rpt = new Reposts.BillFood();
                    var data =  from bf in mdc.bill_foods
                                from a in mdc.accounts
                                where bf.Account_id == a.Name_user
                                select new Models.BillFood
                                {
                                    Id = bf.Id,
                                    DateSale = bf.Date_sale,
                                    NameStaff = a.Name_user
                                };
                    rpt.SetDataSource(data);
                    crvBillFood.ReportSource = rpt;
                    crvBillFood.Show();
            }
            else
            {
                RptBillFoodDetail rpt = new RptBillFoodDetail();
                var data = from bft in mdc.bill_food_details
                           from bf in mdc.bill_foods
                           from fd in mdc.food_details
                           from f in mdc.foods
                           from cf in mdc.cate_foods
                           from a in mdc.accounts
                           from s in mdc.size_foods
                           where bft.Food_detail_id == fd.Id && fd.Foot_id == f.Id
                           && cf.Id == f.Cate_food_id && bf.Id == bft.Bill_food_id
                           && a.Name_user.Equals(bf.Account_id) && s.Id == fd.Size_food_id
                           && bf.Id == BillFoodId
                           select new BillFoodDetail
                           {
                               Id = bf.Id,
                               DateSale = bf.Date_sale,
                               NameStaff = a.Name_user,
                               NameFood = f.Name,
                               NameSize = s.Name,
                               Quantity = (int)bft.Quantity,
                               TotalPrice = (double)bft.Total_price
                           };

                rpt.SetDataSource(data);
                crvBillFood.ReportSource = rpt;
                crvBillFood.Show();
            }
        }
    }
}
