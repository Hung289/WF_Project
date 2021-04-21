using Movie.Models;
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
    public partial class SlotShow : Form
    {
        MovieDataContext mdc = new MovieDataContext();
        public SlotShow()
        {
            InitializeComponent();
            LoadListSlotShow();
        }

        private void LoadListSlotShow()
        {
            var date = dtpSearch.Value;
            var data = from ss in mdc.slot_shows
                       from m in mdc.movies
                       from cr in mdc.cinema_rooms
                       from fm in mdc.format_movies
                       where ss.Movie_id == m.Id && ss.Cinema_room_id == cr.Id
                       && ss.Format_movie_id == fm.Id && ss.Day_show.CompareTo(date) ==0
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
            dgvSlotShow.DataSource = data;
        }

        private void dtpSearch_ValueChanged(object sender, EventArgs e)
        {
            var date = dtpSearch.Value;
            var data = from ss in mdc.slot_shows
                       from m in mdc.movies
                       from cr in mdc.cinema_rooms
                       from fm in mdc.format_movies
                       where ss.Movie_id == m.Id && ss.Cinema_room_id == cr.Id
                       && ss.Format_movie_id == fm.Id && ss.Day_show.CompareTo(date) == 0
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
            dgvSlotShow.DataSource = data;
        }

        private void btnSlotShowBC_Click(object sender, EventArgs e)
        {
            frmSlotShowViewReport frmSlotShowViewReport = new frmSlotShowViewReport();
            frmSlotShowViewReport.DayShow = dtpSearch.Value;
            frmSlotShowViewReport.FrmStatus = false;
            frmSlotShowViewReport.ShowDialog();
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            if(dgvSlotShow.CurrentRow != null)
            {
                var row = dgvSlotShow.CurrentRow;
                var Id = row.Cells[0].Value;
                frmSlotShowViewReport frmSlotShowViewReport = new frmSlotShowViewReport();
                frmSlotShowViewReport.DayShow = dtpSearch.Value;
                frmSlotShowViewReport.SlotShowId = (int)Id;
                frmSlotShowViewReport.FrmStatus = true;
                frmSlotShowViewReport.ShowDialog();
            }
        }
    }
}
