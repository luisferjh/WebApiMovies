using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiMovies.Models;
using WebApiMovies.Services;

namespace WebApiMovies.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly MovieService _movieService;
        public MovieController(MovieService movieService)
        {
            _movieService = movieService;
        }

       
        [HttpGet("[action]")]
        public async Task<IEnumerable<MovieDTO>> TopRates()
        {
            List<MovieDTO> list = await _movieService.TopRates();
            return list;
        }

        [HttpGet("[action]")]
        public async Task<IEnumerable<MovieDTO>> OnTheather()
        {
            List<MovieDTO> list = await _movieService.OnTheater();
            return list;
        }

        [HttpGet("[action]")]
        public async Task<IEnumerable<MovieDTO>> TopPopular()
        {
            List<MovieDTO> list = await _movieService.Populars();
            return list;
        }

        [HttpGet("[action]/{title}")]
        public async Task<ActionResult> SearchMovies([FromRoute] string title)
        {
            if (string.IsNullOrEmpty(title))
            {
                return BadRequest("Digite un titulo valido");
            }

            List<MovieDTO> list = await _movieService.SearchMovie(title);
            if (list.Count <= 0)
            {
                return NotFound();
            }

            return Ok(list);

        }

        [HttpGet("[action]/{id}")]
        public async Task<ActionResult> GetMovieDetail([FromRoute] int id)
        {
            if (id <= 0)
            {
                return BadRequest("Digite un identificador valido");
            }

            MovieDetailsDTO movieDetail = await _movieService.GetMovieDetails(id);
            if (movieDetail == null)
            {
                return NotFound();
            }

            return Ok(movieDetail);

        }

    }
}
