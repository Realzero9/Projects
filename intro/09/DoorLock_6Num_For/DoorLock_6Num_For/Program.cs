using System;

namespace DoorLock_6Num_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] passcodeNumbers = { 6, 2, 1, 9, 4, 7 };

            int passcodeLength = 6;
            int[] userInput = new int[passcodeLength];

            while (true)
            {
                for (int passcodeIndex = 0; passcodeIndex < passcodeLength; passcodeIndex++)    // 숫자 입력 반복문
                {
                    Console.Write(passcodeIndex);
                    Console.WriteLine("번째 숫자를 넣어주세요.");
                    userInput[passcodeIndex] = int.Parse(Console.ReadLine());
                }

                bool isPasswordCorrect = true;
                for (int passcodeIndex = 0; passcodeIndex < passcodeLength; passcodeIndex++)    // 입력한 숫자와 비밀번호가 같은지 확인할 반복문
                {
                    if (userInput[passcodeIndex] != passcodeNumbers[passcodeIndex])
                    {
                        isPasswordCorrect = false;
                        Console.WriteLine("비밀번호가 틀렸습니다");
                        break;
                    }
                }
                if (isPasswordCorrect)
                {
                    Console.WriteLine("문이 열렸습니다.");
                    break;
                }

                /*코드 9-2 부분
               int passcodeIndex = 0;
               while (passcodeIndex < passcodeLength)
               {
                   Console.Write(passcodeIndex);
                   Console.WriteLine("번째 숫자를 넣어주세요.");
                   userInput[passcodeIndex] = int.Parse(Console.ReadLine());
                   passcodeIndex = passcodeIndex + 1;
               }
               if (passcodeNumbers[0] == userInput[0] && passcodeNumbers[1] == userInput[1] && passcodeNumbers[2] == userInput[2] && passcodeNumbers[3] == userInput[3] && passcodeNumbers[4] == userInput[4] && passcodeNumbers[5] == userInput[5])
               {
                   Console.WriteLine("문이 열렸습니다.");
                   break;
               }
               else
               {
                   Console.WriteLine("비밀번호가 틀렸습니다");
               }*/
            }
        }
    }
}
