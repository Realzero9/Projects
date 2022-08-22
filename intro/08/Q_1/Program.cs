using System;

namespace Q_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] scores = new int[5];
            Console.Write(0);
            Console.WriteLine("번째 과목의 성적을 입력하세요.");
            scores[0] = int.Parse(Console.ReadLine());

            Console.Write(1);
            Console.WriteLine("번째 과목의 성적을 입력하세요.");
            scores[1] = int.Parse(Console.ReadLine());

            Console.Write(2);
            Console.WriteLine("번째 과목의 성적을 입력하세요.");
            scores[2] = int.Parse(Console.ReadLine());

            Console.Write(3);
            Console.WriteLine("번째 과목의 성적을 입력하세요.");
            scores[3] = int.Parse(Console.ReadLine());

            Console.Write(4);
            Console.WriteLine("번째 과목의 성적을 입력하세요.");
            scores[4] = int.Parse(Console.ReadLine());

            Console.Write("총점은 ");
            Console.WriteLine(scores[0] + scores[1] + scores[2] + scores[3] + scores[4]);
            Console.WriteLine("점입니다.");                                                 // 기초 8-1*/


            /*Console.WriteLine("입력할 과목의 개수를 설정하세요.");
            int count = int.Parse(Console.ReadLine());

            int[] scores = new int[count];
            int countNum = 0;

            while (countNum < count)
            {
                Console.Write(countNum+1);
                Console.WriteLine("번째 과목의 성적을 입력하세요.");
                scores[countNum] = int.Parse(Console.ReadLine());

                countNum++;
            }

            Console.Write("총점은 ");
            Console.WriteLine(scores[0] + scores[1] + scores[2] + scores[3] + scores[4]);
            Console.WriteLine("점입니다.");                                                 // 기초 8-1 풀이*/

            /*Console.WriteLine("수업을 몇 과목 들었습니까?");
             int subjectCount = int.Parse(Console.ReadLine());

             int[] scores = new int[subjectCount];
             int index = 0;
             int total = 0;


             while (index < subjectCount)
             {
                 Console.Write(index);
                 Console.WriteLine("번째 과목의 성적을 입력하세요.");
                 scores[index] = int.Parse(Console.ReadLine());
                 total = total + scores[index];
                 index++;
             }

             Console.Write("평균은 ");
             Console.Write(total / subjectCount);
             Console.WriteLine("점입니다.");                                                 // 기초 8-2*/

            /*Console.WriteLine("몇 명의 친구들에게 사과를 나눠줄까요?");
            int friendCount = int.Parse(Console.ReadLine());

            int[] appleNumbers = new int[friendCount];
            int index = 0; // 수정1
            int total = 0; // 수정2

            while (index < friendCount)
            {
                Console.Write(index);
                Console.WriteLine("번째 친구가 가져갈 사과는 몇 개인가요?");
                appleNumbers[index] = int.Parse(Console.ReadLine());
                total = total + appleNumbers[index];
                index++; // 수정3
            }

            Console.Write("친구들에게 ");
            Console.Write(total);
            Console.WriteLine("개의 사과를 나눠줬습니다.");                                    // 기초 8-3*/

            /*string userInput = "";

            while (userInput != "끝")
            {
                Console.WriteLine("아무 글자나 입력하세요. 끝내려면 '끝'을 입력하세요.");
                userInput = Console.ReadLine();
                Console.WriteLine(userInput);
            }                                                                                   // 기초 8-4*/

            string userInput = "";

            while (true)
            {
                Console.WriteLine("아무 글자나 입력하세요. 끝내려면 '끝'을 입력하세요.");
                userInput = Console.ReadLine();
                Console.WriteLine(userInput);

                if (userInput == "끝")
                {
                    break;
                }
            }                                                                                   // 기초 8-4 풀이
        }
    }
}
