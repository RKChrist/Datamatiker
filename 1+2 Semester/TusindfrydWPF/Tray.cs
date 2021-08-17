using System;
using System.Collections.Generic;
using System.Text;

namespace TusindfrydWPF
{
    public class Tray
    {
        public string Name { get; set; }
        public double Size { get; set; }
        public Greenhouse HoldingGreenhouse { get; set; }

        public Tray(string name, double size, Greenhouse gHouse)
        {
            Name = name;
            Size = size;
            HoldingGreenhouse = gHouse;
        }
    }
}
