using System;

namespace Models
{
    public class Movie
    {
        public int id { get; set; }
        public string title { get; set; }
        public string overview { get; set; }
        public double popularity { get; set; }
        public string release_date { get; set; }
        public double vote_average { get; set; }
        public int vote_count { get; set; }
        public string poster_path { get; set; }

    }
}
