using System;

namespace UltimateBaseball
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. 숫자야구 설명
            Console.WriteLine("+----------------------------------------------------+");
            Console.WriteLine("|               궁극의 숫자야구 게임                 |");
            Console.WriteLine("+----------------------------------------------------+");
            Console.WriteLine("|컴퓨터가 수비수가 되어 세 자릿수를 하나 골랐습니다. |");
            Console.WriteLine("|각 숫자는 0~9중에 하나며 중복되는 숫자는 없습니다.  |");
            Console.WriteLine("|모든 숫자와 위치를 맞히면 승리합니다.               |");
            Console.WriteLine("|숫자와 순서가 둘 다 맞으면 스트라이크입니다.        |");
            Console.WriteLine("|숫자만 맞고 순서가 틀리면 볼입니다.                 |");
            Console.WriteLine("|숫자가 틀리면 아웃입니다.                           |");
            Console.WriteLine("+----------------------------------------------------+");

            // 2. 수비수 (컴퓨터)
            Random random = new Random();

            int[] numbers = new int[3];
            int index = 0;

            while (index < 3)
            {
                numbers[index] = random.Next(0, 10);

                bool hasDuplicate = false;
                for (int i = 0; i < index; i++)
                {
                    if (numbers[index] == numbers[i])
                    {
                        hasDuplicate = true;
                        break;
                    }
                }

                if (!hasDuplicate)
                {
                    index++;
                }
            }

            // 3. 공격수 (사용자)
            int[] guesses = new int[3];
            string[] inputMessages = { "> 첫 번째 숫자를 입력하세요.", "> 두 번째 숫자를 입력하세요.", "> 세 번째 숫자를 입력하세요." };
            int tryNum = 0;

            while (true)
            {
                // 3-1. 숫자 입력 부 (공격수)
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(inputMessages[i]);
                    while (true)
                    {
                        bool isNumber = int.TryParse(Console.ReadLine(), out int num);
                        if (!isNumber)
                        {
                            Console.WriteLine("숫자를 입력하세요.");
                        }
                        else
                        {
                            bool isTrue = (num < 10 && num >= 0);
                            if (!isTrue)
                            {
                                Console.WriteLine("0~9 사이의 값을 입력하세요."); 
                            }
                            else
                            {
                                guesses[i] = num;
                                break;
                            }
                        }
                    }
                }
                
                // 3-2. 숫자 출력 부 (공격수)
                Console.WriteLine("> 공격수가 고른 숫자");
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(guesses[i]);
                }

                // 3-3. 중복 확인
                if (guesses[0] == guesses[1] || guesses[0] == guesses[2] || guesses[1] == guesses[2])
                {
                    Console.WriteLine("같은 숫자를 입력하면 안됩니다.");
                    continue;
                }

                // 3-4. 정답 확인
                int strikeCount = 0;
                int ballCount = 0;

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (guesses[i] == numbers[j])
                        {
                            if (i == j)
                            {
                                strikeCount++;
                            }
                            else
                            {
                                ballCount++;
                            }
                        }
                    }
                }

                Console.Write("[시도횟수: ");
                Console.Write(++tryNum);
                Console.WriteLine("회]");

                Console.Write("스트라이크: ");
                Console.WriteLine(strikeCount);
                Console.Write("볼: ");
                Console.WriteLine(ballCount);
                Console.Write("아웃: ");
                Console.WriteLine(3 - strikeCount - ballCount);

                if (strikeCount == 3)
                {
                    Console.WriteLine("정답입니다!");
                    break;
                }
            }
        }
    }
}
