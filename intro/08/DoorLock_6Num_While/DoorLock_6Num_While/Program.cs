using System;

namespace DoorLock_6Num_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] passcodeNumbers = { 6, 2, 1, 9, 4, 7 };
            int[] userInput = new int[6];

            // userInput과 passcodeNumbers 중 하나라도 같지 않다면 반복
            /*while (userInput[0] != passcodeNumbers[0] || userInput[1] != passcodeNumbers[1] || userInput[2] != passcodeNumbers[2] || userInput[3] != passcodeNumbers[3] || userInput[4] != passcodeNumbers[4] || userInput[5] != passcodeNumbers[5])
            {*/
            while (true)
            { 
                Console.WriteLine("첫 번째 숫자를 넣어주세요");
                userInput[0] = int.Parse(Console.ReadLine());
                Console.WriteLine("두 번째 숫자를 넣어주세요");
                userInput[1] = int.Parse(Console.ReadLine());
                Console.WriteLine("세 번째 숫자를 넣어주세요");
                userInput[2] = int.Parse(Console.ReadLine());
                Console.WriteLine("네 번째 숫자를 넣어주세요");
                userInput[3] = int.Parse(Console.ReadLine());
                Console.WriteLine("다섯 번째 숫자를 넣어주세요");
                userInput[4] = int.Parse(Console.ReadLine());
                Console.WriteLine("여섯 번째 숫자를 넣어주세요");
                userInput[5] = int.Parse(Console.ReadLine());

                if (passcodeNumbers[0] == userInput[0] && passcodeNumbers[1] == userInput[1] && passcodeNumbers[2] == userInput[2] && passcodeNumbers[3] == userInput[3] && passcodeNumbers[4] == userInput[4] && passcodeNumbers[5] == userInput[5])
                {
                    Console.WriteLine("문이 열렸습니다.");
                    break;                                                   // 코드 8-5 (break)
                }
                else
                {
                    Console.WriteLine("비밀번호가 틀렸습니다");
                }                                                           // 코드 8-2

                // 반복문을 사용하지 않은 비밀번호 재입력 코드
                /*if (passcodeNumbers[0] == userInput[0] && passcodeNumbers[1] == userInput[1] && passcodeNumbers[2] == userInput[2] && passcodeNumbers[3] == userInput[3] && passcodeNumbers[4] == userInput[4] && passcodeNumbers[5] == userInput[5])
                {
                    Console.WriteLine("문이 열렸습니다.");
                }
                else
                {
                    Console.WriteLine("비밀번호가 틀렸습니다");

                    Console.WriteLine("첫 번째 숫자를 넣어주세요");
                    userInput[0] = int.Parse(Console.ReadLine());
                    Console.WriteLine("두 번째 숫자를 넣어주세요");
                    userInput[1] = int.Parse(Console.ReadLine());
                    Console.WriteLine("세 번째 숫자를 넣어주세요");
                    userInput[2] = int.Parse(Console.ReadLine());
                    Console.WriteLine("네 번째 숫자를 넣어주세요");
                    userInput[3] = int.Parse(Console.ReadLine());
                    Console.WriteLine("다섯 번째 숫자를 넣어주세요");
                    userInput[4] = int.Parse(Console.ReadLine());
                    Console.WriteLine("여섯 번째 숫자를 넣어주세요");
                    userInput[5] = int.Parse(Console.ReadLine());

                    if (passcodeNumbers[0] == userInput[0] && passcodeNumbers[1] == userInput[1] && passcodeNumbers[2] == userInput[2] && passcodeNumbers[3] == userInput[3] && passcodeNumbers[4] == userInput[4] && passcodeNumbers[5] == userInput[5])
                    {
                        Console.WriteLine("문이 열렸습니다");
                    }
                    else
                    {
                        Console.WriteLine("비밀번호가 틀렸습니다");
                    }
                }                                                                       // 코드 8-1*/
            }
        }
    }
}
