using System;

namespace Q_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("첫 번째 숫자를 입력하세요");
            string userInput1 = Console.ReadLine();
            Console.WriteLine("두 번째 숫자를 입력하세요");
            string userInput2 = Console.ReadLine();
            int number1 = int.Parse(userInput1);
            int number2 = int.Parse(userInput2);

            Console.WriteLine(number1 + number2);
            Console.WriteLine(number1 - number2);
            Console.WriteLine(number1 * number2);
            Console.WriteLine(number1 / number2);               // 심화 5-1

            Console.WriteLine(number1 / 0);                     // 심화 5-2*/

            Console.WriteLine("주머니에는 동전이 10개 들어있습니다.");
            int pocket = 10;
            Console.WriteLine("어머니는 몇 개의 동전을 주머니에 넣었나요?");
            pocket = pocket + int.Parse(Console.ReadLine());
            Console.WriteLine("아람이는 몇 개의 동전을 꺼냈나요?");
            pocket = pocket - int.Parse(Console.ReadLine());
            Console.WriteLine("우람이는 몇 개의 동전을 꺼냈나요?");
            pocket = pocket - int.Parse(Console.ReadLine());
            Console.Write("주머니에 남아있는 동전의 개수는 ");
            Console.WriteLine(pocket + "개 입니다.");           // 심화 5-3
        }
    }
}
