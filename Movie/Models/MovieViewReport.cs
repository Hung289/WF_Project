using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.Models
{
    class MovieViewReport
    {
        public int Id { get; set; }
        public string MovieName { get; set; }
        public int MovieLength { get; set; }
        public DateTime MovieReleaseDate { get; set; }
        public string ProductCompany { get; set; }
        public int Status { get; set; }
        public int CategoryMovieId { get; set; }
    }
}
