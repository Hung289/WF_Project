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
    public partial class frmManager : Form
    {
        public frmManager()
        {
            InitializeComponent();
            //Phim
            DisplayCateMovie();
            DisplayStatusMovie();
            LoadMovie();

            //Xuất chiếu
            LoadNameMovie();
            LoadCinemaMovie();
            LoadListSlotShow();
            DisplayStatusMovieSc();
            LoadSearchCinemaMovie();
            LoadSearchNameMovie();
            LoadFormatMovieSc();

            //Account - người dùng
            LoadVaiTroAcc();
            LoadListAccount();
            panel8.Visible = false;

            //Phòng chiếu
            LoadRoomCinema();

            //định dạng phim
            LoadFormatMovie();

            //food
            LoadListFood();
            LoadListFoodDetail();
        }
        MovieDataContext mdc = new MovieDataContext();
        bool movieEdit = false;
        private void DisplayCateMovie()
        {
            var listCateMovie = from cm in mdc.category_movies select 
                                new {
                                    Id = cm.Id,
                                    Name = cm.Name
                                };
            cboCateMovie.DataSource = listCateMovie;
            cboCateMovie.DisplayMember = "Name";
            cboCateMovie.ValueMember = "Id";
        }
        
        private void DisplayStatusMovie()
        {
            List<string> ListItem = new List<string>() { "Đang chiếu", "Sắp chiếu", "Ngừng chiếu" };
            cboStatus.DataSource = ListItem;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var mov = new movie();
            mov.Name = txtNameMovie.Text;
            mov.Movie_length = (int)nudLengthMovie.Value;
            mov.Movie_release_date = dtpCongChieu.Value;
            mov.Production_comapany = txtNhaSX.Text;
            mov.Status = (int)cboStatus.SelectedIndex;
            mov.Category_movie_id = (int)(cboCateMovie.SelectedValue);
            mdc.movies.InsertOnSubmit(mov);
            mdc.SubmitChanges();
            LoadMovie();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvMovie.CurrentRow;
            var movie = mdc.movies.FirstOrDefault(x => x.Id == (int)row.Cells[0].Value);
            if(movie != null)
            {
                movie.Name = txtNameMovie.Text;
                movie.Movie_length = (int)nudLengthMovie.Value;
                movie.Movie_release_date = dtpCongChieu.Value;
                movie.Production_comapany = txtNhaSX.Text;
                movie.Status = (int)cboStatus.SelectedIndex;
                movie.Category_movie_id = (int)(cboCateMovie.SelectedValue);
                mdc.SubmitChanges();
                LoadMovie();
            }
        }

        private void LoadMovie()
        {
            var listMovie = from m in mdc.movies
                            from cm in mdc.category_movies
                            where m.Category_movie_id == cm.Id
                            select new
                            {
                                Id = m.Id,
                                Name = m.Name,
                                LengthMovie = m.Movie_length,
                                DayRelease = m.Movie_release_date,
                                ProductCompany = m.Production_comapany,
                                Status = (m.Status == 1) ? "Sắp chiếu" : ((m.Status == 2) ? "Ngừng chiếu" : "Đang chiếu"),
                                CateMovie = cm.Name,
                                CateMovieId = m.Category_movie_id
                            };
            dgvMovie.DataSource = listMovie;
            DisplayDetailMovie();
        }

        private void DisplayDetailMovie()
        {
            if(dgvMovie.CurrentRow != null)
            {
                DataGridViewRow row = dgvMovie.CurrentRow;
                txtNameMovie.Text = row.Cells[1].Value.ToString();
                nudLengthMovie.Value = decimal.Parse(row.Cells[2].Value.ToString());
                dtpCongChieu.Value = (DateTime)row.Cells[3].Value;
                txtNhaSX.Text = row.Cells[4].Value.ToString();
                cboStatus.SelectedItem= row.Cells[5].Value.ToString();
                cboCateMovie.SelectedValue = row.Cells[7].Value;
            }
        }

        private void dgvMovie_Click(object sender, EventArgs e)
        {
            DisplayDetailMovie();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNameMovie.Text = txtNhaSX.Text = "";
            nudLengthMovie.Value = 0;
            cboCateMovie.SelectedIndex = 0;
            cboStatus.SelectedIndex = 0;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dgvMovie.CurrentRow != null)
            {
                if(MessageBox.Show("Bạn có chắc muốn xóa không?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataGridViewRow row = dgvMovie.CurrentRow;
                    var movie = mdc.movies.FirstOrDefault(x => x.Id == (int)row.Cells[0].Value);
                    if(movie != null)
                    {
                        mdc.movies.DeleteOnSubmit(movie);
                        mdc.SubmitChanges();
                        LoadMovie();
                    }
                }
            }
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            var listSearchMovie = from m in mdc.movies
                                  where m.Name.Contains(txtSearchName.Text)
                                  select m;
            dgvMovie.DataSource = listSearchMovie;
        }

        private void dtpDateSearch_ValueChanged(object sender, EventArgs e)
        {
            var listSearchDateMovie = from m in mdc.movies
                                      where m.Movie_release_date >= dtpDateSearch.Value
                                      
                                      select m;
            dgvMovie.DataSource = listSearchDateMovie;
        }









        //Suất chiếu - Lịch chiếu
        private void LoadNameMovie()
        {
            var listMovie = from m in mdc.movies
                            where m.Status == 0 || m.Status == 1
                            select new {
                                Id = m.Id,
                                Name = m.Name
                            };
            cboNameMovieSC.DataSource = listMovie;
            cboNameMovieSC.DisplayMember = "Name";
            cboNameMovieSC.ValueMember = "Id";
        }

        private void LoadCinemaMovie()
        {
            var listCinema = from cm in mdc.cinema_rooms
                             select new
                             {
                                 Id = cm.Id,
                                 Name = cm.Name
                             };
            cboRoomSc.DataSource = listCinema;
            cboRoomSc.DisplayMember = "Name";
            cboRoomSc.ValueMember = "Id";
        }

        private void btnAddSC_Click(object sender, EventArgs e)
        {
            var suatChieu = dtpDayShowSC.Value;
            var gioBatDau = dtpTimeStartSC.Value.TimeOfDay;
            var gioKetThuc = dtpTimeEndSc.Value.TimeOfDay;
            var lstSlotShow = mdc.slot_shows.FirstOrDefault(x => x.Cinema_room_id == (int)cboRoomSc.SelectedValue
                && x.Day_show == suatChieu && ((x.Start_time <= gioBatDau && x.End_time >= gioKetThuc)
                || (x.Start_time >= gioBatDau && x.End_time <= gioKetThuc)
                || (x.Start_time >= gioBatDau && x.Start_time <= gioKetThuc)
                || (x.End_time >= gioBatDau && x.End_time <= gioKetThuc))
            );
            /*var lstSlotShow = mdc.slot_shows.FirstOrDefault(x => 
                x.Cinema_room_id == (int)cboRoomSc.SelectedValue && x.Day_show == dtpDayShowSC.Value
                && ((x.Start_time <= dtpTimeStartSC.Value.TimeOfDay && x.End_time >= dtpTimeEndSc.Value.TimeOfDay)
                || (x.Start_time >= dtpTimeStartSC.Value.TimeOfDay && x.End_time <= dtpTimeEndSc.Value.TimeOfDay)
                || (x.Start_time >= dtpTimeStartSC.Value.TimeOfDay && x.Start_time <= dtpTimeEndSc.Value.TimeOfDay)
                || (x.End_time >= dtpTimeStartSC.Value.TimeOfDay && x.End_time <= dtpTimeEndSc.Value.TimeOfDay)
                )
            );*/
            if(lstSlotShow == null)
            {
                var ss = new slot_show();
                ss.Movie_id = (int)cboNameMovieSC.SelectedValue;
                ss.Cinema_room_id = (int)cboRoomSc.SelectedValue;
                ss.Day_show = dtpDayShowSC.Value;
                ss.Start_time = dtpTimeStartSC.Value.TimeOfDay;
                ss.End_time = dtpTimeEndSc.Value.TimeOfDay;
                ss.Format_movie_id = (int)cboDinhDangSc.SelectedValue;
                mdc.slot_shows.InsertOnSubmit(ss);
                mdc.SubmitChanges();
                LoadListSlotShow();
            }
            else
            {
                MessageBox.Show("Không thể thêm lịch chiếu vì đã tồn tại!", "Thông báo");
            }
        }

        private void LoadListSlotShow()
        {
            var listSlotShow = from ss in mdc.slot_shows
                               from m in mdc.movies
                               from cr in mdc.cinema_rooms
                               from fm in mdc.format_movies
                               where ss.Movie_id == m.Id && ss.Cinema_room_id == cr.Id
                               && fm.Id == ss.Format_movie_id
                               select new
                               {
                                   Id = ss.Id,
                                   StartTime = ss.Start_time,
                                   EndTime = ss.End_time,
                                   DayShow = ss.Day_show,
                                   NameMovie = m.Name,
                                   NameRom = cr.Name,
                                   FormatMovieName = fm.Name,
                                   FormatMovieId = ss.Format_movie_id
                               };
            dgvSlotShowSc.DataSource = listSlotShow;
        }

        private void DisplayStatusMovieSc()
        {
            List<string> ListItem = new List<string>() { "Đang chiếu", "Sắp chiếu" };
            cboSearchStatusSc.DataSource = ListItem;
        }
        
       
        private void cboSearchStatusSc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            /*int keystatus = (int)cboSearchStatusSc.SelectedIndex;
            var listMovie = from m in mdc.movies
                            where m.Status == keystatus
                            select new
                            {
                                Id = m.Id,
                                Name = m.Name
                            };
            cboSearchMovieSc.DataSource = listMovie;
            cboSearchMovieSc.DisplayMember = "Name";
            cboSearchMovieSc.ValueMember = "Id";
            int keyroom = (int)cboSearchRoomSc.SelectedValue;
            *//*int keystatus = (int)cboSearchStatusSc.SelectedIndex;*//*
            int keymovie = (int)cboSearchMovieSc.SelectedValue;
            var date = dtpSearchDateSc.Value.Date;
            *//*var ss = mdc.slot_shows.SingleOrDefault(x => x.Id == 20);
            var result = DateTime.Compare(date, ss.Day_show);*//*
            var data = mdc.slot_shows.Where(x =>
            x.Cinema_room_id == (int)cboSearchRoomSc.SelectedValue &&
            x.Movie_id == (int)cboSearchMovieSc.SelectedValue &&
            x.movie.Status == (int)cboSearchStatusSc.SelectedIndex &&
            DateTime.Compare(x.Day_show, date) == 0).Select(x => new
            {
                Id = x.Id,
                StartTime = x.Start_time,
                EndTime = x.End_time,
                DayShow = x.Day_show,
                NameMovie = x.movie.Name,
                NameRom = x.cinema_room.Name
            }).ToList();
            *//*var statusMovieSc = from ss in mdc.slot_shows
                                from m in mdc.movies
                                from cr in mdc.cinema_rooms
                                where m.Id == ss.Movie_id && ss.Cinema_room_id == cr.Id
                                && cr.Id == (int)cboSearchRoomSc.SelectedValue
                                && m.Status == (int)cboSearchStatusSc.SelectedIndex
                                && m.Id == (int)cboSearchMovieSc.SelectedValue
                                *//*&& ss.Day_show == dtpDateSearch.Value*//*
                                select new
                                {
                                    Id = ss.Id,
                                    StartTime = ss.Start_time,
                                    EndTime = ss.End_time,
                                    DayShow = ss.Day_show,
                                    NameMovie = m.Name,
                                    NameRom = cr.Name
                                };*//*
            dgvSlotShowSc.DataSource = data;*/
        }
        private void LoadSearchNameMovie()
        {
            var listMovie = from m in mdc.movies
                            where (m.Status == 0 || m.Status == 1)
                            select new
                            {
                                Id = m.Id,
                                Name = m.Name
                            };
            cboSearchMovieSc.DataSource = listMovie;
            cboSearchMovieSc.DisplayMember = "Name";
            cboSearchMovieSc.ValueMember = "Id";
        }

        private void LoadSearchCinemaMovie()
        {
            var listCinema = from cm in mdc.cinema_rooms
                             select new
                             {
                                 Id = cm.Id,
                                 Name = cm.Name
                             };
            cboSearchRoomSc.DataSource = listCinema;
            cboSearchRoomSc.DisplayMember = "Name";
            cboSearchRoomSc.ValueMember = "Id";
        }

        

        private void cboSearchRoomSc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int keyroom = (int)cboSearchRoomSc.SelectedValue;
            int keystatus = (int)cboSearchStatusSc.SelectedIndex;
            int keymovie = (int)cboSearchMovieSc.SelectedValue;
            var date = dtpSearchDateSc.Value.Date;
            /*var ss = mdc.slot_shows.SingleOrDefault(x => x.Id == 20);
            var result = DateTime.Compare(date, ss.Day_show);*/
            var data = mdc.slot_shows.Where(x =>
            x.Cinema_room_id == (int)cboSearchRoomSc.SelectedValue &&
            x.Movie_id == (int)cboSearchMovieSc.SelectedValue &&
            x.movie.Status == (int)cboSearchStatusSc.SelectedIndex &&
            DateTime.Compare(x.Day_show, date) == 0).Select(x => new
            {
                Id = x.Id,
                StartTime = x.Start_time,
                EndTime = x.End_time,
                DayShow = x.Day_show,
                NameMovie = x.movie.Name,
                NameRom = x.cinema_room.Name
            }).ToList();
            /*int keyroom = (int)cboSearchRoomSc.SelectedValue;
            int keystatus = (int)cboSearchStatusSc.SelectedIndex;
            int keymovie = (int)cboSearchMovieSc.SelectedValue;
            var statusMovieSc = from ss in mdc.slot_shows
                                from m in mdc.movies
                                from cr in mdc.cinema_rooms
                                where m.Id == ss.Movie_id && ss.Cinema_room_id == cr.Id
                                && cr.Id == (int)cboSearchRoomSc.SelectedValue
                                && m.Status == (int)cboSearchStatusSc.SelectedIndex
                                && m.Id == (int)cboSearchMovieSc.SelectedValue
                                && ss.Day_show == dtpDateSearch.Value
                                select new
                                {
                                    Id = ss.Id,
                                    StartTime = ss.Start_time,
                                    EndTime = ss.End_time,
                                    DayShow = ss.Day_show,
                                    NameMovie = m.Name,
                                    NameRom = cr.Name
                                };*/
            dgvSlotShowSc.DataSource = data;
        }
        

        private void cboSearchMovieSc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int keyroom = (int)cboSearchRoomSc.SelectedValue;
            int keystatus = (int)cboSearchStatusSc.SelectedIndex;
            int keymovie = (int)cboSearchMovieSc.SelectedValue;
            var date = dtpSearchDateSc.Value.Date;
            /*var ss = mdc.slot_shows.SingleOrDefault(x => x.Id == 20);
            var result = DateTime.Compare(date, ss.Day_show);*/
            var data = mdc.slot_shows.Where(x =>
            x.Cinema_room_id == (int)cboSearchRoomSc.SelectedValue &&
            x.Movie_id == (int)cboSearchMovieSc.SelectedValue &&
            x.movie.Status == (int)cboSearchStatusSc.SelectedIndex &&
            DateTime.Compare(x.Day_show, date) == 0).Select(x => new
            {
                Id = x.Id,
                StartTime = x.Start_time,
                EndTime = x.End_time,
                DayShow = x.Day_show,
                NameMovie = x.movie.Name,
                NameRom = x.cinema_room.Name
            }).ToList();
            //var statusMovieSc = from ss in mdc.slot_shows
            //                    from m in mdc.movies
            //                    from cr in mdc.cinema_rooms
            //                    where m.Id == ss.Movie_id && ss.Cinema_room_id == cr.Id
            //                    && cr.Id == (int)cboSearchRoomSc.SelectedValue
            //                    && m.Status == (int)cboSearchStatusSc.SelectedIndex
            //                    && m.Id == (int)cboSearchMovieSc.SelectedValue
            //                    && ss.Day_show.ToString("dd/MM/yyyy").Equals(date)
            //                    select new
            //                    {
            //                        Id = ss.Id,
            //                        StartTime = ss.Start_time,
            //                        EndTime = ss.End_time,
            //                        DayShow = ss.Day_show,
            //                        NameMovie = m.Name,
            //                        NameRom = cr.Name
            //                    };
            dgvSlotShowSc.DataSource = data;
        }


        private void dtpSearchDateSc_ValueChanged(object sender, EventArgs e)
        {
            int keyroom = (int)cboSearchRoomSc.SelectedValue;
            int keystatus = (int)cboSearchStatusSc.SelectedIndex;
            int keymovie = (int)cboSearchMovieSc.SelectedValue;
            var date = dtpSearchDateSc.Value.Date;
           /* var ss = mdc.slot_shows.SingleOrDefault(x => x.Id == 20);
            var result = DateTime.Compare(date, ss.Day_show);*/
            var data = mdc.slot_shows.Where(x =>
            x.Cinema_room_id == (int)cboSearchRoomSc.SelectedValue &&
            x.Movie_id == (int)cboSearchMovieSc.SelectedValue &&
            x.movie.Status == (int)cboSearchStatusSc.SelectedIndex &&
            DateTime.Compare(x.Day_show, date) == 0).Select(x => new
            {
                Id = x.Id,
                StartTime = x.Start_time,
                EndTime = x.End_time,
                DayShow = x.Day_show,
                NameMovie = x.movie.Name,
                NameRom = x.cinema_room.Name
            }).ToList();
            dgvSlotShowSc.DataSource = data;
        }

        //Load đinhh dạng phim trog xuất chiếu
        private void LoadFormatMovieSc()
        {
            var listFormatMovie = from fm in mdc.format_movies
                                  select new
                                  {
                                      Id = fm.Id,
                                      Name = fm.Name
                                  };
            cboDinhDangSc.DataSource = listFormatMovie;
            cboDinhDangSc.DisplayMember = "Name";
            cboDinhDangSc.ValueMember = "Id";
        }










        //Quản lí người dùng
        private void btnAddAcc_Click(object sender, EventArgs e)
        {
            if(!ValidateChildren())
            {
                return;
            }
            var listAcc = mdc.accounts.FirstOrDefault(x => x.Name_user == txtUserName.Text);
            if (listAcc == null)
            {
                var acc = new account();
                acc.Name_show = txtNameShow.Text;
                acc.Name_user = txtUserName.Text;
                acc.Password = txtPassword.Text;
                acc.Type = cboVaiTro.SelectedIndex;
                mdc.accounts.InsertOnSubmit(acc);
                mdc.SubmitChanges();
                LoadListAccount();
            }
            else
            {
                MessageBox.Show("UserName đã tồn tại. Mời chọn username khác", "Thông báo");
            }
        }

        private void LoadVaiTroAcc()
        {
            List<string> lst = new List<string>() { "Quản lí", "admin", "Nhân viên quầy vé" };
            cboVaiTro.DataSource = lst;
        }

        private void LoadListAccount()
        {
            var listAcc = from a in mdc.accounts
                          select new
                          {
                              Username = a.Name_user,
                              NameShow = a.Name_show,
                              Role = (a.Type == 0) ? "Quản lý" : ((a.Type == 1) ? "Admin" : "Nhân viên quầy vé"),
                              RoleId = a.Type
                          };
            dgvListAcc.DataSource = listAcc;
        }

        private void DislayDetailAccout()
        {
            if(dgvListAcc.CurrentRow != null)
            {
                var row = dgvListAcc.CurrentRow;
                txtUserName.Text = row.Cells[0].Value.ToString();
                txtNameShow.Text = row.Cells[1].Value.ToString();
                cboVaiTro.SelectedIndex = (int)row.Cells[3].Value;
            }
        }

        private void dgvListAcc_Click(object sender, EventArgs e)
        {
            DislayDetailAccout();
            panel8.Visible = true;
        }

        private void btnUpdateAcc_Click(object sender, EventArgs e)
        {
            var Acc = mdc.accounts.FirstOrDefault(x => x.Name_user == txtUserName.Text 
            && x.Name_show == txtNameShow.Text && x.Password == txtPassword.Text 
            );

            if(Acc == null)
            {
                MessageBox.Show("Mật khẩu không chính xác!. Không thể cập nhật mật khẩu");
            }
            else
            {
                
                if(txtResNewPass.Text == txtNewPass.Text)
                {
                    Acc.Name_show = txtNameShow.Text;
                    Acc.Name_user = txtUserName.Text;
                    Acc.Type = cboVaiTro.SelectedIndex;
                    Acc.Password = txtNewPass.Text;
                    mdc.SubmitChanges();
                    MessageBox.Show("Cập nhật thành công thông tin người dùng", "Thông Báo");
                }
                else
                {
                    MessageBox.Show("Nhập lại mật khẩu không chính", "Thông Báo");
                }
            }
        }

        private void btnClearAcc_Click(object sender, EventArgs e)
        {
            panel8.Visible = false;
            txtUserName.Text = txtNameShow.Text = "";
            cboVaiTro.SelectedIndex = 0;
        }

        private void txtSearchNameAcc_TextChanged(object sender, EventArgs e)
        {
            var acc = from ac in mdc.accounts
                      where ac.Name_show.Contains(txtSearchNameAcc.Text)
                      select new
                      {
                          Username = ac.Name_user,
                          NameShow = ac.Name_show,
                          Role = (ac.Type == 0) ? "Quản lý" : ((ac.Type == 1) ? "Admin" : "Nhân viên quầy vé"),
                          RoleId = ac.Type
                      };
           
            dgvListAcc.DataSource = acc;
        }


        //Add room
        private void LoadPreviewRoom(int row,int col,int rowVip,int colVip,int rowDoubleSeat)
        {
            flpPreviewSeat.Controls.Clear();
            
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= col; j++)
                {
                    Button btn = new Button();
                    btn.Width = 45;
                    btn.Height = 45;
                    btn.Text = ((char)(i + 64)).ToString() + " - " + j;
                    if ((i <= row - rowVip && i > rowVip) && (j <= col - colVip && j > colVip))
                    {
                        btn.BackColor = Color.Aqua;
                    }
                    if(i>row- rowDoubleSeat)
                    {
                        btn.BackColor = Color.Violet;
                    }
                    flpPreviewSeat.Controls.Add(btn);
                    flpPreviewSeat.Width = (50) * (col + 1);
                }
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            int row = (int)nudRowDemo.Value;
            int col = (int)nudColDemo.Value;
            int rowVip = (int)nudRowVip.Value;
            int colVip = (int)nudColVip.Value;
            int rowDoubleSeat = (int)nudRoubleSeat.Value;
            LoadPreviewRoom(row,col,rowVip,colVip, rowDoubleSeat);
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            var isCheckRoom = mdc.cinema_rooms.FirstOrDefault(x => x.Name == txtNameCinemaRoom.Text);
            if(isCheckRoom == null)
            {
                var roomCinema = new cinema_room();
                roomCinema.Name = txtNameCinemaRoom.Text;
                roomCinema.Quantity_row = (int)nudRowDemo.Value;
                roomCinema.Quantity_Column = (int)nudColDemo.Value;
                roomCinema.Quantity_seat = (int)nudRowDemo.Value * (int)nudColDemo.Value;
                roomCinema.RowVip = (int)nudRowVip.Value;
                roomCinema.ColVip = (int)nudColVip.Value;
                roomCinema.RowDoubleSeat = (int)nudRoubleSeat.Value;
                mdc.cinema_rooms.InsertOnSubmit(roomCinema);
                mdc.SubmitChanges();
                LoadRoomCinema();
                MessageBox.Show("Thêm mới thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Tên phòng đã tồn tại", "Thông báo");
            }
        }

        private void LoadRoomCinema()
        {
            var listRoomCinema = from rc in mdc.cinema_rooms
                                 select new
                                 {
                                     Id = rc.Id,
                                     Name = rc.Name,
                                     Row = rc.Quantity_row,
                                     Col = rc.Quantity_Column,
                                     RowVip = rc.RowVip,
                                     ColVip = rc.ColVip,
                                     RowDoubleSeat = rc.RowDoubleSeat
                                 };
            dgvListRoomCinema.DataSource = listRoomCinema;
        }

        private void dgvListRoomCinema_Click(object sender, EventArgs e)
        {
            
            if (dgvListRoomCinema.CurrentRow != null)
            {
                var row = dgvListRoomCinema.CurrentRow;
                int rows = (int)row.Cells[2].Value;
                int col = (int)row.Cells[3].Value;
                int rowVip = (int)row.Cells[4].Value;
                int colVip = (int)row.Cells[5].Value;
                int rowDoubleSeat = (int)row.Cells[6].Value;
                txtNameCinemaRoom.Text = row.Cells[1].Value.ToString();
                nudRowDemo.Value = decimal.Parse(row.Cells[2].Value.ToString());
                nudColDemo.Value = decimal.Parse(row.Cells[3].Value.ToString());
                nudRowVip.Value = decimal.Parse(row.Cells[4].Value.ToString());
                nudColVip.Value = decimal.Parse(row.Cells[5].Value.ToString());
                nudRoubleSeat.Value = decimal.Parse(row.Cells[6].Value.ToString());
                LoadPreviewRoom(rows, col, rowVip, colVip, rowDoubleSeat);
            }
        }

        private void btnRoomCinemaUpdate_Click(object sender, EventArgs e)
        {
            if(dgvListRoomCinema.CurrentRow != null)
            {
                var row = dgvListRoomCinema.CurrentRow;
                int id = (int)row.Cells[0].Value;
                var roomCinema = mdc.cinema_rooms.FirstOrDefault(x => x.Id == id);

                roomCinema.Name = txtNameCinemaRoom.Text;
                roomCinema.Quantity_row = (int)nudRowDemo.Value;
                roomCinema.Quantity_Column = (int)nudColDemo.Value;
                roomCinema.RowVip = (int)nudRowVip.Value;
                roomCinema.ColVip = (int)nudColVip.Value;
                roomCinema.RowDoubleSeat = (int)nudRoubleSeat.Value;
                mdc.SubmitChanges();
                LoadRoomCinema();
                MessageBox.Show("Cập nhật thành công", "Thông báo");
            }
        }

        private void btnRoomCinemaClear_Click(object sender, EventArgs e)
        {
            txtNameCinemaRoom.Text = "";
            nudRowDemo.Value = 1;
            nudColDemo.Value = 1;
            nudRowVip.Value = 1;
            nudColVip.Value = 1;
        }

        private void btnRoomCinemaDelete_Click(object sender, EventArgs e)
        {
            if(dgvListRoomCinema.CurrentRow != null)
            {
                var row = dgvListRoomCinema.CurrentRow;
                int id = (int)row.Cells[0].Value;
                var roomCinema = mdc.cinema_rooms.FirstOrDefault(x => x.Id == id);
                mdc.cinema_rooms.DeleteOnSubmit(roomCinema);
                mdc.SubmitChanges();
                LoadRoomCinema();
                MessageBox.Show("Xóa thành công!", "Thông báo");
            }
        }


        //Định dạng của phim
        private void btnAddFormatMovie_Click(object sender, EventArgs e)
        {
            var Ischeck = mdc.format_movies.FirstOrDefault(x => x.Name == txtNameFormatMovie.Text);
            if(Ischeck == null)
            {
                var formatMovie = new format_movie();
                formatMovie.Name = txtNameFormatMovie.Text;
                formatMovie.Price = Convert.ToDouble(txtPriceFormat.Text);
                mdc.format_movies.InsertOnSubmit(formatMovie);
                mdc.SubmitChanges();
                LoadFormatMovie();
                MessageBox.Show("Thêm mới thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Tên định dạng đã tồn tại");
            }
            
        }

        private void LoadFormatMovie()
        {
            var listFormatMovie = from fm in mdc.format_movies
                                  select new
                                  {
                                      Id = fm.Id,
                                      Name = fm.Name,
                                      Price = fm.Price
                                  };
            dgvFormatMovie.DataSource = listFormatMovie;
        }

        private void btnClearFormat_Click(object sender, EventArgs e)
        {
            txtNameFormatMovie.Text = txtPriceFormat.Text = "";
        }

        private void dgvFormatMovie_Click(object sender, EventArgs e)
        {
            if(dgvFormatMovie.CurrentRow != null)
            {
                var row = dgvFormatMovie.CurrentRow;
                txtNameFormatMovie.Text = row.Cells[1].Value.ToString();
                txtPriceFormat.Text = row.Cells[2].Value.ToString();
            }
        }

        private void btnUpdateFormat_Click(object sender, EventArgs e)
        {
            var row = dgvFormatMovie.CurrentRow;
            var formatMovie = mdc.format_movies.FirstOrDefault(x => x.Id == (int)row.Cells[0].Value);
            formatMovie.Name = txtNameFormatMovie.Text;
            formatMovie.Price = Convert.ToDouble(txtPriceFormat.Text);
            mdc.SubmitChanges();
            LoadFormatMovie();
            MessageBox.Show("Cập nhật thành công", "Thông báo");
        }

        private void btnDeleteFormat_Click(object sender, EventArgs e)
        {
            var row = dgvFormatMovie.CurrentRow;
            var formatMovie = mdc.format_movies.FirstOrDefault(x => x.Id == (int)row.Cells[0].Value);
            mdc.format_movies.DeleteOnSubmit(formatMovie);
            mdc.SubmitChanges();
            LoadFormatMovie();
            MessageBox.Show("Xóa thành công", "Thông báo");
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }



        //Food
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            frmAddFood frmAddFood = new frmAddFood(0);
            frmAddFood.ShowDialog();
        }
        private void LoadListFood()
        {
            var lstFood = from f in mdc.foods
                          from cf in mdc.cate_foods
                          where cf.Id == f.Cate_food_id
                          select new
                          {
                              Id = f.Id,
                              Name = f.Name,
                              TrangThai = (f.Status == 0) ? "Đang được bán" : "Chưa mở bán",
                              LoaiDoAn = cf.Name,
                              IdDoan = f.Cate_food_id
                          };
            dgvListFood.DataSource = lstFood;
        }

        private void btnLoadFood_Click(object sender, EventArgs e)
        {
            LoadListFood();
        }

        private void dgvListFood_Click(object sender, EventArgs e)
        {

            
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            if(dgvListFood.CurrentRow != null)
            {
                var row = dgvListFood.CurrentRow;
                int idFood = (int)row.Cells[0].Value;
                frmAddFood frmAddFood = new frmAddFood(idFood);
                frmAddFood.ShowDialog();
            }
        }

        private void dgvListFood_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {

            }
        }

        private void dgvListFood_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                if(MessageBox.Show("Bạn có muốn đến cập nhật không","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    if (dgvListFood.CurrentRow != null)
                    {
                        var row = dgvListFood.CurrentRow;
                        int idFood = (int)row.Cells[0].Value;
                        frmAddFood frmAddFood = new frmAddFood(idFood);
                        frmAddFood.ShowDialog();
                    }
                }
                else
                {
                    LoadListFoodDetail();
                }
            }
            else
            {
                if(MessageBox.Show("Bạn có chắc chắn muốn xóa không","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    
                    if (dgvListFood.CurrentRow != null)
                    {
                        var row = dgvListFood.CurrentRow;
                        int idFood = (int)row.Cells[0].Value;
                        var food = mdc.foods.FirstOrDefault(x => x.Id == idFood);
                        if(food !=null)
                        {
                            mdc.foods.DeleteOnSubmit(food);
                            mdc.SubmitChanges();
                            LoadListFood();
                        }
                    }
                }
            }
        }






        //Chi tiết đồ ăn
        private void btnAddSizeFood_Click(object sender, EventArgs e)
        {

            
            if (dgvListFood.CurrentRow != null)
            {
                var row = dgvListFood.CurrentRow;
                int idFood = (int)row.Cells[0].Value;
                frmAddSize frmAddSize = new frmAddSize(idFood,0);
                frmAddSize.ShowDialog();
            }
        }

        private void btnLoadFoodDetail_Click(object sender, EventArgs e)
        {
            LoadListFoodDetail();
        }

        private void LoadListFoodDetail()
        {
            if (dgvListFood.CurrentRow != null)
            {
                var row = dgvListFood.CurrentRow;
                int idFood = (int)row.Cells[0].Value;
                var listFoodDetail = from fd in mdc.food_details
                                     from fs in mdc.size_foods
                                     where fd.Size_food_id == fs.Id && fd.Foot_id == idFood
                                     select new
                                     {
                                         Id = fd.Id,
                                         Size = fs.Name,
                                         Price = fd.Price,
                                         Status = (fd.Status == 0) ? "Đang được bán" : "Chưa mở bán",
                                     };
                dgvListSizeFood.DataSource = listFoodDetail;
            }
        }

        private void dgvListSizeFood_MouseClick(object sender, MouseEventArgs e)
        {
            var row = dgvListFood.CurrentRow;
            int idFood = (int)row.Cells[0].Value;
            var row1 = dgvListSizeFood.CurrentRow;
            int idFoodDetail = (int)row1.Cells[0].Value;
            if(e.Button == MouseButtons.Right)
            {
                if(MessageBox.Show("Bạn có chắc muốn xóa không","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if(dgvListSizeFood.CurrentRow != null)
                    {
                        var foodDetail = mdc.food_details.FirstOrDefault(x => x.Id == idFoodDetail);
                        if(foodDetail != null)
                        {
                            mdc.food_details.DeleteOnSubmit(foodDetail);
                            mdc.SubmitChanges();
                            LoadListFoodDetail();
                        }
                    }
                }
            }
            else
            {
                if(MessageBox.Show("Bạn có muốn cập nhật không","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    frmAddSize frmAddSize = new frmAddSize(idFood, idFoodDetail);
                    frmAddSize.ShowDialog();
                }
                else
                {

                }
            }
        }
    }



    

}
