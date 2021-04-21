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
    public partial class frmThongKeDoAn : Form
    {
        MovieDataContext mdc = new MovieDataContext();

        public frmThongKeDoAn()
        {
            InitializeComponent();
            LoadCateFood();
            LoadBillFoodDetail();
        }

        private void LoadCateFood()
        {
            var listCateFood = from cf in mdc.cate_foods
                               select new
                               {
                                   Id = cf.Id,
                                   Name = cf.Name
                               };
            cboCateFood.DataSource = listCateFood;
            cboCateFood.DisplayMember = "Name";
            cboCateFood.ValueMember = "Id";
        }

        private void LoadBillFoodDetail()
        {
            int i = 1;
            var listBillFoodDetail = from bft in mdc.bill_food_details
                                     from fd in mdc.food_details
                                     from f in mdc.foods
                                     from cf in mdc.cate_foods
                                     where bft.Food_detail_id == fd.Id && fd.Foot_id == f.Id
                                     && cf.Id == f.Cate_food_id && cf.Id == 1
                                     group new { f,bft,fd,cf } by new
                                     {
                                         f.Name,
                                         LoaiDoAn = cf.Name 
                                     } into g
                                     select new
                                     {
                                         TenDoAn = g.Key.Name,
                                         LoaiDoAn = g.Key.LoaiDoAn, 
                                         SoLuong = g.Sum(x=>x.bft.Quantity),
                                         DoanhThu = g.Sum(x=>x.bft.Total_price)
                                     };
            dgvListBillFoodDetail.DataSource = listBillFoodDetail;
        }

        private void cboCateFood_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int index = (int)cboCateFood.SelectedValue;
            LoadDataGridView<int>(index);
        }

        private void LoadDataGridView<T>(T param)
        {
            var listBillFoodDetail = from bft in mdc.bill_food_details
                                     from fd in mdc.food_details
                                     from f in mdc.foods
                                     from cf in mdc.cate_foods
                                     where bft.Food_detail_id == fd.Id && fd.Foot_id == f.Id
                                     && cf.Id == f.Cate_food_id && cf.Id.Equals(param)
                                     group new { f, bft, fd, cf } by new
                                     {
                                         f.Name,
                                         LoaiDoAn = cf.Name
                                     } into g
                                     select new
                                     {
                                         TenDoAn = g.Key.Name,
                                         LoaiDoAn = g.Key.LoaiDoAn,
                                         SoLuong = g.Sum(x => x.bft.Quantity),
                                         DoanhThu = g.Sum(x => x.bft.Total_price)
                                     };
            dgvListBillFoodDetail.DataSource = listBillFoodDetail;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dtpDate.ValueChanged += changDate;
        }

        private void changDate(object sender, EventArgs e)
        {
            var dateValue = dtpDate.Value;

            var listBillFoodDetail = from bft in mdc.bill_food_details
                                     from fd in mdc.food_details
                                     from f in mdc.foods
                                     from cf in mdc.cate_foods
                                     from bf in mdc.bill_foods
                                     where bft.Food_detail_id == fd.Id && fd.Foot_id == f.Id
                                     && cf.Id == f.Cate_food_id && bf.Id == bft.Bill_food_id && DateTime.Compare(bf.Date_sale,dateValue)==0
                                     group new { f, bft, fd, cf } by new
                                     {
                                         f.Name,
                                         LoaiDoAn = cf.Name
                                     } into g
                                     select new
                                     {
                                         TenDoAn = g.Key.Name,
                                         LoaiDoAn = g.Key.LoaiDoAn,
                                         SoLuong = g.Sum(x => x.bft.Quantity),
                                         DoanhThu = g.Sum(x => x.bft.Total_price)
                                     };
            dgvListBillFoodDetail.DataSource = listBillFoodDetail;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            nudThang.ValueChanged += changeMonthYear;
            numNamThang.ValueChanged += changeMonthYear;
        }

        private void changeMonthYear(object sender, EventArgs e)
        {
            int thang = (int)nudThang.Value;
            int namThang = (int)numNamThang.Value;
            var listBillFoodDetail = from bft in mdc.bill_food_details
                                     from fd in mdc.food_details
                                     from f in mdc.foods
                                     from cf in mdc.cate_foods
                                     from bf in mdc.bill_foods
                                     where bft.Food_detail_id == fd.Id && fd.Foot_id == f.Id
                                     && cf.Id == f.Cate_food_id && bf.Id == bft.Bill_food_id && bf.Date_sale.Month == thang && bf.Date_sale.Year == namThang
                                     group new { f, bft, fd, cf } by new
                                     {
                                         f.Name,
                                         LoaiDoAn = cf.Name
                                     } into g
                                     select new
                                     {
                                         TenDoAn = g.Key.Name,
                                         LoaiDoAn = g.Key.LoaiDoAn,
                                         SoLuong = g.Sum(x => x.bft.Quantity),
                                         DoanhThu = g.Sum(x => x.bft.Total_price)
                                     };
            dgvListBillFoodDetail.DataSource = listBillFoodDetail;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            nudNam.ValueChanged += changeYear;
        }

        private void changeYear(object sender, EventArgs e)
        {
            int nam = (int)nudNam.Value;
            var listBillFoodDetail = from bft in mdc.bill_food_details
                                     from fd in mdc.food_details
                                     from f in mdc.foods
                                     from cf in mdc.cate_foods
                                     from bf in mdc.bill_foods
                                     where bft.Food_detail_id == fd.Id && fd.Foot_id == f.Id
                                     && cf.Id == f.Cate_food_id && bf.Id == bft.Bill_food_id && bf.Date_sale.Year == nam
                                     group new { f, bft, fd, cf } by new
                                     {
                                         f.Name,
                                         LoaiDoAn = cf.Name
                                     } into g
                                     select new
                                     {
                                         TenDoAn = g.Key.Name,
                                         LoaiDoAn = g.Key.LoaiDoAn,
                                         SoLuong = g.Sum(x => x.bft.Quantity),
                                         DoanhThu = g.Sum(x => x.bft.Total_price)
                                     };
            dgvListBillFoodDetail.DataSource = listBillFoodDetail;
        }
    }
}
