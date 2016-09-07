using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace MovieWebService
{
    [ServiceBehavior(InstanceContextMode =InstanceContextMode.PerCall)]
    public class MovieService : IMovieService
    {
        
        
        public Movie GetMovie(int id)
        {
            var repo = new MovieRepository();

            var movie = repo.GetMovie(id);

            if (movie != null) return new Movie{ Id = movie.id, Title = movie.title, Rating = movie.rating};

            DataBaseFault fault = new DataBaseFault
            {
                OperationName = "Get movie by Id",
                ExceptionMessage = "No Movie found by the requested Id"
            };
            throw new FaultException<DataBaseFault>(fault);
        }

        public List<Movie> GetMovies()
        {
            var repo = new MovieRepository();
            var movies = repo.GetMovies()
                .Select(movie => new Movie { Id = movie.id, Title = movie.title, Rating = movie.rating})
                .ToList();

            if (movies.Count != 0) return movies;

            DataBaseFault fault = new DataBaseFault
            {
                OperationName = "Get all Movies",
                ExceptionMessage = "No Movies found"
            };
            throw new FaultException<DataBaseFault>(fault);
        }
    }
}
