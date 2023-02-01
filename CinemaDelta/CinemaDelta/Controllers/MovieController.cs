using CinemaDelta.Core.Entities;
using CinemaDelta.Core.Interfaces.Repositories;
using CinemaDelta.Core.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Eventing.Reader;

namespace CinemaDelta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController: Controller
    {
        public readonly IMovieService _movieService;

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpPost]
        [Route("")]
        public void CreateMovie(Movie movie)
        {
            _movieService.AddMovie(movie);
        }
    }
}
