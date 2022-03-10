using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class MovieDetail
    {
        public int budget { get; set; }
        public int id { get; set; }
        public double popularity { get; set; }
        public string release_date { get; set; }
        public string status { get; set; }
        public string title { get; set; }
        public double vote_average { get; set; }
        public double vote_count { get; set; }
        public string overview { get; set; }
        public string poster_path { get; set; }
        public int runtime { get; set; }
        public List<Genre> genres { get; set; }
        public List<ProductionCompany> production_companies { get; set; }

        public MovieDetail()
        {
            genres = new List<Genre>();
            production_companies = new List<ProductionCompany>();
        }
    }
}
