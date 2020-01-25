using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using Newtonsoft.Json;



namespace AdapterDesignPattern
{ 
   public  class EmployeeAdapter : AdapterDesignPattern.EmployeeManager, IEmployee
    {
        public override string GetAllEmployees()
        {
            string returnXML =  base.GetAllEmployees();
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(returnXML);
            return JsonConvert.SerializeObject(doc, Newtonsoft.Json.Formatting.Indented);
        }


    }
}
