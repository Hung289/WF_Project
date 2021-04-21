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
    public partial class frmAddFood : Form
    {
        MovieDataContext mdc = new MovieDataContext();
        public int IdFood { get; set; }
        bool edit = false;
        public frmAddFood()
        {
            
        }

        public frmAddFood(int idFood)
        {
            InitializeComponent();
            IdFood = idFood;
            LoadCateFood();
            LoadStatus();
            if (IdFood == 0)
            {
                edit = false;
            }
            else
            {
                var food = mdc.foods.FirstOrDefault(x => x.Id == IdFood);
                txtNameFood.Text = mdc.foods.FirstOrDefault(x => x.Id == IdFood).Name;
                cboCateFood.SelectedValue = food.Cate_food_id;
                cboStatusFood.SelectedIndex = (int)food.Status;
                edit = true;
            }
            
            
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
        private void LoadStatus()
        {
            List<string> listStatus = new List<string>() { "Hiện", "Ẩn" };
            cboStatusFood.DataSource = listStatus;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(edit == false)
            {
                var IsCheck = mdc.foods.FirstOrDefault(x => x.Name == txtNameFood.Text);
                if(IsCheck == null)
                {
                    var food = new food();
                    food.Name = txtNameFood.Text;
                    food.Cate_food_id = (int?)cboCateFood.SelectedValue;
                    food.Status = (int?)cboStatusFood.SelectedIndex;
                    mdc.foods.InsertOnSubmit(food);
                    mdc.SubmitChanges();
                    MessageBox.Show("Thêm mới thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Tên đồ ăn đã tồn tại", "Thông báo");
                }
            }
            else
            {
                var food = mdc.foods.FirstOrDefault(x => x.Id == IdFood);
                food.Name = txtNameFood.Text;
                food.Cate_food_id = (int?)cboCateFood.SelectedValue;
                food.Status = cboStatusFood.SelectedIndex;
                mdc.SubmitChanges();
                MessageBox.Show("Cập nhật thành công", "Thông báo");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
