//using System;

//namespace TusindfrydWPF
//{
//    class dsaProgram
//    {
//        static void Main(string[] args)
//        {
//            #region Create dummy info
//            // Create worker
//            Worker workerHans = new Worker();
//            workerHans.Initials = "HW";

//            // Greenhouse
//            Greenhouse greenhouse1 = new Greenhouse();
//            greenhouse1.Number = 1;

//            // Tray
//            Tray tray1 = new Tray("Cool Tray", 10, greenhouse1);

//            // Flower sort
//            FlowerSort flower1 = new FlowerSort();
//            flower1.Name = "Virkelyst";
//            flower1.HalfLifeTime = 7;
//            flower1.ProductionTime = 2;
//            flower1.Size = 19 + 2;

//            // Production
//            Production p1 = new Production("P001", DateTime.Now, 519, 11);
//            p1.ProductionFlower = flower1;
//            p1.ProductionTray = tray1;
//            p1.ProductionCount = null;
//            p1.ProductionWorker = workerHans;

//            #endregion

//            // New instance of Controller.
//            Controller c = new Controller();

//            // Add production to list of productions.
//            c.AddToList(p1);

//            // Find a specific production
//            Production foundP = c.productionRepo.GetProduction("P001");

//            // CW stuff out from the production
//            Console.WriteLine($"Flower name: {foundP.ProductionFlower.Name}");
//            Console.WriteLine($"Greenhouse Number: {foundP.ProductionTray.HoldingGreenhouse.Number}");
//            Console.WriteLine($"Start date: {foundP.StartDate}");
//            Console.WriteLine($"Is production completed: {foundP.Completed}");
//        }
//    }
//}
