using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Soap;

namespace ConsoleApp4
{
    [Serializable]
    public class Person
    {
        public string Name { get; set; }
        public string Last { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}