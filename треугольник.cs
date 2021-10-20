using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace треугольник
{
    class Program
    {
        static void Main(string[] args)
        {
            int st = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= st; i++) 
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write('*');
                    

                    
                }
                Console.WriteLine();
                
            }
            Console.ReadLine();
        }
        
        
    }
}
