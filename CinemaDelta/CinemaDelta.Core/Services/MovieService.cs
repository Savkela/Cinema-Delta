using CinemaDelta.Core.Entities;
using CinemaDelta.Core.Interfaces.Repositories;
using CinemaDelta.Core.Interfaces.Services;

namespace CinemaDelta.Core.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public void AddMovie(Movie movie)
        {
            _movieRepository.AddMovie(movie);
        }
    }
}
