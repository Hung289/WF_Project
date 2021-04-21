using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie
{
    public partial class frmThongKePhim : Form
    {
        public double TotalPrice { get; set; }
        CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
        public frmThongKePhim()
        {
            InitializeComponent();
            LoadListThongKePhim();
            
            lblTotalPrice.Text = $"Tổng doanh thu: {String.Format(cul, "{0:#,###,###}", TotalPrice)} VNĐ";
            lblTotalPrice.ForeColor = Color.Red;
        }

        MovieDataContext mdc = new MovieDataContext();
        private void LoadListThongKePhim()
        {
            
            var list1 = from m in mdc.movies
                                  from ss in mdc.slot_shows
                                  from t in mdc.ticket_sales
                                  where m.Id == ss.Movie_id && ss.Id == t.Slot_show_id
                                  group new { m, t } by new
                                  {
                                      m.Name,
                                      m.Movie_release_date,
                                  } into g
                                  select new
                                  {
                                      Name = g.Key.Name,
                                      NgayKhoiChieu = g.Key.Movie_release_date,
                                      SoLuongVeBanDuoc = g.Count(),
                                      DoanhThu = (double)g.Sum(x => x.t.Total_price)
                                  };
            var listThongKePhim = from m in mdc.movies
                                  from ss in mdc.slot_shows
                                  from t in mdc.ticket_sales
                                  where m.Id == ss.Movie_id && ss.Id == t.Slot_show_id
                                  group new { m, t } by new
                                  {
                                      m.Name,
                                      m.Movie_release_date,
                                  } into g
                                  select new
                                  {
                                      Name = g.Key.Name,
                                      NgayKhoiChieu = g.Key.Movie_release_date,
                                      SoLuongVeBanDuoc = g.Count(),
                                      DoanhThu = String.Format(cul,"{0:#,###,###}", (double)(g.Sum(x => x.t.Total_price)))
                                  };
            dgvListThongKePhim.DataSource = listThongKePhim;

            foreach (var item in list1)
            {
                TotalPrice += item.DoanhThu;
            }
        }

        private void txtSearchNameMovie_TextChanged(object sender, EventArgs e)
        {
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            var listThongKePhim = from m in mdc.movies
                                  from ss in mdc.slot_shows
                                  from t in mdc.ticket_sales
                                  where m.Id == ss.Movie_id && ss.Id == t.Slot_show_id
                                  && m.Name.Contains(txtSearchNameMovie.Text)
                                  group new { m, t } by new
                                  {
                                      m.Name,
                                      m.Movie_release_date,
                                  } into g
                                  select new
                                  {
                                      Name = g.Key.Name,
                                      NgayKhoiChieu = g.Key.Movie_release_date,
                                      SoLuongVeBanDuoc = g.Count(),
                                      DoanThu = String.Format(cul, "{0:#,###,###}", (double)(g.Sum(x => x.t.Total_price)))
                                  };
            dgvListThongKePhim.DataSource = listThongKePhim;
        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            dtpSearchDate.ValueChanged += changValue;
        }

        private void changValue(object sender, EventArgs e)
        {
            var date = dtpSearchDate.Value.Date;
            var listThongKePhim = from m in mdc.movies
                                  from ss in mdc.slot_shows
                                  from t in mdc.ticket_sales
                                  where m.Id == ss.Movie_id && ss.Id == t.Slot_show_id
                                  && DateTime.Compare(m.Movie_release_date, date)==0
                                  group new { m, t } by new
                                  {
                                      m.Name,
                                      m.Movie_release_date,
                                  } into g
                                  select new
                                  {
                                      Name = g.Key.Name,
                                      NgayKhoiChieu = g.Key.Movie_release_date,
                                      SoLuongVeBanDuoc = g.Count(),
                                      DoanThu = String.Format(cul, "{0:#,###,###}", (double)(g.Sum(x => x.t.Total_price)))
                                  };
            dgvListThongKePhim.DataSource = listThongKePhim;
        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            nudThang.ValueChanged += changThang;
            nudNam.ValueChanged += changThang;
        }

        private void changThang(object sender, EventArgs e)
        {
            int thang = (int)nudThang.Value;
            int nam = (int)nudNam.Value;
            var listThongKePhim = from m in mdc.movies
                                  from ss in mdc.slot_shows
                                  from t in mdc.ticket_sales
                                  where m.Id == ss.Movie_id && ss.Id == t.Slot_show_id
                                  && m.Movie_release_date.Month==thang && m.Movie_release_date.Year == nam
                                  
                                  group new { m, t } by new
                                  {
                                      m.Name,
                                      m.Movie_release_date,
                                  } into g
                                  select new
                                  {
                                      Name = g.Key.Name,
                                      NgayKhoiChieu = g.Key.Movie_release_date,
                                      SoLuongVeBanDuoc = g.Count(),
                                      DoanThu = String.Format(cul, "{0:#,###,###}", (double)(g.Sum(x => x.t.Total_price)))
                                  };
            dgvListThongKePhim.DataSource = listThongKePhim;
        }

        private void btnThongKePhim_Click(object sender, EventArgs e)
        {
            frmViewReport frmViewReport = new frmViewReport();
            frmViewReport.Month = (int)nudThang.Value;
            frmViewReport.Year  = (int)nudNam.Value;
            frmViewReport.NameMovie = txtSearchNameMovie.Text;
            frmViewReport.ShowDialog();
        }
    }
}
