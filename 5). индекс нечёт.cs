using System;

namespace _5_._индексы_нечёт
{
    class Program
    {
        static void Main(string[] args)
        {
       
           var n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int [n];
            int i, sum;
            arr = Array.ConvertAll(Console.ReadLine().Split(" "), s => int.Parse(s));
            sum = 0;
            for (i = 0; i < arr.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sum += arr[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
