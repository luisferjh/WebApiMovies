using Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using System.Text.Json;

namespace Data
{
    public class DataAccess
    {
        private static readonly HttpClient _httpClient;
        
        static DataAccess()
        {
            _httpClient = new HttpClient();
        }

        public async Task<List<Movie>> ListMoviesOnTheather()
        {
            var httpResponse = await _httpClient.GetAsync($"{Config.Get("UriBase")}{Config.Get("Parameters:nowPlaying")}?api_key={Config.Get("ApiKey")}");
            List<Movie> content = new List<Movie>();
            if (httpResponse.IsSuccessStatusCode)
            {
                var response = await httpResponse.Content.ReadAsStringAsync();
                var responseBody = JsonSerializer.Deserialize<ObjectR>(response);
                content = responseBody.results;
            }

            return content;
        }

        public async Task<List<Movie>> ListMoviesPopular()
        {
            var httpResponse = await _httpClient.GetAsync($"{Config.Get("UriBase")}{Config.Get("Parameters:popular")}?api_key={Config.Get("ApiKey")}");
            List<Movie> content = new List<Movie>();
            if (httpResponse.IsSuccessStatusCode)
            {
                var response = await httpResponse.Content.ReadAsStringAsync();
                var responseBody = JsonSerializer.Deserialize<ObjectR>(response);
                content = responseBody.results;
            }

            return content;
        }

        public async Task<List<Movie>> ListMoviesTopRated()
        {
            var httpResponse = await _httpClient.GetAsync($"{Config.Get("UriBase")}{Config.Get("Parameters:topRates")}?api_key={Config.Get("ApiKey")}");
            List<Movie> content = new List<Movie>();
            if (httpResponse.IsSuccessStatusCode)
            {
               var response = await httpResponse.Content.ReadAsStringAsync();
               var responseBody = JsonSerializer.Deserialize<ObjectR>(response);
               content = responseBody.results;
            }

            return content;

        }

        public async Task<List<Movie>> ListMoviesSearched(string title)
        {
            var httpResponse = await _httpClient.GetAsync($"{Config.Get("UriBase")}{Config.Get("Parameters:searchMovie")}?api_key={Config.Get("ApiKey")}&query={title}");
            List<Movie> content = new List<Movie>();
            if (httpResponse.IsSuccessStatusCode)
            {
                var response = await httpResponse.Content.ReadAsStringAsync();
                var responseBody = JsonSerializer.Deserialize<ObjectR>(response);
                content = responseBody.results;
            }

            return content;

        }

        public async Task<MovieDetail> MovieDetails(int id) 
        {
            var httpResponse = await _httpClient.GetAsync($"{Config.Get("UriBase")}{Config.Get("Parameters:movie")}/{id}?api_key={Config.Get("ApiKey")}");
            MovieDetail content = new MovieDetail();
            if (httpResponse.IsSuccessStatusCode)
            {
                var response = await httpResponse.Content.ReadAsStringAsync();
                content = JsonSerializer.Deserialize<MovieDetail>(response);               
            }

            return content;
        } 

    }
}
