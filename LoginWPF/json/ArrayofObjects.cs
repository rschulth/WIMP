using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LoginWPF.json
{
    [DataContract]
    class ArrayofObjects
    {

        [DataMember(Name = "Object")]
        internal Item[] item { get; set; }
        
     
    }
}
