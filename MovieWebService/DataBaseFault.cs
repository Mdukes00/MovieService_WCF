using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MovieWebService 
{
    [DataContract]
    public class DataBaseFault
    {
        [DataMember]
        public string OperationName;

        [DataMember]
        public string ExceptionMessage;
    }
}
