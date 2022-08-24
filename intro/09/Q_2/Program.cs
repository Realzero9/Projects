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

            int classes = 5;
            int students = 10;
            double[] classScores = new double[classes];


            for (int i = 0; i < classes; i++)
            {
                Console.Write("3학년");
                Console.Write(i + 1);
                Console.WriteLine("반 성적을 입력합니다.");

                for (int j = 0; j < students; j++)
                {
                    Console.Write(j + 1);
                    Console.WriteLine("번째 학생의 성적을 입력해주세요.");
                    classScores[i] = classScores[i] + double.Parse(Console.ReadLine());
                }
            }
            
            for (int i = 0; i < 5; i++)
            {
                Console.Write("3학년 ");
                Console.Write(i + 1);
                Console.Write("반의 평균: ");
                Console.WriteLine(classScores[i] / students);
            }                                                                                   // 심화 9-2
        }
    }
}
