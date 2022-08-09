using System;

namespace Q_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int number = 2;
            number = number * 3;
            number = number - 4;
            number = number % 2;

            Console.WriteLine(number);      // 심화 4-1*/

            int coin = 10;
            int aram = (coin / 2) - 1;
            coin = coin - aram;
            Console.WriteLine("아람이가 가져간 동전: " + aram);
            int uram = (coin / 2) + 2;
            coin = coin - uram;
            Console.WriteLine("우람이가 가져간 동전: " + uram);
            Console.WriteLine("주머니에 남은 동전: " + coin);       // 심화 4-2
        }
    }
}
