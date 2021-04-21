using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.Models
{
    class ThongKeMovie
    {
        public string Name { get; set; }
        public DateTime MovieReleaseDate { get; set; }
        public int SoLuongVeBanDuoc { get; set; }
        public double TotalPrice { get; set; }
    }
}
