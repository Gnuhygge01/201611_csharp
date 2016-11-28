using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Prop
{
    class Program
    {

        private static System.Random rnd = new Random();

        static void Main(string[] args)
        {
            
            A a = new A();
            Console.WriteLine(A.moms);

            Person p = new Person();
            p.InitialiserPerson(1);

            Person p1 = PersonHjælpeMetoder.HentPerson(1);

            Person p2 = Person.HentPerson(1);

            Program.rnd.Next(0, 100);
            Program.rnd.Next(0, 100);

            
            for (int i = 0; i < 100; i++)
            {
                var r = new System.Random();
                Console.WriteLine(r.Next(0, 100));
            }

        }
    }


    class A {
        public static double moms = 0.25;
        public static int AntalMdr = 12;

        public static void Gem() { }
    }

    static class PersonHjælpeMetoder {
        public static Person HentPerson(int id) {
            Person p = new Person();
            // kode...
            p.Fornavn = ""; // fra database
            return p;
        }
    }

    class Person {
        public string Fornavn;

        public void InitialiserPerson(int id)
        {
            // kode...
            Fornavn = ""; // fra database
        }

        public static Person HentPerson(int id)
        {
            Person p = new Person();
            // kode...
            p.Fornavn = ""; // fra database
            return p;
        }
    }
}
