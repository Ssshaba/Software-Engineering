using System;

namespace массивы
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("------------");
            var arr = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s)); // . Parse == из строки в int
            Console.WriteLine("------------");
            int maxx = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (maxx < arr[i])
                {
                    maxx = arr[i];

                }
            }
            Array.Sort(arr);
            Array.Reverse(arr);
            for (int x = 0; x < arr.Length; x++)
            {
                Console.WriteLine(arr[x] + " ");

            }
            Console.WriteLine("------------");
            Console.WriteLine(maxx);
        }
    }
}