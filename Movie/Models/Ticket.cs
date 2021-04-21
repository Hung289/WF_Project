using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.Models
{
    class Ticket
    {
        public int Id { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public DateTime DayShow { get; set; }
        public string NameMovie { get; set; }
        public string NameRoom { get; set; }
        public string NameFormatMovie { get; set; }
        public DateTime DaySell { get; set; }
        public double TotalPrice { get; set; }
        public string AccountName { get; set; }
        public string NameSeat { get; set; }

    }
}
