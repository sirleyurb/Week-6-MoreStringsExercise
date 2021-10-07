using System;

namespace WordCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab, mitu sõna on lauses "Hello World!"

            string helloworld = "Hello World";

            //while

            int i = 0;
            int wordCounter = 1;

            while (i < helloworld.Length)
            {
                if (helloworld[i] == ' ')
                {
                    wordCounter++;
                }
                i++;
            }
            Console.WriteLine($"Lauase {helloworld} on {wordCounter} sõna");
        }
    }
}
