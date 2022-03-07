using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace SoapXml_WebCore.Models
{
    [DataContract]
    public class OperationModel
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Process { get; set; }
        [DataMember]
        public string Step { get; set; }
        [DataMember]
        public DateTime Schedule { get; set; }
        
    }
}