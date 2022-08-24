using System;

namespace Q_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine(random.Next(3, 10));
        }
    }
}
