using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MovieHost4.Entities;
using Newtonsoft.Json;
using Microsoft.Extensions.Configuration;

namespace MovieHost4.Repos
{
    
    

    public class MovieRepo
    {

        public async Task<IEnumerable<Movie>> GetTopratedMovies()
        {
            var MovieList = new List<Movie>();
            HttpClient client = new HttpClient();
            HttpResponseMessage response =  client.GetAsync(AppsettingsHelper.TopratedMoviesUrl).Result;
            if (response.IsSuccessStatusCode)
            {

                var result = response.Content.ReadAsStringAsync().Result; ;
                var res = JsonConvert.DeserializeObject<TopratedMovies>(result);

                return res.results;

            }

            return MovieList;
        }

        public async Task<IEnumerable<Movie>> Getupcomingmovies()
        {
            var MovieList = new List<Movie>();
            HttpClient client = new HttpClient();
            HttpResponseMessage response = client.GetAsync(AppsettingsHelper.UpcomingMoviesUrl).Result;
            if (response.IsSuccessStatusCode)
            {

                var result = response.Content.ReadAsStringAsync().Result; ;
                var res = JsonConvert.DeserializeObject<MoviesWithDates>(result);

                return res.results;

            }

            return MovieList;

        }

        public async Task<IEnumerable<Movie>> Getnowplaying()
        {
            var MovieList = new List<Movie>();
            HttpClient client = new HttpClient();
            HttpResponseMessage response = client.GetAsync(AppsettingsHelper.NowPlayingMoviesUrl).Result;
            if (response.IsSuccessStatusCode)
            {

                var result = response.Content.ReadAsStringAsync().Result; ;
                var res = JsonConvert.DeserializeObject<MoviesWithDates>(result);

                return res.results;

            }

            return MovieList;

        }
    }
}
