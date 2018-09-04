using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLib
{
    public class PC
    {
        public string Mark { get; set; }
        public string Number { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }

        public PC(string mark, string number, string model, int price)
        {
            Mark = mark;
            Number = number;
            Model = model;
            Price = price;
        }

        public PC()
        { }
    }
}
