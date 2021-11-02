using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Opgave_2_og_3
{
    class Printers
    {
        private static readonly object Locker = new object();
        int charUsed;

        /// <summary>
        /// Prints The charPrinting 60 times and adds 60 to how many chars has been used
        /// It uses lock for thread synchronization, so the action is locked when Star printer is printing.
        /// At the end it adds how many chars has been used and uses monitor pulseall to notice the other lock that the printer is free now
        /// </summary>
        public void HashtagPrinter(object charPrinting)
        {
            while (true)
            {
                lock (Locker)
                {
                    for (int i = 0; i < 60; i++)
                    {
                        Console.Write(charPrinting);
                        charUsed++;
                    }
                    Console.Write("     " + charUsed);
                    Console.WriteLine();
                    Monitor.PulseAll(Locker);
                    Thread.Sleep(200);
                }
            }
        }
    }
}
