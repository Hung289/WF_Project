using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.Models
{
    class BillFoodDetail
    {
        public int Id { get; set; }
        public DateTime DateSale { get; set; }
        public string NameStaff { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }
        public string NameSize { get; set; }
        public string NameFood { get; set; }
        
    }
}
