using System;

namespace Q_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] passcodeNumbers = { 6, 2, 1, 9, 4, 7 };
            int[] userInput = new int[6];

            while (true)
            {
                int index = 0;
                while (index < 6)
                {
                    Console.Write(index + 1);
                    Console.WriteLine(" 번째 숫자를 넣어주세요");
                    userInput[index] = int.Parse(Console.ReadLine());
                    index++;
                }

                if (passcodeNumbers[0] == userInput[0] && passcodeNumbers[1] == userInput[1] && passcodeNumbers[2] == userInput[2] && passcodeNumbers[3] == userInput[3] && passcodeNumbers[4] == userInput[4] && passcodeNumbers[5] == userInput[5])
                {
                    Console.WriteLine("문이 열렸습니다.");
                    break;
                }
                else
                {
                    Console.WriteLine("비밀번호가 틀렸습니다");
                }
            }                                                           // 심화 8-1*/

            /*Console.WriteLine("총 학생 수를 입력하세요");
            int studentCount = int.Parse(Console.ReadLine());
            int index = 0;
            int[] subjects = new int[studentCount];
            int[] averages = new int[studentCount];

            while (index < studentCount)
            {
                Console.WriteLine(index + 1 + "번째 학생의 ");
                Console.WriteLine("국어 점수를 입력하세요");
                int sub1 = int.Parse(Console.ReadLine());

                Console.WriteLine("영어 점수를 입력하세요");
                int sub2 = int.Parse(Console.ReadLine());

                Console.WriteLine("수학 점수를 입력하세요");
                int sub3 = int.Parse(Console.ReadLine());

                subjects[index] = sub1 + sub2 + sub3;
                averages[index] = subjects[index] / studentCount;
              
                index++;
            }
            index = 0;
            while (index < studentCount)
            {
                Console.Write(index + "번째 학생의");
                Console.Write("총점: ");
                Console.WriteLine(subjects[index]);
                Console.Write("평균: ");
                Console.WriteLine(averages[index]);
                index++;
            }*/

            Console.WriteLine("총 학생 수를 입력하세요");
            int studentCount = int.Parse(Console.ReadLine());
            int index = 0;
            double[] korean = new double[studentCount];
            double[] english = new double[studentCount];
            double[] math = new double[studentCount];

            while (index < studentCount)
            {
                Console.WriteLine(index + 1 + "번째 학생의 ");
                Console.WriteLine("국어 점수를 입력하세요");
                korean[index] = double.Parse(Console.ReadLine());

                Console.WriteLine("영어 점수를 입력하세요");
                english[index] = double.Parse(Console.ReadLine());

                Console.WriteLine("수학 점수를 입력하세요");
                math[index] = double.Parse(Console.ReadLine());

                index++;
            }
            index = 0;
            while (index < studentCount)
            {
                double totalScore = korean[index] + english[index] + math[index];
                
                Console.Write(index + 1+ "번째 학생의 총점: ");
                Console.WriteLine(totalScore);
                Console.Write(index + 1 + "번째 학생의 평균: ");
                Console.WriteLine(totalScore / 3);
                index++;
            }
        }
    }
}
