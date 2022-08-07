using System;

namespace Constant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.Write("바구니 안에 담긴 사과의 개수: ");
            // Console.WriteLine(12);

            // Console.WriteLine(-2);

            // Console.Write("사과 바구니의 무게: ");
            // Console.WriteLine(1.32);

            string appleCountDescription = "바구니 안에 담긴 사과의 개수: ";
            Console.Write(appleCountDescription);
            int appleCount = 12;
            Console.WriteLine(appleCount);

            Console.WriteLine(-2);

            string basketWeigthDescription = "사과 바구니의 무게: ";
            Console.Write(basketWeigthDescription);
            double basketWeigth = 1.32;
            Console.WriteLine(basketWeigth);
        }
    }
}
