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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        MovieDataContext mdc = new MovieDataContext();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            if(isLogin(username,password))
            {
                frmMain fm = new frmMain(username);
                this.Hide();
                fm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private bool isLogin(string username, string password)
        {
            var isCheck = from acc in mdc.accounts
                          where acc.Name_user == username
                          && acc.Password == password
                          select acc;
            if(isCheck.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
