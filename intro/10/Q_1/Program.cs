using System;

namespace Q_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Random random = new Random();
            Console.WriteLine(random.Next(3, 10));
            Console.WriteLine(random.Next(-2, 4));*/                                                        // 기초 10-1

            /*int lottoLength = 6;
            int[] lottoNumbers = new int[lottoLength];

            Random random = new Random();

            int lottoNumberIndex = 0;
            while (lottoNumberIndex < lottoLength)
            {
                lottoNumbers[lottoNumberIndex] = random.Next(5, 60);

                bool hasDuplicate = false;
                for (int i = 0; i < lottoNumberIndex; i++)
                {
                    if (lottoNumbers[lottoNumberIndex] == lottoNumbers[i])
                    {
                        hasDuplicate = true;
                        break;
                    }
                }

                if (!hasDuplicate)
                {
                    lottoNumberIndex++;
                }
            }

            Console.Write("로또번호: ");
            for (int i = 0; i < lottoLength; i++)
            {
                Console.Write(lottoNumbers[i]);
                Console.Write(", ");
            }
            Console.WriteLine();*/                                                                         // 기초 10-2

            Random random = new Random();

            int randomNumber = random.Next(8, 50);

            Console.Write("고른숫자: ");
            Console.WriteLine(randomNumber);                                                                // 기초 10-3
        }
    }
}
