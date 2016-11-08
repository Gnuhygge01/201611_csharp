using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03ValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Boolean b1;
            b1 = false;

            bool b2;
            b2 = true;

            System.Int32 i = 100;
            int x = 200;

            System.Double d = 100.4;
            double k = 300.23;

            System.Byte b = 1;
            byte nyb = 23;
            Console.WriteLine(int.MinValue);
            Console.WriteLine(System.Int32.MaxValue);
            Console.WriteLine(byte.MinValue);
            Console.WriteLine(byte.MaxValue);

            // mest brugte
            // int , double, bool

            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);

            char t = 'Y';


            System.DateTime dato;
            dato = System.DateTime.Now;
            System.DateTime dato2 =
                new DateTime(2016, 12, 24);

            System.TimeSpan ts = dato.Subtract(dato2);
            Console.WriteLine(ts.TotalDays);


            const int antalMånederPrÅr = 12;

            // Bør være en config
            const double momsPct = 0.25;

            int res = 5 % 10;   // = 0

            i = i + 1;
            i++;

            i = i + 5;
            i += 5;

            i = i - 1;
            i--;

            if ((i < 10 && x == 5) || momsPct<0.4)
            { }
            else
            { }

            short s;
            s = (short)i;   // Ingen exception
            s = System.Convert.ToInt16(i);  // Exception
            s = System.Convert.ToInt16("4");

            checked
            {
                byte r = byte.MaxValue;
                Console.WriteLine(r);
                r++;
                Console.WriteLine(r);
                r++;
                Console.WriteLine(r);
            }



            //int minInt = 32;
            var minInt = 32;

            var navn = "skjlæksdjf";
            
            //var mitKommatal = 3.45;
            double mitKommatal = 3.45;

            // 1 = mand, 2 = kvinde
            int køn = 1;
            Køn kk = Køn.Mand;
            int værdi = (int)kk;

            // Sammensat datatype
            Person p1;
            p1.fornavn = "Mikkel";
            p1.efternavn = "Cronberg";

            Person p2;
            p2.fornavn = "Mathias";
            p2.efternavn = "Cronberg";

            


        }





        static void test() { }
    }

    public struct Person {
        public string fornavn;
        public string efternavn;
        public int alder;
    }
    public enum Køn
    {
        Mand = 10,
        Kvinde = 20
    }
}
