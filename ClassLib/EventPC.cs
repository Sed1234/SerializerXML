using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLib
{
   public enum EventPCLog { ON, OFF, RESET}
   public  class EventPC
    {
        public DateTime EventDate { get; set; }
        public EventPCLog Event { get; set; }

        public PC pc = new PC();

    }
}
