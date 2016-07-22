using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace LoginWPF.json
{
    [DataContract]
    public class Dispatch
    {

        [DataMember]
        internal string status;

        [DataMember]
        internal string message;

        [DataMember]
        internal string url;
    }
}
