using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace HospitalEmployeeMangmentSystem.EmployeeMangmentSystem
{
    public class EmployeeXML
    {
        //[XmlAttribute("name")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
    }
}
