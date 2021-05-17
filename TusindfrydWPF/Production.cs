using System;
using System.Collections.Generic;
using System.Text;

namespace TusindfrydWPF
{
    public class Production
    {
        public string ProductionId { get; set; }
        public DateTime StartDate { get; set; }
        public int StartAmount { get; set; }
        public int ExpectedEndAmount { get; set; }
        public bool Completed { get; set; }

        // Information from other objects, saved in this production object.
        public Tray ProductionTray { get; set; }
        public Count ProductionCount { get; set; }
        public FlowerSort ProductionFlower { get; set; }
        public Worker ProductionWorker { get; set; }

        // Constructor
        public Production(string prodId, DateTime startDate, int startAmount, int expectEnd, bool completed = false)
        {
            ProductionId = prodId;
            StartDate = startDate;
            StartAmount = startAmount;
            ExpectedEndAmount = expectEnd;
            Completed = completed;  
        }
    }
}
