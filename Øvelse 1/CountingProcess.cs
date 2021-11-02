using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Øvelse_1
{
    class CountingProcess
    {
        private object locker = new object();
        private int counter = 0;

        public void CountUp()
        {
            while (true)
            {
                Monitor.Enter(locker);
                counter = counter + 2;
                Console.WriteLine("counter has gone up it is now: " + counter);
                Monitor.Exit(locker);
                Thread.Sleep(1000);
            }
        }

        public void CountDown()
        {
            while (true)
            {
                Monitor.Enter(locker);
                counter--;
                Console.WriteLine("Counter has gone down it is now: " + counter);
                Monitor.Exit(locker);
                Thread.Sleep(1000);
            }
        }
    }
}
