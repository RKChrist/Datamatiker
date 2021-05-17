using System;
using System.Collections.Generic;
using System.Text;

namespace Ex16_MorgenGry
{
    public class Amulet : Merchandise, IValuable
    {
        // Properties auto-implement
        public string Design { get; set; }
        public Level Quality { get; set; }
        public static double LowQualityValue { get; set; } = 12.5;
        public static double MediumQualityValue { get; set; } = 20.0;
        public static double HighQualityValue { get; set; } = 27.5;

        /// <summary>
        /// The main constructor for the class.
        /// </summary>
        /// <param name="itemId">The id for the item being created.</param>
        /// <param name="quality">The quality level of the item.</param>
        /// <param name="design">The design of the item.</param>
        public Amulet(string itemId, Level quality, string design)
        {
            base.ItemId = itemId;
            Design = design;
            Quality = quality;
        }

        // Overload constructors
        public Amulet(string itemId, Level quality) : this(itemId, quality, "") { }
        public Amulet(string itemId) : this(itemId, (Level)1, "") { }

        // Inherit from interface
        public double GetValue()
        {
            double returnValue = 0;
            switch (Quality)
            {
                case (Level)0:
                    returnValue = LowQualityValue;
                    break;
                case (Level)1:
                    returnValue = MediumQualityValue;
                    break;
                case (Level)2:
                    returnValue = HighQualityValue;
                    break;
                default:
                    returnValue = 0;
                    break;
            }
            return returnValue;
        }

        // Override.
        public override string ToString()
        {
            return $"ItemId: {ItemId}, Quality: {Quality}, Design: {Design}";
        }
    }
}
