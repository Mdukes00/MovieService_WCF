using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieWebService
{
    public class Repo
    {
        public List<Movie> Movies;
        public Repo()
        {
            Movies = new List<Movie>();

            for (var i = 0; i < 10; i++)
            {
                Movies.Add(new Movie { Id = i, Rating = i + 2 / 3, Title = "Test " + i });

            }
        }

    }
}
