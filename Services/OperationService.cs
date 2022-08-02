
using System;
using System.Xml.Linq;
using SoapXml_WebCore.Models;
using SoapXml_WebCore.Services;

namespace SoapXml_WebCore.Services
{
    public class OperationService : IOperationService
    {
        string IOperationService.Operation(string s)
        {
            Console.WriteLine(s + " XYZABC");
            return s;
        }

        OperationModel IOperationService.TestModel(OperationModel model)
        {
            return model;
        }

        string IOperationService.XmlMethod(XElement xml)
        {
            return xml.ToString();
        }
    }
}
