using System;

namespace Q_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] passcodeNumbers = { 6, 2, 1, 9, 4, 7 };

            int passcodeLength = 6;
            int[] userInput = new int[passcodeLength];

            for (int i = 0; i < 5; i++)
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
            }                                                                                   // 심화 9-1*/

            int[] classes = new int[5];
            int[] students = new int[10];

            for (int i = 0; i < classes.Length; i++)
            {
                for (int j = 0; j < students.Length; j++)
                {

                }
            }                                                                                   // 심화 9-2
        }
    }
}
