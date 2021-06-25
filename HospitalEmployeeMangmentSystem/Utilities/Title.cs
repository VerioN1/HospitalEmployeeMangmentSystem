using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalEmployeeMangmentSystem.Utilities
{
    public class Title
    {
        public string Name { get; private set; }
        public string TranslatedName { get; private set; }
        public Title(string Name, string TranslatedName)
        {
            this.Name = Name;
            this.TranslatedName = TranslatedName;
        }
    }
}
