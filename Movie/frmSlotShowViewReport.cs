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
    public partial class frmSlotShowViewReport : Form
    {
        MovieDataContext mdc = new MovieDataContext();
        public DateTime DayShow { get; set; }
        public bool FrmStatus { get; set; }
        public int SlotShowId { get; set; }
        public frmSlotShowViewReport()
        {
            InitializeComponent();
        }

        private void frmSlotShowViewReport_Load(object sender, EventArgs e)
        {
            if(FrmStatus == false)
            {
                RptSlotShow rpt = new RptSlotShow();
                var data = from ss in mdc.slot_shows
                           from m in mdc.movies
                           from cr in mdc.cinema_rooms
                           from fm in mdc.format_movies
                           where ss.Movie_id == m.Id && ss.Cinema_room_id == cr.Id
                           && ss.Format_movie_id == fm.Id && ss.Day_show.CompareTo(DayShow) == 0
                           select new Models.SlotShow
                           {
                               Id = ss.Id,
                               DayShow = ss.Day_show,
                               StartTime = ss.Start_time,
                               EndTime = (TimeSpan)ss.End_time,
                               NameMovie = m.Name,
                               NameRoom = cr.Name,
                               NameFormatMovie = fm.Name
                           };
                rpt.SetDataSource(data);
                crystalReportViewer1.ReportSource = rpt;
                crystalReportViewer1.Show();
            }
            else
            {
                RptTicket rpt = new RptTicket();
                Console.WriteLine(SlotShowId);
                var data = from ss in mdc.slot_shows
                           from m in mdc.movies
                           from cr in mdc.cinema_rooms
                           from fm in mdc.format_movies
                           from tk in mdc.ticket_sales
                           from a in mdc.accounts
                           where ss.Movie_id == m.Id && ss.Cinema_room_id == cr.Id
                           && ss.Format_movie_id == fm.Id && tk.Slot_show_id == ss.Id
                           && tk.Account_id == a.Name_user
                           && tk.Slot_show_id == SlotShowId
                           select new Models.Ticket
                           {
                               Id = ss.Id,
                               DayShow = ss.Day_show,
                               StartTime = ss.Start_time,
                               EndTime = (TimeSpan)ss.End_time,
                               NameMovie = m.Name,
                               NameRoom = cr.Name,
                               NameFormatMovie = fm.Name,
                               DaySell = tk.Date_sale,
                               TotalPrice = (double)tk.Total_price,
                               NameSeat = tk.NameSeat,
                               AccountName = a.Name_user
                           };
                rpt.SetDataSource(data);
                crystalReportViewer1.ReportSource = rpt;
                crystalReportViewer1.Show();
            }
        }
    }
}
