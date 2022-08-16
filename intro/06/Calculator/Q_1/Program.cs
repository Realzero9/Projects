using System;

namespace Q_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine(3 <= 5);
            Console.WriteLine(!(5 == 5));
            Console.WriteLine(!(3 < 2));
            Console.WriteLine(1 > 0);                                   // 기초 6-1*/

            /*Console.WriteLine("먹은 사과의 개수를 입력하세요.");
            int eatenAppleCount = int.Parse(Console.ReadLine());
            if (eatenAppleCount > 3)
            {
                Console.WriteLine("사과를 많이 먹었습니다.");
            }
            else if (eatenAppleCount < 3)
            {
                Console.WriteLine("사과를 조금 먹었습니다.");
            }
            else
            {
                Console.WriteLine("사과를 적절히 먹었습니다.");
            }                                                           // 기초 6-2*/

            Console.WriteLine("등수를 입력하세요");
            int rank = int.Parse(Console.ReadLine());
            Console.WriteLine("점수를 입력하세요");
            int score = int.Parse(Console.ReadLine());

            if (rank < 10 || score > 90)
            {
                Console.WriteLine("A입니다.");
            }                                                           // 기초 6-3
        }
    }
}
