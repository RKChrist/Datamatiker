using System;
using System.Collections.Generic;
using System.Text;

namespace Ex16_MorgenGry
{
    public abstract class Merchandise
    {
        public string ItemId { get; set; }

        public override string ToString()
        {
            return $"ItemId: {ItemId}";
        }
    }
}
