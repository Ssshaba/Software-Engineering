using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace парные_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, s = 0, k = 0;
            N = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= N ; i = i + 2)
            {
                s += i;
                k++;
            }
            Console.WriteLine("{0} и {1}", s, k);
            Console.ReadLine();
        }
    }
}
