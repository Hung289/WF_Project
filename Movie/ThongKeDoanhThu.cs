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
    public partial class frmThongKeDoanhThu : Form
    {
        MovieDataContext mdc = new MovieDataContext();
        List<TKDoanhThu> lst = new List<TKDoanhThu>();
        public frmThongKeDoanhThu()
        {
            InitializeComponent();
        }

        private void LoadListDoanhthu()
        {
            for (int i = 1; i <= 12; i++)
            {
                TKDoanhThu tKDoanhThu = new TKDoanhThu();
                
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            nudYear.ValueChanged += changeWithYear;
            
            
        }

        private void changeWithYear(object sender, EventArgs e)
        {
            int year = (int)nudYear.Value;
            double totalFood = 0;
            double totalTicket = 0;
            double totalAll = 0;
            
            for (int i = 1; i <= 12; i++)
            {
                var listFood = mdc.p_tkFoodbyYear(year).ToList();
                var m = listFood.Where(x => x.Month == i).FirstOrDefault();
                var listTicket = mdc.p_tkTicketByYear(year).ToList();
                var n = listTicket.Where(x => x.Month == i).FirstOrDefault();
                if(m != null)
                {
                    totalFood = (double)m.Total_price;
                }
                if(n!= null)
                {
                    totalTicket = (double)n.totalPrice;
                }
                totalAll = totalFood + totalTicket;
                lst.Add(new TKDoanhThu() { Thang = i + "-" + year, TotalFood = totalFood, TotalTicket = totalTicket, TotalAll = totalAll });
                totalFood = 0;
                totalTicket = 0;
            }

            BindingSource bs = new BindingSource();
            bs.DataSource = typeof(TKDoanhThu);
            foreach (var item in lst)
            {
                bs.Add(item);
            }
            lst.Clear();
            dgvListThongKeDoanhSo.DataSource = bs;
        }
    }
}
