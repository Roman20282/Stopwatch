using System;
using System.Collections.Generic;
using System.Text;

namespace Stopwatch
{
    internal class StopWatchClass
    {
        public DateTime Start()
        {
            DateTime startMoment = DateTime.Now;
            return startMoment;
        }

        public DateTime Stop()
        {
            DateTime stopMoment = DateTime.Now;
            return stopMoment;
        }
    }
}
