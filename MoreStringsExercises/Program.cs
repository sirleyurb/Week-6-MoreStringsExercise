using System;

namespace MoreStringsExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab sõna "racerar" tagurpidi
            string raceC = "racerar";
            for (int i = raceC.Length - 1; i >= 0; i--)
            {
                Console.Write(raceC[i]);

            }
        }    
    }
}
