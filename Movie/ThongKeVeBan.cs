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
    public partial class frmThongKeVeBan : Form
    {
        public string UserName { get; set; }
        public frmThongKeVeBan()
        {
            
        }

        public frmThongKeVeBan(string userName)
        {
            this.UserName = userName;
            InitializeComponent();
        }

        MovieDataContext mdc = new MovieDataContext();

        private void LoadListThongKeVe()
        {
            
        }
    }
}
