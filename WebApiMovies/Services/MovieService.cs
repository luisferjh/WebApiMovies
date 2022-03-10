using AutoMapper;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiMovies.Models;

namespace WebApiMovies.Services
{
    public class MovieService
    {
        private readonly DataAccess _db;
        private readonly IMapper _mapper;
        public MovieService(DataAccess db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<List<MovieDTO>> TopRates()
        {
            var result = await _db.ListMoviesTopRated();

            List<MovieDTO> movies = _mapper.Map<List<MovieDTO>>(result);
            return movies;

        }

        public async Task<List<MovieDTO>> OnTheater()
        {
            var result = await _db.ListMoviesOnTheather();

            List<MovieDTO> movies = _mapper.Map<List<MovieDTO>>(result);
            return movies;

        }

        public async Task<List<MovieDTO>> Populars()
        {
            var result = await _db.ListMoviesPopular();

            List<MovieDTO> movies = _mapper.Map<List<MovieDTO>>(result);
            return movies;

        }


        public async Task<List<MovieDTO>> SearchMovie(string title)
        {
            var result = await _db.ListMoviesSearched(title);

            List<MovieDTO> movies = _mapper.Map<List<MovieDTO>>(result);
            return movies;

        }

        public async Task<MovieDetailsDTO> GetMovieDetails(int id)
        {
            var result = await _db.MovieDetails(id);

            MovieDetailsDTO movieDetails = _mapper.Map<MovieDetailsDTO>(result);
            return movieDetails;
        }
    }
}
