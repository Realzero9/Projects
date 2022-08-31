using System;

namespace Q_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 심화 10-1
            /*Console.WriteLine("수비수가 1 이상 100이하의 숫자를 무작위로 고릅니다.");
            Random random = new Random();
            int Number = random.Next(1, 101);
            Console.WriteLine(Number);
            while (true)
            {
                Console.WriteLine("공격수가 숫자를 입력합니다.");
                bool isNumber = int.TryParse(Console.ReadLine(), out int guesses);
                if (!isNumber)
                {
                    Console.WriteLine("숫자를 입력해 주세요.");
                }
                else
                {
                    bool isTrue = (guesses >= 0 && guesses <= 100);
                    if (!isTrue)
                    {
                        Console.WriteLine("1이상 100이하의 숫자를 입력해주세요.");
                    }
                    else
                    {
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
                    }
                }
            }*/

            // 가위바위보 게임(심화 10-2)
            Console.WriteLine("1은 가위, 2는 바위, 3은 보입니다.");
            Random random = new Random();
            int RSP = random.Next(1, 4);
            Console.WriteLine(RSP);

            Console.WriteLine("1, 2, 3 중에 하나를 고르세요.");
            while (true)
            {
                // 문자 확인
                bool isNumber = int.TryParse(Console.ReadLine(), out int guesses);
                if (!isNumber)
                {
                    Console.WriteLine("숫자를 입력해 주세요.");
                }
                else
                {
                    // 숫자 확인
                    bool isTrue = (guesses <= 3 && guesses > 0);
                    if (!isTrue)
                    {
                        Console.WriteLine("1, 2, 3 중에 하나를 고르세요?");
                    }
                    else
                    {
                        // 결과 확인
                        if ((RSP == 1 && guesses == 2) || (RSP == 2 && guesses == 3) || (RSP == 3 && guesses == 1))
                        {
                            Console.WriteLine("이겼습니다.");
                            break;
                        }
                        else if ((RSP == 1 && guesses == 3) || (RSP == 2 && guesses == 1) || (RSP == 3 && guesses == 2))
                        {
                            Console.WriteLine("졌습니다.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("비겼습니다.");
                            Console.WriteLine("숫자를 다시 입력해 주세요.");
                        }
                    }
                }
            }
        }
    }
}
