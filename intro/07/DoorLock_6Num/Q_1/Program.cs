using System;

namespace Q_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*double weight1 = double.Parse(Console.ReadLine());
            double weight2 = double.Parse(Console.ReadLine());
            double weight3 = double.Parse(Console.ReadLine());

            Console.Write("첫번째 무게: ");
            Console.WriteLine(weight1);
            Console.Write("두번째 무게: ");
            Console.WriteLine(weight2);
            Console.Write("세번째 무게: ");
            Console.WriteLine(weight3);*//*

            double[] weights = new double[3];
            weights[0] = double.Parse(Console.ReadLine());
            weights[1] = double.Parse(Console.ReadLine());
            weights[2] = double.Parse(Console.ReadLine());

            Console.Write("첫번째 무게: ");
            Console.WriteLine(weights[0]);
            Console.Write("두번째 무게: ");
            Console.WriteLine(weights[1]);
            Console.Write("세번째 무게: ");
            Console.WriteLine(weights[2]);                                  // 기초 7-1

            *//*string studentName1 = "홍길동";
            string studentName2 = "김철수";
            string studentName3 = "이영희";

            Console.WriteLine(studentName1);
            Console.WriteLine(studentName2);
            Console.WriteLine(studentName3);*//*

            string[] studentNames = new string[3];
            studentNames[0] = Console.ReadLine();
            studentNames[1] = Console.ReadLine();
            studentNames[2] = Console.ReadLine();

            Console.WriteLine(studentNames[0]);
            Console.WriteLine(studentNames[1]);
            Console.WriteLine(studentNames[2]);                            // 기초 7-2

            *//*int scores = { 90, 85, 73, 100 };
            
            Console.WriteLine(scores[0]);
            Console.WriteLine(scores[1]);
            Console.WriteLine(scores[2]);
            Console.WriteLine(scores[3]);*//*

            int[] scores = { 90, 85, 73, 100 };

            Console.WriteLine(scores[0]);
            Console.WriteLine(scores[1]);
            Console.WriteLine(scores[2]);
            Console.WriteLine(scores[3]);                                   // 기초 7-3*/

            string[] subjects = { "국어", "영어", "수학" };
            int[] scores = new int[3];

            Console.Write(subjects[0]);
            Console.WriteLine(" 점수를 입력하세요.");
            scores[0] = int.Parse(Console.ReadLine());
            
            Console.Write(subjects[1]);
            Console.WriteLine(" 점수를 입력하세요.");
            scores[1] = int.Parse(Console.ReadLine());
            
            Console.Write(subjects[2]);
            Console.WriteLine(" 점수를 입력하세요.");
            scores[2] = int.Parse(Console.ReadLine());
            
            Console.Write(subjects[0]);
            Console.Write("점수: ");
            Console.WriteLine(scores[0]);
            
            Console.Write(subjects[1]);
            Console.Write("점수: ");
            Console.WriteLine(scores[1]);
            
            Console.Write(subjects[2]);
            Console.Write("점수: ");
            Console.WriteLine(scores[2]);                                   // 기초 7-4
        }
    }
}
