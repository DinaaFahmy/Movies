using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesAPI.Models
{
    public class movies
    {
        public int movie_id { get; set; }
        public string movie_name { get; set; }
        public string language { get; set; }
        public string genre { get; set; }

    }
}
