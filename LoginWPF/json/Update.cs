using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

// {"success":1,"bar":"5.259,20 wT","points":"201344729","coins":"10","level":"Wurzelimperator","levelnr":"22","mail":0,"contracts":0,"lng_con":"Vertr\u00e4ge","lng_mail":"Nachrichten","time":1413398679,"g_tag":"[RLH]","reload_lager":false,"achievements":null,"toNextLevel":98655271}

namespace LoginWPF.json
{ 
    [DataContract]
    public class Update
    {
        [DataMember]
        internal string success;

        [DataMember]
        internal string bar;

        [DataMember]
        internal string points;

        [DataMember]
        internal string coins;

        [DataMember]
        internal string level;

        [DataMember]
        internal string levelnr;
       
        [DataMember]
        internal int mail;
        
        [DataMember]
        internal int contracts;

        [DataMember]
        internal string lng_con;

        [DataMember]
        internal string lng_mail;

        [DataMember]
        internal long time;

        [DataMember]
        internal string g_tag;
        
        [DataMember]
        internal bool reload_lager;
        
        [DataMember]
        internal string achievements;
        
        [DataMember]
        internal long toNextLevel;
    }
}
