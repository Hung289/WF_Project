using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie
{
    public class GheNgoi
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string LoaiGhe { get; set; }
        public GheNgoi()
        {
        }

        public GheNgoi(string name, double price, string loaighe)
        {
            Name = name;
            Price = price;
            LoaiGhe = loaighe;
        }
    }
}
