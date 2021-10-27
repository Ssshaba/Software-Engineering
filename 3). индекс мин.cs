using System;

namespace _3_._индекс_мин
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            var n = Console.ReadLine();
            var arr = Array.ConvertAll(Console.ReadLine() .Split(" "), s => int.Parse(s));
            int minn = 99999111;
            for (i = 0; i < arr.Length; i++)
            {
                if (minn > arr[i])
                {
                    minn = arr[i];
                }
                
            }
            Console.WriteLine(minn);
            Console.WriteLine( Array.IndexOf(arr,minn));
            Console.ReadLine();
        }
    }
}
