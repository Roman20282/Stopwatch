using System;
using System.Collections.Generic;
using System.Text;

namespace Stopwatch
{
    class StopWatchClass
    {
        public DateTime TStart { get; private set; }
        public DateTime TStop { get; private set; }

        public DateTime Start()
        {
            TStart = DateTime.Now;
            return TStart; 
        }
        public DateTime Stop()
        {
           TStop = DateTime.Now;
            return TStop;
        }
        public TimeSpan Interval()
        {
            return TStop - TStart;
        }      
    }
}
