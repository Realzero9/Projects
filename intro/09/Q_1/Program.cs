using System;

namespace Q_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("몇 명의 친구들에게 사과를 나눠줄까요?");
            int friendCount = int.Parse(Console.ReadLine());

            int[] appleNumbers = new int[friendCount];
            *//*int index = 0;

            while (index < friendCount)
            {
                Console.Write(index);
                Console.WriteLine("번째 친구가 가져갈 사과는 몇 개인가요?");
                appleNumbers[index] = int.Parse(Console.ReadLine());
                index = index + 1;
            }

            index = 0;

            while (index > friendCount)
            {
                Console.Write(index);
                Console.Write("번째 친구가 가져간 사과의 개수는 ");
                Console.Write(appleNumbers[index]);
                Console.WriteLine("개입니다.");
                index = index + 1;
            }*//*

            for (int index = 0; index < friendCount; index++)
            {
                Console.Write(index);
                Console.WriteLine("번째 친구가 가져갈 사과는 몇 개인가요?");
                appleNumbers[index] = int.Parse(Console.ReadLine());
            }

            for (int index = 0; index < friendCount; index++)
            {
                Console.Write(index);
                Console.Write("번째 친구가 가져간 사과의 개수는 ");
                Console.Write(appleNumbers[index]);
                Console.WriteLine("개입니다.");
            }                                                                               // 기초 9-1*/

            /*int[] scores = new int[5];
            *//*Console.Write(0);
            Console.WriteLine("번째 과목의 성적을 입력하세요.");
            scores[0] = int.Parse(Console.ReadLine());

            Console.Write(1);
            Console.WriteLine("번째 과목의 성적을 입력하세요.");
            scores[1] = int.Parse(Console.ReadLine());

            Console.Write(2);
            Console.WriteLine("번째 과목의 성적을 입력하세요.");
            scores[2] = int.Parse(Console.ReadLine());

            Console.Write(3);
            Console.WriteLine("번째 과목의 성적을 입력하세요.");
            scores[3] = int.Parse(Console.ReadLine());

            Console.Write(4);
            Console.WriteLine("번째 과목의 성적을 입력하세요.");
            scores[4] = int.Parse(Console.ReadLine());*//*

            for (int i = 0; i < 5; i++)
            {
                Console.Write(i);
                Console.WriteLine("번째 과목의 성적을 입력하세요.");
                scores[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("총점은 ");
            Console.Write(scores[0] + scores[1] + scores[2] + scores[3] + scores[4]);
            Console.WriteLine("점입니다.");                                                 // 기초 9-2*/

            for (int i = 2; i <= 9; i = i + 2)
            {
                Console.Write(i);
                Console.WriteLine("단");
                for (int j = 1; j <= 9; j++)
                {
                    Console.Write(i);
                    Console.Write("x");
                    Console.Write(j);
                    Console.Write(" = ");
                    Console.Write(i * j);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }                                                                               // 기초 9-3
        }
    }
}
