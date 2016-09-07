using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MovieWebService
{
    [ServiceBehavior(InstanceContextMode =InstanceContextMode.PerCall)]
    public class MovieService : IMovieService
    {
        
        
        public Movie GetMovie(int Id)
        {

            Repo repo = new Repo();
            var movie = repo.Movies.FirstOrDefault(m => m.Id == Id);

            if (movie != null) return movie;

            DataBaseFault fault = new DataBaseFault();
            fault.OperationName = "Get movie by Id";
            fault.ExceptionMessage = "No Movie found by the requested Id";
            throw new FaultException<DataBaseFault>(fault);
        }

        public List<Movie> GetMovies()
        {
            Repo repo = new Repo();
            var movies = repo.Movies;


            if (movies.Count != 0) return movies;

            DataBaseFault fault = new DataBaseFault();
            fault.OperationName = "Get all Movies";
            fault.ExceptionMessage = "No Movies found";
            throw new FaultException<DataBaseFault>(fault);
        }
    }
}
