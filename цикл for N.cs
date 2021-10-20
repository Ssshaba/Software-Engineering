using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace цикл_for_N
{
    class Program
    {
        static void Main(string[] args)
        {
            double N;
            int summ;
            summ = 0;
            N = Convert.ToDouble(Console.ReadLine());
            for ( int i = 1 ; i <= N ; i++)
            {
                summ += i;
            }
            Console.WriteLine("сумму первых {0} членов арифметической прогрессии = {1}", N, summ);
            Console.ReadLine();
        }
    }
}
