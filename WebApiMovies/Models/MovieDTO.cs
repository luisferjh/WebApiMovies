﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiMovies.Models
{
    public class MovieDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Overview { get; set; }
        public double Popularity { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public double VoteAverage { get; set; }
        public int VoteCount { get; set; }
        public string PosterPath { get; set; }
    }
}
