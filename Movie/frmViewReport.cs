using Movie.Reposts;
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
    public partial class frmViewReport : Form
    {
        MovieDataContext mdc = new MovieDataContext();
        CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
        public int Month { get; set; }
        public int Year { get; set; }
        public string NameMovie { get; set; }
        public frmViewReport()
        {
            InitializeComponent();
        }



        private void frmViewReport_Load(object sender, EventArgs e)
        {
            //Khởi tạo mẫu báo cáo
            ThongKeMovie rpt = new ThongKeMovie();
            //Lấy dữ liệu cho báo cáo
            var data = from m in mdc.movies
                       from ss in mdc.slot_shows
                       from t in mdc.ticket_sales
                       where m.Id == ss.Movie_id && ss.Id == t.Slot_show_id
                       && m.Movie_release_date.Month == Month && m.Movie_release_date.Year == Year
                       && m.Name.Contains(NameMovie)
                       group new { m, t } by new
                       {
                           m.Name,
                           m.Movie_release_date,
                       } into g
                       select new Models.ThongKeMovie
                       {
                           Name = g.Key.Name,
                           MovieReleaseDate = g.Key.Movie_release_date,
                           SoLuongVeBanDuoc = g.Count(),
                           TotalPrice = (double)g.Sum(x => x.t.Total_price)
                       };
            //đưa dữ liệu vào báo cáo
            rpt.SetDataSource(data);
            //đưa báo cáo vào view để xem trước
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Show();
        }
    }
}
