using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workers_salaries
{
    class Program
    {
        static void Main(string[] args)
        {
            //payment for the first individual
            int hours = 40;
            double rate = 8.43;
            var grosspay = hours * rate;
            var netpay = 0.8 * grosspay;
            Console.WriteLine("payment for the first individual");
            Console.WriteLine($"the grosspay is { grosspay}");
            Console.WriteLine($"the netpay is{netpay}");
            //payment for the second individual
            int workhours =35;
            double salrate = 5.67;
            var Grosspay = workhours *salrate;
            var Netpay = 0.8 * Grosspay;
            Console.WriteLine("payment for the second individual");
            Console.WriteLine($"the grosspay is { Grosspay}");
            Console.WriteLine($"the netpay is{Netpay}");

            Console.ReadKey();
        }
    }
}
