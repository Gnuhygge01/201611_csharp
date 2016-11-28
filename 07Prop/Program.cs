using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _07Prop
{
    class Program
    {
        
        private static System.Random rnd = new Random();
        //private static double momsPct = 0.25;
        static void Main(string[] args)
        {

            //WriteLine()

            //if(args.Length>0)
            //    Console.WriteLine(args[0]);

            //return;

            // Kræver ref til System.Configuration
            //var m = System.Configuration.ConfigurationManager.AppSettings["moms"];
            //Console.WriteLine(m);

            //Console.WriteLine(Properties.Settings.Default.MomsPct);
            //Properties.Settings.Default.MomsPct = 0.3;
            //Properties.Settings.Default.Save();
            //Properties.Settings.Default.Farve = System.Drawing.Color.Beige;
            //Properties.Settings.Default.Const = "læsjæfld";



            Bil b = new Bil();

            b.Model = "x";
            var m = b.Model;


            //b.Set_Model("x12");
            //Console.WriteLine(b.Get_Model());


            return;
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
