using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class MovieRepository
    {
        public Movie GetMovie(int id)
        {
            var dbContext = new MovieDataContext();
            return dbContext.Movies.FirstOrDefault(m => m.id == id);
        }
        
        public List<Movie> GetMovies()
        {
            var dbContext = new MovieDataContext();
            return dbContext.Movies.ToList();
        }
    }
}
