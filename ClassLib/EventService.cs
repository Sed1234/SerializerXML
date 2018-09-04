using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ClassLib
{
    class EventService
    {
        public static void DoEvent(EventPCLog log, PC pc)
        {
            EventPC logPC = new EventPC();
            logPC.Event = log;
            logPC.pc = pc;
            logPC.EventDate = DateTime.Now;



        }
    }
}
