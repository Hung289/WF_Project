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
    
    public partial class frmGhe : Form
    {
        List<GheNgoi> listGheNgoi = new List<GheNgoi>();
        private int idmovie;
        private int idsuatchieu;
        public string NameUser { get; set; }
        public double price { get; set; }

        public frmGhe()
        {
            
        }
        public frmGhe(int IdMovie,int IdSuatChieu)
        {
            this.idmovie = IdMovie;
            this.idsuatchieu = IdSuatChieu;
            InitializeComponent();
            LoadSeat();
            
        }
        MovieDataContext mdc = new MovieDataContext();

        public int Idmovie { get { return idmovie; } set { idmovie = value; } }
        public int Idsuatchieu { get { return idsuatchieu; } set { idsuatchieu = value; } }

        private void LoadSeat()
        {

            var idroom = mdc.slot_shows.FirstOrDefault(x => x.Movie_id == this.Idmovie && x.Id == this.idsuatchieu);



            int row = mdc.cinema_rooms.FirstOrDefault(x => x.Id == idroom.Cinema_room_id).Quantity_Column;
            int col = mdc.cinema_rooms.FirstOrDefault(x => x.Id == idroom.Cinema_room_id).Quantity_row;
            int rowVip = (int)mdc.cinema_rooms.FirstOrDefault(x => x.Id == idroom.Cinema_room_id).RowVip;
            int colVip = (int)mdc.cinema_rooms.FirstOrDefault(x => x.Id == idroom.Cinema_room_id).ColVip;
            int rowDoubleSeat = (int)mdc.cinema_rooms.FirstOrDefault(x => x.Id == idroom.Cinema_room_id).RowDoubleSeat;
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= col; j++)
                {
                    Button btn = new Button();
                    btn.Width = 45;
                    btn.Height = 45;
                    string nameSeat = ((char)(i + 64)).ToString() + "-" + j;

                    btn.Text = nameSeat;
                    var checkSeat = mdc.ticket_sales.FirstOrDefault(x => x.NameSeat == nameSeat
                    && x.Slot_show_id == this.Idsuatchieu);
                    btn.BackColor = Color.RosyBrown;
                    if ((i <= row - rowVip && i > rowVip) && (j <= col - colVip && j > colVip))
                    {
                        btn.BackColor = Color.Brown;
                    }
                    if(i > row - rowDoubleSeat)
                    {
                        btn.BackColor = Color.Violet;
                    }
                    if(checkSeat != null)
                    {
                        btn.BackColor = Color.Silver;
                        btn.Text = "";
                    }
                    
                    flpGhe.Controls.Add(btn);
                    flpGhe.Width = (50) * (col + 1);

                    btn.Click += ClickChoiceSeat;
                    string nameSeatPhai = ((char)(i + 64)).ToString() + "-" + (j + 1);
                    string nameSeatTrai = ((char)(i + 64)).ToString() + "-" + (j - 1);
                    
                }
            }
        }

        private void ClickChoiceSeat(object sender, EventArgs e)
        {
            
            var format_room_id = mdc.slot_shows.FirstOrDefault(x => x.Id == idsuatchieu).Format_movie_id;
            double PriceFormatMovie = (double)mdc.format_movies.FirstOrDefault(x => x.Id == format_room_id).Price;

            var btn = (sender as Button);
            Console.WriteLine(btn);
            if (btn.BackColor == Color.Silver)
            {
                MessageBox.Show("Ghế này đã có người chọn","Thông báo");
            }
            else
            {
                if(btn.BackColor == Color.Red)
                {
                    MessageBox.Show("Đã chọn rồi! Vui lòng chọn ghế khác", "Thông báo");
                }
                else
                {

                    if (btn.BackColor == Color.RosyBrown)
                    {
                        price += (double)mdc.category_seats.FirstOrDefault(x=>x.Id==1).Subcharge;
                        GheNgoi gheNgoi = new GheNgoi();
                        gheNgoi.Name = btn.Text;
                        gheNgoi.Price = (double)mdc.category_seats.FirstOrDefault(x => x.Id == 1).Subcharge + PriceFormatMovie;
                        gheNgoi.LoaiGhe = mdc.category_seats.FirstOrDefault(x => x.Id == 1).Name;
                        listGheNgoi.Add(gheNgoi);
                    }
                    else if(btn.BackColor == Color.Brown)
                    {
                        price += (double)mdc.category_seats.FirstOrDefault(x => x.Id == 2).Subcharge;
                        GheNgoi gheNgoi = new GheNgoi();
                        gheNgoi.Name = btn.Text;
                        gheNgoi.Price = (double)mdc.category_seats.FirstOrDefault(x => x.Id == 2).Subcharge + PriceFormatMovie;
                        gheNgoi.LoaiGhe = mdc.category_seats.FirstOrDefault(x => x.Id == 2).Name;
                        listGheNgoi.Add(gheNgoi);
                    }
                    else
                    {
                        price += (double)mdc.category_seats.FirstOrDefault(x => x.Id == 3).Subcharge;
                        GheNgoi gheNgoi = new GheNgoi();
                        gheNgoi.Name = btn.Text;
                        gheNgoi.Price = (double)mdc.category_seats.FirstOrDefault(x => x.Id == 3).Subcharge + PriceFormatMovie;
                        gheNgoi.LoaiGhe = mdc.category_seats.FirstOrDefault(x => x.Id == 3).Name;
                        listGheNgoi.Add(gheNgoi);
                        string tt = btn.Text.Substring(0,2);
                        int sub = Convert.ToInt32(btn.Text.Substring(2));
                        if(sub % 2 == 0)
                        {
                            Control p;
                            p = ((Button)sender).Parent;
                            p.SelectNextControl(ActiveControl, false, true, true, true);
                            ActiveControl.BackColor = Color.Red;
                            price += (double)mdc.category_seats.FirstOrDefault(x => x.Id == 3).Subcharge;
                            GheNgoi gheNgoiPrev = new GheNgoi();
                            gheNgoiPrev.Name = tt+(sub - 1);
                            gheNgoiPrev.Price = (double)mdc.category_seats.FirstOrDefault(x => x.Id == 3).Subcharge + PriceFormatMovie;
                            gheNgoiPrev.LoaiGhe = (string)mdc.category_seats.FirstOrDefault(x => x.Id == 3).Name;
                            listGheNgoi.Add(gheNgoiPrev);
                        }
                        else
                        {
                            Control p;
                            p = ((Button)sender).Parent;
                            p.SelectNextControl(ActiveControl, true, true, true, true);
                            ActiveControl.BackColor = Color.Red;
                            price += (double)mdc.category_seats.FirstOrDefault(x => x.Id == 3).Subcharge;
                            GheNgoi gheNgoiNext = new GheNgoi();
                            gheNgoiNext.Name = tt + (sub + 1);
                            gheNgoiNext.Price = (double)mdc.category_seats.FirstOrDefault(x => x.Id == 3).Subcharge + PriceFormatMovie;
                            gheNgoiNext.LoaiGhe = (string)mdc.category_seats.FirstOrDefault(x => x.Id == 3).Name;
                            listGheNgoi.Add(gheNgoiNext);

                        }
                    }
                    txtPriceChoiceSeat.Text = this.price.ToString();
                    btn.BackColor = Color.Red;
                }
                
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDatve_Click(object sender, EventArgs e)
        {
            TickteInfo tickteInfo = new TickteInfo(idmovie, idsuatchieu, listGheNgoi);
            tickteInfo.NameUser = NameUser;
            /*tickteInfo.lstGheNgoi = listGheNgoi;*/
            tickteInfo.ShowDialog();
        }
    }
}
