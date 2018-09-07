using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Soap;
using Newtonsoft.Json.Serialization;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;


namespace ConsoleApp4
{
    [Serializable]
    public class SerializeSOAP
    {
        private string path { get; set; }
        public SerializeSOAP (string path)
        {
            this.path = path;
        }
        public List<Person> OpenFile()
        {
            List<Person> persons = new List<Person>();
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Person per = new Person();
                    string[] sline = line.Split(',');

                    per.Name = sline[0];
                    per.Last = sline[1];
                    per.Email = sline[2];
                    per.Phone = sline[3];
                    persons.Add(per);

                }
            }
            return persons;
        }

        public void SerializationFile()
        {
            List<Person> read =  OpenFile();
            SoapFormatter sf = new SoapFormatter();
            using (FileStream fs = new FileStream("soap.txt", FileMode.OpenOrCreate))
            {
                sf.Serialize(fs,read.ToArray());
            }
        }

        public List<Person>  DeserializeFile()
        {
            List<Person> read = null;
            SoapFormatter sf = new SoapFormatter();
            using (FileStream fs = new FileStream("soap.txt", FileMode.OpenOrCreate))
            {
                read = (sf.Deserialize(fs) as Person[]).ToList();

            }
            return read;
        }

    }
}