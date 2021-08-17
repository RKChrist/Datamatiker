using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Ex16_MorgenGry
{
    public class Course : IValuable
    {
        public string Name { get; set; }
        public int DurationInMinutes { get; set; }
        public static double CourseHourValue { get; set; } = 875.0;

        public Course(string name, int duration)
        {
            Name = name;
            DurationInMinutes = duration;
        }

        public Course(string name) : this(name, 0) {
            //CourseHourValue = 0;
        }

        // Inherit from interface
        public double GetValue()
        {
            int duration = DurationInMinutes;

            // Get hour count, rounds down.
            int hourCount = duration / 60;

            // Check if we have started a new hour
            if (duration % 60 > 0) hourCount++;

            return CourseHourValue * hourCount;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Duration in Minutes: {DurationInMinutes}, Pris pr påbegyndt time: {GetValue()}";
        }
    }
}
