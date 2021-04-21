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
    public partial class frmAddSize : Form
    {
        MovieDataContext mdc = new MovieDataContext();
        public int IdFood{ get; set; }
        public int IdFoodDetail { get; set; }
        bool edit = false;
        public frmAddSize()
        {
            
        }

        public frmAddSize(int idFood, int idFoodDetail)
        {
            InitializeComponent();
            LoadSizeFood();
            LoadStatusFood();
            IdFood = idFood;
            IdFoodDetail = idFoodDetail;
            var food = mdc.foods.FirstOrDefault(x => x.Id == IdFood);
            txtNameFood.Text = food.Name;
            if(IdFoodDetail == 0)
            {
                edit = false;
            }
            else
            {
                var foodDateil = mdc.food_details.FirstOrDefault(x => x.Id == IdFoodDetail);
                edit = true;
                txtPriceFood.Text = foodDateil.Price.ToString();
                cboSizeFood.SelectedValue = foodDateil.Size_food_id;
                cboStatus.SelectedIndex = (int)foodDateil.Status;
            }
        }

        private void LoadSizeFood()
        {
            var listSizeFood = from sf in mdc.size_foods
                               select new
                               {
                                   Id = sf.Id,
                                   Name = sf.Name
                               };
            cboSizeFood.DataSource = listSizeFood;
            cboSizeFood.DisplayMember = "Name";
            cboSizeFood.ValueMember = "Id";

        }

        private void LoadStatusFood()
        {
            List<string> listStatus = new List<string>() { "Đang được bán", "Chưa được bán" };
            cboStatus.DataSource = listStatus;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
                var foodDetail = mdc.food_details.FirstOrDefault(x => x.Foot_id == IdFood);
            
            if(edit)
            {
                foodDetail.Price =  Convert.ToDouble(txtPriceFood.Text);
                foodDetail.Status = cboStatus.SelectedIndex;
                mdc.SubmitChanges();
                MessageBox.Show("Cập nhật thành công", "Thông báo");
            }
            else
            {
                if(foodDetail != null && foodDetail.Size_food_id == (int?)cboSizeFood.SelectedValue)
                {
                    MessageBox.Show("Size đã tồn tại", "Thông báo");
                    
                }
                else
                {
                    var footDetail = new food_detail();
                    footDetail.Price = Convert.ToDouble(txtPriceFood.Text);
                    footDetail.Status = cboStatus.SelectedIndex;
                    footDetail.Size_food_id = (int?)cboSizeFood.SelectedValue;
                    footDetail.Foot_id = IdFood;
                    mdc.food_details.InsertOnSubmit(footDetail);
                    mdc.SubmitChanges();
                    MessageBox.Show("Thêm mới thành công", "Thông báo");
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
