using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie
{
    public partial class TextboxValidate : UserControl
    {
        public bool IsNumber { get; set; }
        public string Pattern { get; set; }
        public string Filedname { get; set; }
        public override string Text { get => textBox1.Text; set => textBox1.Text = value; }

        public TextboxValidate()
        {
            InitializeComponent();
            label1.Text = "";
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if(String.IsNullOrEmpty(textBox1.Text))
            {
                e.Cancel = true;
                label1.Text = $"{Filedname} Không được bỏ trống";
                return;
            }
            if(IsNumber)
            {
                try
                {
                    Convert.ToDouble(textBox1.Text);
                }
                catch (Exception)
                {
                    e.Cancel = true;
                    label1.Text = "Phải nhập số";
                    return;
                }
            }
            if (!String.IsNullOrEmpty(Pattern))
            {
                if(!Regex.IsMatch(textBox1.Text, Pattern))
                {
                    e.Cancel = true;
                    label1.Text = $"{Filedname} không đúng định dạng";
                    return;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
