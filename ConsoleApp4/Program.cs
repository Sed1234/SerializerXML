using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib;
using Newtonsoft.Json.Serialization;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.IO;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //SerializeSOAP SP = new SerializeSOAP(@"C:\Users\КимС\Desktop\MOCK.csv");
            //SP.SerializationFile();
            //foreach(Person a in SP.DeserializeFile())
            //{
            //    Console.WriteLine("Name - {0} Phone - {1}", a.Name, a.Phone);
            //}

            SerializeJSON Js = new SerializeJSON(@"C:\Users\КимС\Desktop\MOCK.csv");
            Js.SerializationFile();
             foreach (Person p in Js.DeserializeFile())
                {
                    Console.WriteLine("Имя: {0} --- Mail: {1}", p.Name, p.Email);
                }
            


            // EventService.DoEvent(EventPCLog.ON, ClassLib.PC("HP", "S123!", "ffx800", 1500));
        }
    }
}
