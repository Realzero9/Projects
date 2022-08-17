using System;

namespace DoorLock_6Num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int passcodeNumber1 = 6;
            int passcodeNumber2 = 2;
            int passcodeNumber3 = 1;
            int passcodeNumber4 = 9;
            int passcodeNumber5 = 4;
            int passcodeNumber6 = 7;

            Console.WriteLine("첫 번째 숫자를 넣어주세요");
            int userInput1 = int.Parse(Console.ReadLine());
            Console.WriteLine("두 번째 숫자를 넣어주세요");
            int userInput2 = int.Parse(Console.ReadLine());
            Console.WriteLine("세 번째 숫자를 넣어주세요");
            int userInput3 = int.Parse(Console.ReadLine());
            Console.WriteLine("네 번째 숫자를 넣어주세요");
            int userInput4 = int.Parse(Console.ReadLine());
            Console.WriteLine("다섯 번째 숫자를 넣어주세요");
            int userInput5 = int.Parse(Console.ReadLine());
            Console.WriteLine("여섯 번째 숫자를 넣어주세요");
            int userInput6 = int.Parse(Console.ReadLine());

            if (userInput1 == passcodeNumber1 && userInput2 == passcodeNumber2 && userInput3 == passcodeNumber3 && userInput4 == passcodeNumber4 && userInput5 == passcodeNumber5 && userInput6 == passcodeNumber6)
            {
                Console.WriteLine("문이 열렸습니다.");
            }
            else
            {
                Console.WriteLine("비밀번호가 틀렸습니다");
            }                                                           // 코드 7-1*/

            int[] passcodeNumbers = { 6, 2, 1, 9, 4, 7 };
            int[] userInput = new int[6];
            
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
            }
            else
            {
                Console.WriteLine("비밀번호가 틀렸습니다");
            }
        }
    }
}
