using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("첫 번째 숫자를 입력하세요.");
            string userInput1 = Console.ReadLine();
            int number1 = int.Parse(userInput1);
            Console.WriteLine("두 번째 숫자를 입력하세요.");
            string userInput2 = Console.ReadLine();
            int number2 = int.Parse(userInput2);
            Console.WriteLine("연산자를 입력하세요");
            string inputOperator = Console.ReadLine();

            Console.Write(number1);
            Console.Write(inputOperator);
            Console.Write(number2);
            Console.Write(" = ");
            Console.WriteLine(number1 inputOperator number2);       // 코드 6-1*/

            Console.WriteLine("첫 번째 숫자를 입력하세요.");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("두 번째 숫자를 입력하세요.");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("연산자를 입력하세요");
            string inputOperator = Console.ReadLine();

            Console.Write(number1);
            Console.Write(inputOperator);
            Console.Write(number2);
            Console.Write(" = ");

            /*if (inputOperator == "+")
            { 
                Console.WriteLine(number1 + number2);
            }
            if (inputOperator == "-")
            {
                Console.WriteLine(number1 - number2);
            }
            if (inputOperator == "*")
            {
                Console.WriteLine(number1 * number2);
            }
            if (inputOperator == "/")
            {
                Console.WriteLine(number1 / number2);
            }                                                       // 코드 6-3*/

            /*if (inputOperator == "+")
            {
                Console.WriteLine(number1 + number2);
            }
            else
            {
                if (inputOperator == "-")
                {
                    Console.WriteLine(number1 - number2);
                }
                else
                {
                    if (inputOperator == "*")
                    {
                        Console.WriteLine(number1 * number2);
                    }
                    if (inputOperator == "/")
                    {
                        Console.WriteLine(number1 / number2);
                    }
                }
            }                                                       // 코드 6-4, 6-5*/
            
            if (inputOperator == "+")
            {
                Console.WriteLine(number1 + number2);
            }
            else if (inputOperator == "-")
            {
                Console.WriteLine(number1 - number2);
            }
            else if (inputOperator == "*")
            {
                Console.WriteLine(number1 * number2);
            }
            else if (inputOperator == "/")
            {
                Console.WriteLine(number1 / number2);
            }                                                       // 코드 6-6
        }
    }
}
