using System;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            //                Programm Stopwatch. 
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
           
            StopWatchClass sw = new StopWatchClass();
            DateTime tStart, tStop;
            TimeSpan interval;
            string s1, s2, pressedKey ="";
            bool stopwatchOK;
            do
            {
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
                    tStart = sw.Start();
                    s1 = tStart.ToLongTimeString();

                    
                    while(pressedKey != "s")
                    {
                        Console.Clear();
                        Console.WriteLine("Start:   {0}     For stop press \"s\" and Enter.", s1);
                        pressedKey = Console.ReadLine();

                    }
                    stopwatchOK = true;
                    pressedKey = "";
                }
                while (!stopwatchOK);
                tStop = sw.Stop();
                s2 = tStop.ToLongTimeString();
                stopwatchOK = false;
                Console.Clear();
                Console.WriteLine("Start time:   {0}", s1);
                Console.WriteLine(" Stop time:   {0}", s2);
                interval = tStop - tStart;
                Console.WriteLine(" Time span:   {0}",interval);
                Console.ReadLine();
                Console.WriteLine("In oder to stop program press \"q\" and Enter. ");
                
            } 
            while (Console.ReadLine() != "q"); 
            
        }

    }
    
}
