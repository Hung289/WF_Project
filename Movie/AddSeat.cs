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
    public partial class frmAddSeat : Form
    {
        public frmAddSeat()
        {
            InitializeComponent();
            LoadRoom();
            LoadCateSeat();
            Loadstatus();
            LoadListSeat();
            LoadSeat();
        }
        MovieDataContext mdc = new MovieDataContext();

        private void LoadRoom()
        {
            var listRoom = from r in mdc.cinema_rooms
                           select new {
                             Id = r.Id,
                             Name = r.Name,
                             Row = r.Quantity_row,
                             Col = r.Quantity_Column
                           };
            cboRoom.DataSource = listRoom;
            cboRoom.DisplayMember = "Name";
            cboRoom.ValueMember = "Id";

            
        }

        private void cboRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idRoom = (int)cboRoom.SelectedValue;
            var room = mdc.cinema_rooms.FirstOrDefault(x => x.Id == idRoom);
            nudRow.Value = room.Quantity_row;
            nudCol.Value = room.Quantity_Column;
            LoadAddRow(room);
            LoadAddCol(room);
        }

        private void LoadCateSeat()
        {
            var listCateSeat = from cs in mdc.category_seats
                               select new
                               {
                                   Id = cs.Id,
                                   Name = cs.Name
                               };
            cboCateSeat.DataSource = listCateSeat;
            cboCateSeat.DisplayMember = "Name";
            cboCateSeat.ValueMember = "Id";
        }

        private void LoadAddRow(cinema_room room)
        {
            
            int rowVal = room.Quantity_row;
            List<string> lstA = new List<string>();

            for (int i = 1; i <= rowVal; i++)
            {
                lstA.Add(((char)(i + 64)).ToString());
            }
            cboAddRow.DataSource = lstA;

        }

        private void LoadAddCol(cinema_room room)
        {
            int rowCol = room.Quantity_Column;
            List<int> lstB = new List<int>();
            for (int i = 1; i <= rowCol; i++)
            {
                lstB.Add(i);
            }
            cboAddCol.DataSource = lstB;
        }

        private void Loadstatus()
        {
            List<string> lstC = new List<string>() { "Hiện","Ẩn" };
            cboStatus.DataSource = lstC;
        }

        private void LoadListSeat()
        {
            /*var listSeat = from s in mdc.seatings
                           select s;
            dgvSeat.DataSource = listSeat;*/

        }

        private void btnAddSeat_Click(object sender, EventArgs e)
        {
            /*var ischeck = mdc.seatings.FirstOrDefault(s => s.Position_row == (string)cboAddRow.SelectedItem
            && s.Position_column == (int)cboAddCol.SelectedValue
                          && s.Cinema_room_id == (int)cboRoom.SelectedValue
            );
                
                *//*from s in mdc.seatings
                          where s.Position_row == (string)cboAddRow.SelectedItem
                          && s.Position_column == (int)cboAddCol.SelectedValue
                          && s.Cinema_room_id == (int)cboRoom.SelectedValue
                          select s;*//*
            if(ischeck == null)
            {
                var seat = new seating();
                seat.Position_row = (string)cboAddRow.SelectedItem;
                seat.Position_column = (int)cboAddCol.SelectedValue;
                seat.Status = (int)cboStatus.SelectedIndex;
                seat.Cinema_room_id = (int)cboRoom.SelectedValue;
                seat.Category_seat_id = (int)cboCateSeat.SelectedValue;
                mdc.seatings.InsertOnSubmit(seat);
                mdc.SubmitChanges();
                LoadListSeat();
            }
            else
            {
                MessageBox.Show("Ghế đã tồn tại.Thêm Ghế khác", "Thông báo");
            }*/
        }

        private void LoadSeat()
        {
            int soCot = mdc.cinema_rooms.FirstOrDefault(x => x.Id == 1).Quantity_Column;
            int soHang = mdc.cinema_rooms.FirstOrDefault(x => x.Id == 1).Quantity_row;
            for (int i = 1; i <= soHang; i++)
            {
                for (int j = 1; j <= soCot; j++)
                {
                    Button btn = new Button();
                    btn.Text = ((char)(i + 64)).ToString() + " - " + j;
                    btn.Width = 60;
                    btn.Height = 60;
                    if (i >= 5 && (j<= soCot - 2 && j> 2))
                    {
                        btn.BackColor = Color.Aqua;
                    }
                    flpAddSeat.Controls.Add(btn);
                }
            }
        }
    }
}
