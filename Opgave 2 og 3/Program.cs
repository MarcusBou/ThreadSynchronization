using System;
using System.Threading;

namespace Opgave_2_og_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Printers p = new Printers();    
            Thread Hash = new Thread(p.HashtagPrinter);
            Thread Star = new Thread(p.HashtagPrinter);
            Star.Start('#');
            Hash.Start('*');

        }
    }
}
