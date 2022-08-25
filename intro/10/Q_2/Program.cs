using System;

namespace Q_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("수비수가 1 이상 100이하의 숫자를 무작위로 고릅니다.");
            Random random = new Random();
            int Number = random.Next(1, 101);
            int guesses = 0;
            Console.WriteLine(Number);
            while (true)
            {
                Console.WriteLine("공격수가 숫자를 입력합니다.");
                guesses = int.Parse(Console.ReadLine());

                if (guesses > Number)
                {
                    Console.WriteLine("더 작은 숫자입니다.");
                }
                else if (guesses < Number)
                {
                    Console.WriteLine("더 큰 숫자입니다.");
                }
                else
                {
                    Console.WriteLine("정답입니다.");
                    break;
                }
            }*/                                                                                 // 심화 10-1

            Console.WriteLine("1은 가위, 2는 바위, 3은 보입니다.");
            Random random = new Random();
            int RSP = random.Next(1, 4);
            Console.WriteLine(RSP);
            int guesses = 0;

            while (true)
            {
                Console.WriteLine("1, 2, 3 중에 하나를 고르세요");
                guesses = int.Parse(Console.ReadLine());

                if (RSP == 1)
                {
                    if (guesses == 2)
                    {
                        Console.WriteLine("이겼습니다.");
                        break;
                    }
                    else if (guesses == 3)
                    {
                        Console.WriteLine("졌습니다.");
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (RSP == 2)
                {
                    if (guesses == 1)
                    {
                        Console.WriteLine("졌습니다.");
                        break;
                    }
                    else if (guesses == 3)
                    {
                        Console.WriteLine("이겼습니다.");
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    if (guesses == 1)
                    {
                        Console.WriteLine("이겼습니다.");
                        break;
                    }
                    else if (guesses == 2)
                    {
                        Console.WriteLine("졌습니다.");
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }
    }
}
