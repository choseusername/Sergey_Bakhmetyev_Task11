using System;
using System.Collections.Generic;
using System.Linq;

namespace Task3
{
    class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            List<int> hashes = new List<int>();

            for (int i = 0; i < 1000000; ++i)
                hashes.Add(new TwoDPointWithHash(random.Next(), random.Next()).GetHashCode());

            Console.WriteLine("Коллизии distinct {0}  hashes {1}, percente {2}", hashes.Distinct().Count(), hashes.Count(), 100.0 - (double)hashes.Distinct().Count()/ (double)hashes.Count() * 100.0);
            Console.ReadKey();
        }
    }
}
