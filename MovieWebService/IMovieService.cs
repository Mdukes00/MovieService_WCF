using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MovieWebService
{
    [ServiceContract]
    public interface IMovieService
    {
        [OperationContract]
        [FaultContract(typeof(DataBaseFault))]
        List<Movie> GetMovies();
        [OperationContract]
        [FaultContract(typeof(DataBaseFault))]
        Movie GetMovie(int Id);

    }

}
