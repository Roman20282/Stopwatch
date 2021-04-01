using System;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            //                               Programm Stopwatch. 
            //=============================================================================================
            //  The job of this programm is to simulate a stopwatch. 
            //It provide two methods: Start and Stop.We call the start method first,
            //and the stop method next. Then we ask the stopwatch about the duration between start and stop.
            //Duration is a value in TimeSpan.
            //Programm display the duration on the console.
            //We also is able to use a stopwatch multiple times.
            //So we may start and stop it and then start and stop it again. 
            //We can't to start a stopwatch twice in a row (because that may overwrite the initial start time). 
            //=============================================================================================
           
            string pressedKey ="";
            bool stopwatchOK;
            do
            {
                StopWatchClass sw = new StopWatchClass();
                do
                {
                    
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("******************Stopwatch program**************************\n");
                        Console.WriteLine("For starting press \"s\". For stop press \"s\" again and Enter.");
                        Console.WriteLine("00:00:00");
                    }
                    while (Console.ReadLine() != "s");
                    sw.Start();
                        while(pressedKey != "s")
                        {
                            Console.Clear();
                            Console.WriteLine("Start:   {0}     For stop press \"s\" and Enter.", sw.TStart.ToLongTimeString());
                            pressedKey = Console.ReadLine();

                        }
                    stopwatchOK = true;
                    pressedKey = "";
                }
                while (!stopwatchOK);
                sw.Stop();
                Console.Clear();
                Console.WriteLine("Start time:   {0}", sw.TStart.ToLongTimeString());
                Console.WriteLine(" Stop time:   {0}", sw.TStop.ToLongTimeString());
                Console.WriteLine(" Time span:   {0}", sw.Interval());
                Console.WriteLine("In oder to stop program press \"q\" and Enter. ");
                Console.WriteLine("Press any key...");
            } 
            while (Console.ReadLine() != "q"); 
            
        }

    }
    
}
