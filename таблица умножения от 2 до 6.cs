using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace таблица_умножения
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j; // i-- на что умножают  j--что умножают 
            for (i = 1; i <= 10; i++)
            {
                for (j = 2; j <= 6; j++)
                {
                    Console.Write($"{j} * {i} = {j *i}\t");
                }
                Console.WriteLine();
                
            }
            Console.ReadLine();
        }
    }
}
