using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiMovies.Models
{
    public class MovieDetailsDTO
    {
        public int Id { get; set; }
        public int Budget { get; set; }
        public double Popularity { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string Status { get; set; }
        public string Title { get; set; }
        public double VoteAverage { get; set; }
        public double VoteCount { get; set; }
        public string Overview { get; set; }
        public string PosterPath { get; set; }
        public int Runtime { get; set; }
        public List<GenreDTO> Genres { get; set; }
        public List<ProductionCompanyDTO> ProductionCompanies { get; set; }

        public MovieDetailsDTO()
        {
            Genres = new List<GenreDTO>();
            ProductionCompanies = new List<ProductionCompanyDTO>();
        }
    }
}
