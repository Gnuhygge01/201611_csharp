using System;
using System.IO;

namespace _02HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sæt farve
            Console.ForegroundColor = ConsoleColor.Yellow;

            // Udskriv linje
            Console.WriteLine("Test");

            // Udskriv uden linjesk.
            Console.Write("a");
            Console.Write("B");

            // Input fra bruger
            string indtastet;
            indtastet = Console.ReadLine();


            Console.WriteLine("Der er skrevet...: " + indtastet);
            Console.WriteLine("Der er skrevet...: {0}", indtastet);

            double moms = 0.25;
            Console.WriteLine("Moms er {0} og bruges ved alle beregninger.", moms);
            Console.WriteLine("Moms er {0:P2} og bruges ved alle beregninger.", moms);
            double tal = 34903804.345;
            Console.WriteLine("Tal er {0:N4}", tal);

            // Venter på at brugeren taster et-eller-andet
            Console.ReadKey();
            // Ny kommentar
            Console.ReadKey();


            Test(45);
            Test(10);
            A();
        }

        /// <summary>
        /// Denne metoder gør .....
        /// </summary>
        /// <param name="tal">denne parameter .....</param>
        static void Test(int tal) {

        }

        static void A()
        {
            B();
        }
        static void B()
        {
            C();
        }
        static void C()
        {
            
            // kode...
        }


    }
}
