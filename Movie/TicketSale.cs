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
    public partial class frmTicketSale : Form
    {
        public string NameAccount { get; set; }
        public frmTicketSale()
        {
            InitializeComponent();
            LoadListMovieShow();
        }

        MovieDataContext mdc = new MovieDataContext();

        private void LoadListMovieShow()
        {
            var listMovie = from m in mdc.movies
                            from cm in mdc.category_movies
                            where m.Category_movie_id == cm.Id && m.Status == 0
                            select new
                            {
                                Id = m.Id,
                                MaPhim = cm.Name,
                                TenPhim = m.Name
                            };
            dgvListMovieShow.DataSource = listMovie;
        }

        private void LoadListSuatChieu(int id)
        {
            var now = (DateTime.Now);
            var lstSuatChieu = from m in mdc.movies
                               join sc in mdc.slot_shows
                               on m.Id equals sc.Movie_id
                               join cr in mdc.cinema_rooms
                               on sc.Cinema_room_id equals cr.Id
                               where sc.Movie_id == id
                               select new
                               {
                                   MaSuatChieu = sc.Id,
                                   NgayChieu = sc.Day_show,
                                   GioChieu = sc.Start_time ,
                                   KetThuc = sc.End_time,
                                   PhongChieu = cr.Name,
                                   TrangThai = 
                                   (sc.Start_time <= now.TimeOfDay && sc.End_time >= now.TimeOfDay && 
                                   DateTime.Compare(sc.Day_show,now.Date)==0 ) ? "Đang chiếu" 
                                   : ((((sc.Start_time >= now.TimeOfDay && sc.End_time >= now.TimeOfDay) && sc.Day_show > now.Date) 
                                   || ((sc.Start_time <= now.TimeOfDay && sc.End_time <= now.TimeOfDay) && sc.Day_show > now.Date) 
                                   || sc.Day_show > now.Date 
                                   || (sc.Start_time > now.TimeOfDay && sc.End_time > now.TimeOfDay && DateTime.Compare(sc.Day_show, now.Date) == 0)
                                   ? "Sắp chiếu" : "Đã chiếu"))
                               };
            dgvListSuatChieu.DataSource = lstSuatChieu;
        }

        private void dgvListMovieShow_Click(object sender, EventArgs e)
        {
            if(dgvListMovieShow.CurrentRow != null)
            {
                var row = dgvListMovieShow.CurrentRow;
                var id = (int)row.Cells[0].Value;
                LoadListSuatChieu(id);
            }
        }

        private void btnChoiceSeat_Click(object sender, EventArgs e)
        {
            if(dgvListSuatChieu.CurrentRow != null)
            {
                var row = dgvListSuatChieu.CurrentRow;
                string trangthai = row.Cells[5].Value.ToString();
                if(trangthai == "Sắp chiếu")
                {
                    int IdMovie = (int)dgvListMovieShow.CurrentRow.Cells[0].Value;
                    int IdSuatChieu = (int)dgvListSuatChieu.CurrentRow.Cells[0].Value;
                    frmGhe chonghe = new frmGhe(IdMovie, IdSuatChieu);
                    chonghe.NameUser = NameAccount;
                    chonghe.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Phải chọn phim có trạng thái sắp chiếu", "Thông báo");
                }
            }
        }
    }
}
