using System;

namespace Q_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("학생 숫자를 입력하세요");
            int studentCount = int.Parse(Console.ReadLine());

            int[] ages = new int[studentCount];
            string[] names = new string[studentCount];
            double[] heights = new double[studentCount];
            double[] weights = new double[studentCount];

            Console.WriteLine("몇 번째 학생의 정보를 추가할까요?");
            int studentNumber = int.Parse(Console.ReadLine());

            if (studentNumber >= 0 && studentNumber <= studentCount - 1)
            {
                Console.WriteLine("나이를 입력하세요");
                ages[studentNumber] = int.Parse(Console.ReadLine());

                Console.WriteLine("이름을 입력하세요");
                names[studentNumber] = Console.ReadLine();

                Console.WriteLine("키를 입력하세요");
                heights[studentNumber] = double.Parse(Console.ReadLine());
                
                Console.WriteLine("몸무게를 입력하세요");
                weights[studentNumber] = double.Parse(Console.ReadLine());

                Console.Write(studentNumber);
                Console.WriteLine("번째 학생");
                Console.Write("이름: ");
                Console.WriteLine(names[studentNumber]);
                Console.Write("나이: ");
                Console.WriteLine(ages[studentNumber]);
                Console.Write("키: ");
                Console.WriteLine(heights[studentNumber]);
                Console.Write("몸무게: ");
                Console.WriteLine(weights[studentNumber]);
            }
            else
            {
                Console.Write("0에서 ");
                Console.Write(studentCount - 1);
                Console.WriteLine("사이의 숫자를 입력하세요.");
            }                                                                       // 심화 7-1*/

            int[] scores = new int[5];
            Console.WriteLine("국어 점수를 입력해주세요.");
            scores[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("영어 점수를 입력해주세요.");
            scores[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("수학 점수를 입력해주세요.");
            scores[2] = int.Parse(Console.ReadLine());
            Console.WriteLine("과학 점수를 입력해주세요.");
            scores[3] = int.Parse(Console.ReadLine());
            Console.WriteLine("사회 점수를 입력해주세요.");
            scores[4] = int.Parse(Console.ReadLine());

            Console.Write("국어: ");
            Console.WriteLine(scores[0]);
            Console.Write("영어: ");
            Console.WriteLine(scores[1]);
            Console.Write("수학: ");
            Console.WriteLine(scores[2]);
            Console.Write("과학: ");
            Console.WriteLine(scores[3]);
            Console.Write("사회: ");
            Console.WriteLine(scores[4]);                                              // 심화 7-2
        }
    }
}
