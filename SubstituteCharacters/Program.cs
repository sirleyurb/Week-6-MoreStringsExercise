using System;

namespace SubstituteCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime ja erekonnanime
            //programm asendab kõik 'a' tähed kasutaja nimes tärniga (*)
            //programm kuvab tulemust konsoolis

            Console.WriteLine("sisesta eesnimi");
            string userName = Console.ReadLine();
            Console.WriteLine("sisesta perekonnanimi");
            string userLastName = Console.ReadLine();
            string fullName = $"{userName} {userLastName}";

            fullName = fullName.Replace('a', '*');

            Console.WriteLine(fullName);

        }
    }
}
