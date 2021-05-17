using System;
using System.Collections.Generic;
using System.Text;

namespace TusindFryd
{
    public class FlowerVariety
    {
        public string Name { get; set; }
        public int ProductionTimeInDays { get; set; }
        public int HalflifeInDays { get; set; }
        public double Size { get; set; } // Den her er lidt abstrakt, skal have clarified den lidt mere.
    }
}
