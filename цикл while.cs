using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace цикл_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int p, f = 1, i = 1;
            p = Convert.ToInt32(Console.ReadLine());
            do
            {
                f *= i;
                i++;
            }
            while (i <= p);
            Console.WriteLine("факториал = {0}",f);
            Console.ReadLine();

        }
       
    }
}
