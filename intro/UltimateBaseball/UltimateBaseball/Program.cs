using System;

namespace UltimateBaseball
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+----------------------------------------------------+");
            Console.WriteLine("|               궁극의 숫자야구 게임                 |");
            Console.WriteLine("+----------------------------------------------------+");
            Console.WriteLine("|컴퓨터가 수비수가 되어 세 자릿수를 하나 골랐습니다. |");
            Console.WriteLine("|각 숫자는 0~9중에 하나며 중복되는 숫자는 없습니다.  |");
            Console.WriteLine("|모든 숫자와 위치를 맞히면 승리합니다.               |");
            Console.WriteLine("|숫자와 순서가 둘 다 맞으면 스트라이크입니다.        |");
            Console.WriteLine("|숫자만 맞고 순서가 틀리면 볼입니다.                 |");
            Console.WriteLine("|숫자가 틀리면 아웃입니다.                           |");
            Console.WriteLine("+----------------------------------------------------+");             // 2-8

            /*Console.WriteLine("> 수비수가 고른 숫자");*/
            /*int number1 = 3;
            int number2 = 1;
            int number3 = 9;*/
            /*Console.WriteLine(number1);
            Console.WriteLine(number2);
            Console.WriteLine(number3);*/                                                           // 3-5, 3-6

            /*Console.WriteLine("> 첫 번째 숫자를 입력하세요.");
            int guess1 = int.Parse(Console.ReadLine());
            Console.WriteLine("> 두 번째 숫자를 입력하세요.");
            int guess2 = int.Parse(Console.ReadLine());
            Console.WriteLine("> 세 번째 숫자를 입력하세요.");
            int guess3 = int.Parse(Console.ReadLine());*/                                           // 5-5

            /*int[] numbers = { 3, 1, 9 };
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);*/                                                        // 7-5

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
            }                                                                                       // 10-3

            /*Console.WriteLine("> 수비수가 고른 숫자");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(numbers[i]);
            }*/                                                                                       // 9-5

            int[] guesses = new int[3];
            string[] inputMessages = { "> 첫 번째 숫자를 입력하세요.", "> 두 번째 숫자를 입력하세요.", "> 세 번째 숫자를 입력하세요." };

            while (true)
            {
                /*Console.WriteLine("> 첫 번째 숫자를 입력하세요.");
                guesses[0] = int.Parse(Console.ReadLine());
                Console.WriteLine("> 두 번째 숫자를 입력하세요.");
                guesses[1] = int.Parse(Console.ReadLine());
                Console.WriteLine("> 세 번째 숫자를 입력하세요.");
                guesses[2] = int.Parse(Console.ReadLine());*/                                       

                /*Console.WriteLine("> 공격수가 고른 숫자");
                Console.WriteLine(guess1);
                Console.WriteLine(guess2);
                Console.WriteLine(guess3);*/                                                        // 5-5

                /*Console.WriteLine("> 공격수가 고른 숫자");
                Console.WriteLine(guesses[0]);
                Console.WriteLine(guesses[1]);
                Console.WriteLine(guesses[2]);*/                                                    // 7-5

                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(inputMessages[i]);
                    guesses[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("> 공격수가 고른 숫자");
                
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(guesses[i]);
                }                                                                                   // 9-5

                /*if (guess1 == guess2 || guess1 == guess3 || guess2 == guess3)*/                   // 6-5
                if (guesses[0] == guesses[1] || guesses[0] == guesses[2] || guesses[1] == guesses[2])
                {
                    Console.WriteLine("같은 숫자를 입력하면 안됩니다.");
                    continue;
                }                                                                                  // 6-10

                int strikeCount = 0;
                int ballCount = 0;

                /*if (guess1 == number1)*//*                                                          // 6-5
                if (guesses[0] == numbers[0])
                {
                    strikeCount = strikeCount + 1;
                }
                *//*else if (guess1 == number2 || guess1 == number3)*//*                                // 6-5
                else if (guesses[0] == numbers[1] || guesses[0] == numbers[2])
                {
                    ballCount = ballCount + 1;
                }

                *//*if (guess2 == number2)*//*                                                          // 6-5
                if (guesses[1] == numbers[1])
                {
                    strikeCount = strikeCount + 1;
                }
                *//*else if (guess2 == number1 || guess2 == number3)*//*                                // 6-5
                else if (guesses[1] == numbers[0] || guesses[1] == numbers[2])
                {
                    ballCount = ballCount + 1;
                }

                *//* if (guess3 == number3)*//*                                                         // 6-5
                if (guesses[2] == numbers[2])
                {
                    strikeCount = strikeCount + 1;
                }
                *//*else if (guess3 == number1 || guess3 == number2)*//*                                // 6-5
                else if (guesses[2] == numbers[0] || guesses[2] == numbers[1])
                {
                    ballCount = ballCount + 1;
                }*/

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
                }                                                                                       // 9-5

                Console.Write("스트라이크: ");
                Console.WriteLine(strikeCount);
                Console.Write("볼: ");
                Console.WriteLine(ballCount);
                Console.Write("아웃: ");
                Console.WriteLine(3 - strikeCount - ballCount);                                         // 6-9

                /*if (guesses[0] == numbers[0] && guesses[1] == numbers[1] && guesses[2] == numbers[2])*/   // 8-6
                if (strikeCount == 3)
                {
                    Console.WriteLine("정답입니다!");
                    break;
                }
            }

            /*Console.WriteLine("> 수비수가 다시 고른 숫자");
            number1 = 8;
            number2 = 2;
            number3 = 0;
            Console.WriteLine(number1);
            Console.WriteLine(number2);
            Console.WriteLine(number3);*/                                                               // 4-8
        }
    }
}
