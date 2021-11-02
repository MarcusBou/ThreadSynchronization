using System;
using System.Threading;

namespace Øvelse_1
{
    class Program
    {
        static void Main(string[] args)
        {
           CountingProcess cp = new CountingProcess();

            Thread up = new Thread(cp.CountUp);
            Thread down = new Thread(cp.CountDown);
            up.Start();
            down.Start();
        }
    }
}
