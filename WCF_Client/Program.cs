using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCF_Client.MovieServiceReference;

namespace WCF_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press <Enter> to run the client...");
            Console.ReadLine();

        
            
                var client = new MovieServiceClient("WSHttpBinding_IMovieService");
                foreach (var movies in client.GetMovies())
                {
                    Console.WriteLine(movies.Title + " / " + movies.Rating);
                }

                Console.ReadLine();
            

        }
    }
}

