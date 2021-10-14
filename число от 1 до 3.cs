using System;

namespace число_от_1_до_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            if ((a >= 1) && (a <= 3))
            {
                Console.WriteLine(a);
            }
            if ((b >= 1) && (b <= 3))
            {
                Console.WriteLine(b);
            }
            if ((c >= 1) && (c <= 3))
            {
                Console.WriteLine(c);
            }
        }
    }
}
