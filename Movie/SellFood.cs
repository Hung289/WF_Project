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
    public partial class frmSellFood : Form
    {
        MovieDataContext mdc = new MovieDataContext();
        public string UserName { get; set; }
        List<CartFood> listCartFood = new List<CartFood>();
        public frmSellFood()
        {
            
        }

        public frmSellFood(string userName)
        {
            UserName = userName;
            InitializeComponent();
            LoadCateFood();
            LoadListFoodDetailByCate();
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

        private void LoadListFoodDetailByCate()
        {
            var ListFood = from f in mdc.foods
                           from fd in mdc.food_details
                           from fs in mdc.size_foods
                           where fd.Size_food_id == fs.Id && f.Id == fd.Foot_id
                           && f.Cate_food_id == 1
                           select new
                           {
   
                               MaDoAn = fd.Id,
                               TenDoAn = f.Name,
                               KichCo = fs.Name,
                               DonGia = fd.Price,
                               KichCoId = fs.Id
                           };
            dgvListFood.DataSource = ListFood;
        }

        private void cboCateFood_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int idCateFood = (int)cboCateFood.SelectedValue;

            var ListFood = from f in mdc.foods
                           from fd in mdc.food_details
                           from fs in mdc.size_foods
                           where fd.Size_food_id == fs.Id && f.Id == fd.Foot_id
                           && f.Cate_food_id == idCateFood
                           select new
                           {
                               MaDoAn = fd.Id,
                               TenDoAn = f.Name,
                               KichCo = fs.Name,
                               DonGia = fd.Price,
                               KichCoId = fs.Id
                           };
            dgvListFood.DataSource = ListFood;
        }

        private void btnAddFoodDetail_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvListFood_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                if(MessageBox.Show("Bạn có muốn thêm đồ ăn ko?","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var row = dgvListFood.CurrentRow;
                    int idCateFood = (int)cboCateFood.SelectedValue;
                    int quantity = (int)numericUpDown1.Value;
                    int MaDoAn = (int)row.Cells[0].Value;
                    string TenDoAn = (string)row.Cells[1].Value;
                    string KichCo = ((int)row.Cells[4].Value == 1) ? "Lớn" : (((int)row.Cells[4].Value == 2) ? "Trung bình" : "Nhỏ");
                    double Gia = (double)row.Cells[3].Value;

                    dgvListHoaDon.Rows.Clear();

                    var check = listCartFood.Where(x => x.TenDoAn.Equals(TenDoAn) && x.KichCo.Equals(KichCo));
                    if(check.Count()!=0)
                    {
                        check.FirstOrDefault().Quantity = quantity;
                    }
                    else
                    {
                        listCartFood.Add(new CartFood() { IdCateFood = idCateFood, MaDoAn = MaDoAn, TenDoAn = TenDoAn, KichCo = KichCo, Quantity = quantity, Price = Gia, TotalPrice = quantity * Gia });
                    }
                    dgvListHoaDon.ColumnCount = 7;
                    dgvListHoaDon.Columns[0].Name = "Mã đồ ăn";
                    dgvListHoaDon.Columns[1].Name = "Tên đồ ăn";
                    dgvListHoaDon.Columns[2].Name = "Kích cỡ";
                    dgvListHoaDon.Columns[3].Name = "Số lượng";
                    dgvListHoaDon.Columns[4].Name = "Giá";
                    dgvListHoaDon.Columns[5].Name = "Tổng giá";
                    dgvListHoaDon.Columns[6].Name = "Mã danh mục";
                    foreach (var item in listCartFood)
                    {
                        object[] m = new object[] { item.MaDoAn,item.TenDoAn,item.KichCo,item.Quantity,item.Price,item.TotalPrice,item.IdCateFood};
                        dgvListHoaDon.Rows.Add(m);
                    }
                   
                }
            }
        }

        private void btnAddBillDetail_Click(object sender, EventArgs e)
        {
            

            var bill = new bill_food();
            bill.Account_id = UserName;
            bill.Date_sale = DateTime.Now.Date;
            mdc.bill_foods.InsertOnSubmit(bill);
            mdc.SubmitChanges();

            foreach (var item in listCartFood)
            {
                var billDetail = new bill_food_detail();
                billDetail.Quantity = item.Quantity;
                billDetail.Total_price = item.TotalPrice;
                billDetail.Bill_food_id = bill.Id;
                billDetail.Food_detail_id = item.MaDoAn;
                mdc.bill_food_details.InsertOnSubmit(billDetail);
                mdc.SubmitChanges();
                
            }
            MessageBox.Show("Mua đồ ăn thành công", "Thông báo");

        }
    }
}
