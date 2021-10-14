using System;

namespace цена_со_скидкой
{
    class Program
    {
        static void Main(string[] args)
        {
            int price, price_end;
            price_end = 1;
            price = Convert.ToInt32(Console.ReadLine());
            if (price >= 500 && price < 1000)
            {
                price_end = price * 97 / 100;
            }
            if (price >= 1000)
            {
                price_end = price * 95 / 100;
            }
            if (price_end < 500)
            {
                price_end = price;
            }
            Console.WriteLine(price_end);
        }
    }
}
