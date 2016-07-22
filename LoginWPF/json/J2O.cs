using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LoginWPF.json
{
    public static class J2O
    {

        public static T GetT<T>(string json) {
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T));
            MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(json));

            T obj = default(T);
            try
            {
                obj = (T) ser.ReadObject(stream);
            }
            catch (XmlException e)
            {
           
            }
            return obj;
        }
    }
}
