﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            SerializeSOAP SP = new SerializeSOAP(@"C:\Users\КимС\Desktop\MOCK.csv");
            SP.SerializationFile();
            foreach(Person a in SP.DeserializeFile())
            {
                Console.WriteLine("Name - {0} Phone - {1}", a.Name, a.Phone);
            }
        }
    }
}
