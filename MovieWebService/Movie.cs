using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MovieWebService
{
    [DataContract]
   public class Movie
    {
        [DataMember]
        public int Id;
        [DataMember]
        public string Title;
        [DataMember]
        public int Rating;

    }
}
