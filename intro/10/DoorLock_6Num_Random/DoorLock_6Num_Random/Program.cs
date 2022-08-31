using System;

namespace DoorLock_6Num_Random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 비밀번호 생성
            Random random = new Random();

            int passcodeLength = 6;
            int[] passcodeNumbers = new int[passcodeLength];

            Console.WriteLine("비밀번호: ");

            for (int i = 0; i < passcodeLength; i++)
            {
                passcodeNumbers[i] = random.Next(0, 10);
                Console.Write(passcodeNumbers[i]);
                Console.Write(" ");
            }
            Console.WriteLine();

            // 사용자 입력 부
            int[] userInput = new int[passcodeLength];

            while (true)
            {
                // 입력
                for (int passcodeIndex = 0; passcodeIndex < passcodeLength; passcodeIndex++)
                {
                    Console.Write(passcodeIndex+1);
                    Console.WriteLine("번째 숫자를 넣어주세요.");
                    while (true)
                    {
                        bool isNumber = int.TryParse(Console.ReadLine(), out int num);
                        if (!isNumber)
                        {
                            Console.WriteLine("숫자를 입력해 주세요.");
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
                                userInput[passcodeIndex] = num;
                                break;
                            }
                        }
                    }
                }

                // 틀림
                bool isPasswordCorrect = true;
                for (int passcodeIndex = 0; passcodeIndex < passcodeLength; passcodeIndex++)
                {
                    if (userInput[passcodeIndex] != passcodeNumbers[passcodeIndex])
                    {
                        isPasswordCorrect = false;
                        Console.WriteLine("비밀번호가 틀렸습니다");
                        break;
                    }
                }

                // 맞음
                if (isPasswordCorrect)
                {
                    Console.WriteLine("문이 열렸습니다.");
                    break;
                }
            }
        }
    }
}
