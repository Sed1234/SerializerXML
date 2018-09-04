using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using ClassLib;


namespace ClassLib
{
    public class EventService
    {
        public static void DoEvent(EventPCLog log, PC pc)
        {
            EventPC logPC = new EventPC();
            logPC.Event = log;
            logPC.pc = pc;
            logPC.EventDate = DateTime.Now;

            XmlSerializer formater = new XmlSerializer(logPC.GetType());
            FileStream fs = new FileStream(DateTime.Now.Ticks + ".xml", FileMode.OpenOrCreate);
            formater.Serialize(fs, log);
            fs.Close();

        }
    }
}
