using System;

namespace _0___среднее_арифметическое
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            var n = Console.ReadLine();
            var arr = Array.ConvertAll(Console.ReadLine().Split(" "), s => double.Parse(s));
            Double sum_arr = 0;
            Double sr;
            for (i = 0; i < arr.Length; i++)
            {
                sum_arr += arr[i];
            
            sr = sum_arr / arr.Length;
                for (i = 0; i < arr.Length; i++)
                {
                    
                    sum_arr += arr[i];
                    if (arr[i] == 0) {
                        arr[i] = sr;
                }
                Console.WriteLine(arr[i] + " ");
            }
            Console.Read();
        }
    }
}
