using System;

namespace Q_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int number = 2;
             number = number * 3;
             number = number - 4;
             number = number % 2;

             Console.WriteLine(number);*/

            int coin = 10;
            int aram = (coin / 2) - 1;
            coin = coin - aram;
            Console.WriteLine(aram);
            int uram = (coin / 2) + 2;
            coin = coin - uram;
            Console.WriteLine(uram);
            Console.WriteLine(coin);

        }
    }
}
