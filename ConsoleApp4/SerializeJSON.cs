using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Serialization;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace ConsoleApp4
{
    class SerializeJSON
    {
        private string path { get; set; }
        public SerializeJSON(string path)
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
            List<Person> read = OpenFile();
            DataContractJsonSerializer sf = new DataContractJsonSerializer(typeof(List<Person>));
            using (FileStream fs = new FileStream("soap.json", FileMode.OpenOrCreate))
            {
                sf.WriteObject(fs, read);
            }
        }

        public List<Person> DeserializeFile()
        {
            List<Person> read = null;
            DataContractJsonSerializer sf = new DataContractJsonSerializer(typeof(List<Person>));
            using (FileStream fs = new FileStream("soap.json", FileMode.OpenOrCreate))
            {
                read = (sf.ReadObject(fs) as List<Person>);

            }
            return read;
        }
    }
}