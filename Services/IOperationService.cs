using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;
using SoapXml_WebCore.Models;


namespace SoapXml_WebCore.Services
{
    [ServiceContract]
    public interface IOperationService
    {
        [OperationContract]
        string Operation(string s);
        [OperationContract]
        string XmlMethod(System.Xml.Linq.XElement xml);
        [OperationContract]
        OperationModel TestModel(OperationModel machine);
    }
}