using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieHost.CommandHandlers;

namespace MovieHost4.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        
        [HttpGet]
        [Route("Gettopratedmovies")]
        public async Task<IEnumerable<Movie>> GetTopratedMovies()
        {
            var handler = new MovieCommandHandler();
            return await handler.GetTopratedMovies();
            
        }

        [HttpGet]
        [Route("Getupcomingmovies")]
        public async Task<IEnumerable<Movie>> GetUpcomingMovies()
        {
            var handler = new MovieCommandHandler();
            return await handler.Getupcomingmovies();

        }

        [HttpGet]
        [Route("Getnowplaying")]
        public async Task<IEnumerable<Movie>> GetNowPlaying()
        {
            var handler = new MovieCommandHandler();
            return await handler.Getnowplaying();

        }
    }
}
