using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LoginWPF.json
{
    [DataContract]
    class Item
    {

        [DataMember]
        internal string name { get; set; }
        
        [DataMember]
        internal int time { get; set; }

        [DataMember]
        internal int crop { get; set; }

        [DataMember]
        internal int sx { get; set; }

        [DataMember]
        internal int sy { get; set; }

        [DataMember]
        internal string img { get; set; }

        [DataMember]
        internal string category { get; set; }

        [DataMember]
        internal int level { get; set; }
        
        [DataMember]
        public bool plantable { get; set; }

        [DataMember]
        public double clear { get; set; }
     
    }
}
