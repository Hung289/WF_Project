using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.Models
{
    class SlotShow
    {
        public int Id { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public DateTime DayShow { get; set; }
        public string NameMovie { get; set; }
        public string NameRoom { get; set; }
        public string NameFormatMovie { get; set; }
    }
}
