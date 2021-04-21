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
    public partial class TickteInfo : Form
    {
        public List<GheNgoi> lstGheNgoi;
        public int idMoview;
        public int idSuatChieu;
        public string NameUser { get; set; }

        public int IdMoview { get => idMoview; set => idMoview = value; }
        public int IdSuatChieu { get => idSuatChieu; set => idSuatChieu = value; }

        MovieDataContext mdc = new MovieDataContext();
        public TickteInfo()
        {
            
        }

        public TickteInfo(int idMoview, int idSuatChieu, List<GheNgoi> lstghengoi)
        {
            InitializeComponent();
            IdMoview = idMoview;
            IdSuatChieu = idSuatChieu;
            lstGheNgoi = lstghengoi;
            LoadDataTextbox();
            LoadInfoSeat();
        }

        private void LoadDataTextbox()
        {
            var movie = mdc.movies.FirstOrDefault(x => x.Id == IdMoview);
            var suatchieu = mdc.slot_shows.FirstOrDefault(x => x.Id == IdSuatChieu);
            var dinhdang = mdc.format_movies.FirstOrDefault(x => x.Id == suatchieu.Format_movie_id);
            var phongchieu = mdc.cinema_rooms.FirstOrDefault(x => x.Id == suatchieu.Cinema_room_id);
            txtMaSuatChieu.Text = IdSuatChieu.ToString();
            txtTenphim.Text = movie.Name;
            txtNgayChieu.Text = suatchieu.Day_show.ToString();
            txtGioChieu.Text = suatchieu.Start_time.ToString() + " - " + suatchieu.End_time.ToString();
            txtDinhDang.Text = dinhdang.Name;
            txtPhongChieu.Text = phongchieu.Name;
            double totalPrice = 0;
            foreach (var item in lstGheNgoi)
            {
                totalPrice += item.Price;
            }
            lblTotalPrice.Text = totalPrice.ToString();
            lblTotalPrice.ForeColor = Color.Red;
        }

        private void LoadInfoSeat()
        {
            dgvListTicketInfo.DataSource = lstGheNgoi;
        }

        private void btnAddTicket_Click(object sender, EventArgs e)
        {
            var suatchieu = mdc.slot_shows.FirstOrDefault(x => x.Id == IdSuatChieu);
            foreach (var item in lstGheNgoi)
            {
                var ticket = new ticket_sale();
                ticket.Date_sale = DateTime.Now;
                ticket.Total_price = Convert.ToDouble(item.Price);
                ticket.Slot_show_id = idSuatChieu;
                ticket.Account_id = NameUser;
                ticket.NameSeat = item.Name;
                mdc.ticket_sales.InsertOnSubmit(ticket);
                mdc.SubmitChanges();
            }
            MessageBox.Show("Thêm vé thành công!", "Thông báo");
        }
    }
}
