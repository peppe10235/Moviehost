using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using MovieHost4;
using MovieHost4.Entities;
using MovieHost4.Repos;
using Newtonsoft.Json;

namespace MovieHost.CommandHandlers
{
    public class MovieCommandHandler
    {
        
        public async Task<IEnumerable<Movie>> GetTopratedMovies()
        {

            var repo = new MovieRepo();

            //Task<IEnumerable<Movie>> task = Task.Run<IEnumerable<Movie>>(async () => await repo.GetTopratedMovies());
            
            return await repo.GetTopratedMovies();

        }
        public async Task<IEnumerable<Movie>> Getupcomingmovies()
        {
            var repo = new MovieRepo();
            return await repo.GetTopratedMovies();
        }

        public async Task<IEnumerable<Movie>> Getnowplaying()
        {
            var repo = new MovieRepo();
            return await repo.Getnowplaying();

        }
    }
}
